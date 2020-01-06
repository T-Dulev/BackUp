using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace FileBackUp
{
    public partial class MainForm : Form
    {
        List<string> groupFolders = new List<string>();
        string folderList = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnLoadList_Click(object sender, EventArgs e)
        {
            listFolders.Items.Clear();

            // зареждане на папките от избраната група
            var appSettings = ConfigurationManager.AppSettings;
            string selectedItem = (string)listBoxProfiles.SelectedItem;
            string list = appSettings[selectedItem];
            panelSelectedGroup.Text = selectedItem;

            if (list != "" && list != null)
            {
                folderList = list;
                groupFolders.Clear();
                groupFolders = list.Split(';').ToList();

                for (int i = 0; i < groupFolders.Count(); i++)
                {
                    listFolders.Items.Add(groupFolders[i]);
                }
            }
        }

        private void btnNewList_Click(object sender, EventArgs e)
        {
            string newList = "";
            Class1.InputBox("Папки", "Въведи име на нова група от папки", ref newList);
            listBoxProfiles.Items.Add(newList);

            Class1.AddUpdateAppSettings(newList, "");
        }

        private void btnDeleteList_Click(object sender, EventArgs e)
        {
            string selectedItem = (string)listBoxProfiles.SelectedItem;
            listBoxProfiles.Items.Remove(selectedItem);

            var appSettings = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            appSettings.AppSettings.Settings.Remove(selectedItem);
            appSettings.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            var appSettings = ConfigurationManager.AppSettings;

            if (appSettings.Count != 0)
            {
                foreach (var key in appSettings.AllKeys)
                {
                    listBoxProfiles.Items.Add(key);
                }

                if (listBoxProfiles.Items.Count == 0)
                {
                    listBoxProfiles.Items.Add("-- няма групи --");
                }
                else
                {
                    listBoxProfiles.SetSelected(0, true);
                    btnLoadList.PerformClick();
                }
            }
        }

        private void btnNewFolder_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();

            folder.ShowDialog();
            if (folder.SelectedPath != "")
            {
                var newFolder = folder.SelectedPath;
                listFolders.Items.Add(newFolder);

                if (folderList == "")
                {
                    folderList = newFolder;
                }
                else
                {
                    folderList += ";" + newFolder;
                }

                // запазване на списъка с папки
                Class1.AddUpdateAppSettings(panelSelectedGroup.Text, folderList);

                groupFolders = folderList.Split(';').ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedItem = (string)listFolders.SelectedItem;
            listFolders.Items.Remove(selectedItem);

            var tempList = folderList.Split(';').ToList();
            tempList.Remove(selectedItem);
            folderList = string.Join(";", tempList);

            // запазване на списъка с папки
            Class1.AddUpdateAppSettings(panelSelectedGroup.Text, folderList);

            groupFolders = folderList.Split(';').ToList();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (lblBaclUpFolder.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;

                listProgress.Items.Clear();
                for (int i = 0; i < groupFolders.Count; i++)
                {
                    var currentPath = groupFolders[i];
                    var folderStat = GetAllFilesStat(currentPath, 0, false);

                    listProgress.Items.Add(new ListViewItem(new[] { currentPath, folderStat.FilesCount.ToString(), folderStat.FilesMissing.ToString(), folderStat.FilesChanged.ToString(), "---" }));
                    listProgress.Refresh();
                }

                Cursor.Current = Cursors.Default;
            }
        }

        private DirInfo GetAllFilesStat(string path, int level, bool update)
        {
            var resultSubfolders = new DirInfo();
            var directory = new DirectoryInfo(path);

            var result = new DirInfo();
            string pathSub = directory.Name;
            var parent = directory;

            result.FullPath = path;

            for (int i = 1; i <= level; i++)
            {
                parent = parent.Parent;
                if (parent.Parent != null)
                {
                    pathSub = parent.Name + "\\" + pathSub;
                }
                else
                {
                    pathSub = parent.Name[0] + "\\" + pathSub;
                }
            }

            try
            {
                if (!Directory.Exists(Path.Combine(lblBaclUpFolder.Text, pathSub)))
                {
                    if (update)
                    {
                        Directory.CreateDirectory(Path.Combine(lblBaclUpFolder.Text, pathSub));
                        resultSubfolders.FilesUpdated++;
                    }
                    resultSubfolders.FilesMissing++;
                }

                var folders = directory.GetDirectories().ToList();
                foreach (var item in folders)
                {
                    if (item.Name != "System Volume Information")
                    {
                        var folder = GetAllFilesStat(item.FullName, level + 1, update);
                        resultSubfolders.FilesCount += folder.FilesCount;
                        resultSubfolders.FilesUpdated += folder.FilesUpdated;
                        resultSubfolders.FilesMissing += folder.FilesMissing;
                    }
                }

                var files = directory.GetFiles().ToList();
                foreach (var item in files)
                {
                    var fileDestinationPath = Path.Combine(lblBaclUpFolder.Text, pathSub, item.Name);
                    var fileDestination = new FileInfo(fileDestinationPath);

                    if (!fileDestination.Exists)
                    {
                        if (update)
                        {
                            lblFileCopied.Text = item.FullName;
                            lblFileCopied.Refresh();
                            File.Copy(item.FullName, fileDestinationPath);
                            resultSubfolders.FilesUpdated++;
                        }
                        resultSubfolders.FilesMissing++;
                    }
                    else
                    {
                        if (item.Length != fileDestination.Length || item.LastWriteTimeUtc != fileDestination.LastWriteTimeUtc)
                        {
                            if (update)
                            {
                                lblFileCopied.Text = item.FullName;
                                lblFileCopied.Refresh();
                                File.Copy(item.FullName, fileDestinationPath, true);
                                resultSubfolders.FilesUpdated++;
                            }
                            resultSubfolders.FilesChanged++;
                        }
                    }
                }

            }
            catch
            {
                // some error reading directory
            }

            if (update)
            {
                lblFreeSpace.Text = GetTotalFreeSpace(lblBaclUpFolder.Text.Substring(0, 3)).ToString() + " GB free";
                lblFreeSpace.Refresh();
            }

            result.FilesMissing = resultSubfolders.FilesMissing;
            result.FilesChanged = resultSubfolders.FilesChanged;
            result.FilesUpdated = resultSubfolders.FilesUpdated;
            result.FilesCount = resultSubfolders.FilesCount + directory.GetFiles().Length + 1;
            return result;
        }

        private void btnBackUpFolder_Click(object sender, EventArgs e)
        {
            var folder = new FolderBrowserDialog();

            folder.ShowDialog();
            if (folder.SelectedPath != "")
            {
                lblBaclUpFolder.Text = folder.SelectedPath;
                lblFreeSpace.Text = GetTotalFreeSpace(lblBaclUpFolder.Text.Substring(0, 3)).ToString() + " GB free";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lblBaclUpFolder.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;

                for (int i = 0; i < groupFolders.Count; i++)
                {
                    var currentPath = groupFolders[i];
                    var folderStat = GetAllFilesStat(currentPath, 0, true);

                    listProgress.Items[i].SubItems[4].Text = folderStat.FilesUpdated.ToString();
                    listProgress.Refresh();
                }

                lblFileCopied.Text = "";
                Cursor.Current = Cursors.Default;
            }
        }
        public long GetTotalFreeSpace(string driveName)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady && drive.Name == driveName)
                {
                    return drive.TotalFreeSpace/1024/1024/1024;
                }
            }
            return -1;
        }
    }
}
