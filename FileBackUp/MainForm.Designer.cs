namespace FileBackUp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLoadList = new System.Windows.Forms.Button();
            this.btnDeleteList = new System.Windows.Forms.Button();
            this.btnNewList = new System.Windows.Forms.Button();
            this.listBoxProfiles = new System.Windows.Forms.ListBox();
            this.listProgress = new System.Windows.Forms.ListView();
            this.Source = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Files = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Missing = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Changed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Updated = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnNewFolder = new System.Windows.Forms.Button();
            this.panelSelectedGroup = new System.Windows.Forms.Label();
            this.listFolders = new System.Windows.Forms.ListBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBackUpFolder = new System.Windows.Forms.Button();
            this.lblBaclUpFolder = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFileCopied = new System.Windows.Forms.Label();
            this.lblFreeSpace = new System.Windows.Forms.Label();
            this.lblTotalChanges = new System.Windows.Forms.Label();
            this.lblTotalUpdated = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadList
            // 
            this.btnLoadList.Location = new System.Drawing.Point(589, 31);
            this.btnLoadList.Name = "btnLoadList";
            this.btnLoadList.Size = new System.Drawing.Size(94, 24);
            this.btnLoadList.TabIndex = 17;
            this.btnLoadList.Text = "Зареди списък";
            this.btnLoadList.UseVisualStyleBackColor = true;
            this.btnLoadList.Click += new System.EventHandler(this.btnLoadList_Click);
            // 
            // btnDeleteList
            // 
            this.btnDeleteList.Location = new System.Drawing.Point(589, 89);
            this.btnDeleteList.Name = "btnDeleteList";
            this.btnDeleteList.Size = new System.Drawing.Size(94, 24);
            this.btnDeleteList.TabIndex = 16;
            this.btnDeleteList.Text = "Изтрий списък";
            this.btnDeleteList.UseVisualStyleBackColor = true;
            this.btnDeleteList.Click += new System.EventHandler(this.btnDeleteList_Click);
            // 
            // btnNewList
            // 
            this.btnNewList.Location = new System.Drawing.Point(589, 60);
            this.btnNewList.Name = "btnNewList";
            this.btnNewList.Size = new System.Drawing.Size(94, 24);
            this.btnNewList.TabIndex = 15;
            this.btnNewList.Text = "Нов списък";
            this.btnNewList.UseVisualStyleBackColor = true;
            this.btnNewList.Click += new System.EventHandler(this.btnNewList_Click);
            // 
            // listBoxProfiles
            // 
            this.listBoxProfiles.FormattingEnabled = true;
            this.listBoxProfiles.Location = new System.Drawing.Point(445, 31);
            this.listBoxProfiles.Name = "listBoxProfiles";
            this.listBoxProfiles.Size = new System.Drawing.Size(138, 82);
            this.listBoxProfiles.TabIndex = 14;
            // 
            // listProgress
            // 
            this.listProgress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Source,
            this.Files,
            this.Missing,
            this.Changed,
            this.Updated});
            this.listProgress.GridLines = true;
            this.listProgress.Location = new System.Drawing.Point(13, 235);
            this.listProgress.Name = "listProgress";
            this.listProgress.Size = new System.Drawing.Size(670, 153);
            this.listProgress.TabIndex = 18;
            this.listProgress.UseCompatibleStateImageBehavior = false;
            this.listProgress.View = System.Windows.Forms.View.Details;
            // 
            // Source
            // 
            this.Source.Text = "Source";
            this.Source.Width = 260;
            // 
            // Files
            // 
            this.Files.Text = "Files";
            this.Files.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Files.Width = 91;
            // 
            // Missing
            // 
            this.Missing.Text = "Missing";
            this.Missing.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Missing.Width = 85;
            // 
            // Changed
            // 
            this.Changed.Text = "Changed";
            this.Changed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Changed.Width = 80;
            // 
            // Updated
            // 
            this.Updated.Text = "Updated";
            this.Updated.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Updated.Width = 79;
            // 
            // btnNewFolder
            // 
            this.btnNewFolder.Location = new System.Drawing.Point(13, 12);
            this.btnNewFolder.Name = "btnNewFolder";
            this.btnNewFolder.Size = new System.Drawing.Size(96, 23);
            this.btnNewFolder.TabIndex = 19;
            this.btnNewFolder.Text = "Нова папка";
            this.btnNewFolder.UseVisualStyleBackColor = true;
            this.btnNewFolder.Click += new System.EventHandler(this.btnNewFolder_Click);
            // 
            // panelSelectedGroup
            // 
            this.panelSelectedGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSelectedGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelSelectedGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.panelSelectedGroup.Location = new System.Drawing.Point(442, 8);
            this.panelSelectedGroup.Name = "panelSelectedGroup";
            this.panelSelectedGroup.Size = new System.Drawing.Size(241, 20);
            this.panelSelectedGroup.TabIndex = 20;
            // 
            // listFolders
            // 
            this.listFolders.FormattingEnabled = true;
            this.listFolders.Location = new System.Drawing.Point(13, 42);
            this.listFolders.Name = "listFolders";
            this.listFolders.Size = new System.Drawing.Size(314, 95);
            this.listFolders.TabIndex = 21;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(112, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(68, 23);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Изтрий";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(13, 171);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(96, 23);
            this.btnStart.TabIndex = 23;
            this.btnStart.Text = "Анализ";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBackUpFolder
            // 
            this.btnBackUpFolder.Location = new System.Drawing.Point(13, 143);
            this.btnBackUpFolder.Name = "btnBackUpFolder";
            this.btnBackUpFolder.Size = new System.Drawing.Size(96, 23);
            this.btnBackUpFolder.TabIndex = 24;
            this.btnBackUpFolder.Text = "Запазване в:";
            this.btnBackUpFolder.UseVisualStyleBackColor = true;
            this.btnBackUpFolder.Click += new System.EventHandler(this.btnBackUpFolder_Click);
            // 
            // lblBaclUpFolder
            // 
            this.lblBaclUpFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblBaclUpFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBaclUpFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.lblBaclUpFolder.Location = new System.Drawing.Point(115, 146);
            this.lblBaclUpFolder.Name = "lblBaclUpFolder";
            this.lblBaclUpFolder.Size = new System.Drawing.Size(212, 20);
            this.lblBaclUpFolder.TabIndex = 25;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(13, 200);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(96, 23);
            this.btnUpdate.TabIndex = 26;
            this.btnUpdate.Text = "Копиране";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblFileCopied);
            this.panel1.Location = new System.Drawing.Point(13, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 36);
            this.panel1.TabIndex = 27;
            // 
            // lblFileCopied
            // 
            this.lblFileCopied.Location = new System.Drawing.Point(12, 9);
            this.lblFileCopied.Name = "lblFileCopied";
            this.lblFileCopied.Size = new System.Drawing.Size(643, 13);
            this.lblFileCopied.TabIndex = 0;
            // 
            // lblFreeSpace
            // 
            this.lblFreeSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblFreeSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblFreeSpace.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.lblFreeSpace.Location = new System.Drawing.Point(346, 146);
            this.lblFreeSpace.Name = "lblFreeSpace";
            this.lblFreeSpace.Size = new System.Drawing.Size(187, 20);
            this.lblFreeSpace.TabIndex = 28;
            // 
            // lblTotalChanges
            // 
            this.lblTotalChanges.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTotalChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.lblTotalChanges.Location = new System.Drawing.Point(346, 171);
            this.lblTotalChanges.Name = "lblTotalChanges";
            this.lblTotalChanges.Size = new System.Drawing.Size(187, 20);
            this.lblTotalChanges.TabIndex = 29;
            // 
            // lblTotalUpdated
            // 
            this.lblTotalUpdated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lblTotalUpdated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalUpdated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(100)))));
            this.lblTotalUpdated.Location = new System.Drawing.Point(346, 200);
            this.lblTotalUpdated.Name = "lblTotalUpdated";
            this.lblTotalUpdated.Size = new System.Drawing.Size(187, 20);
            this.lblTotalUpdated.TabIndex = 30;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 439);
            this.Controls.Add(this.lblTotalUpdated);
            this.Controls.Add(this.lblTotalChanges);
            this.Controls.Add(this.lblFreeSpace);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblBaclUpFolder);
            this.Controls.Add(this.btnBackUpFolder);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.listFolders);
            this.Controls.Add(this.panelSelectedGroup);
            this.Controls.Add(this.btnNewFolder);
            this.Controls.Add(this.listProgress);
            this.Controls.Add(this.btnLoadList);
            this.Controls.Add(this.btnDeleteList);
            this.Controls.Add(this.btnNewList);
            this.Controls.Add(this.listBoxProfiles);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadList;
        private System.Windows.Forms.Button btnDeleteList;
        private System.Windows.Forms.Button btnNewList;
        private System.Windows.Forms.ListBox listBoxProfiles;
        private System.Windows.Forms.ListView listProgress;
        internal System.Windows.Forms.Button btnNewFolder;
        private System.Windows.Forms.Label panelSelectedGroup;
        private System.Windows.Forms.ColumnHeader Source;
        private System.Windows.Forms.ListBox listFolders;
        internal System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ColumnHeader Files;
        private System.Windows.Forms.ColumnHeader Missing;
        internal System.Windows.Forms.Button btnStart;
        internal System.Windows.Forms.Button btnBackUpFolder;
        private System.Windows.Forms.Label lblBaclUpFolder;
        private System.Windows.Forms.ColumnHeader Updated;
        internal System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblFileCopied;
        private System.Windows.Forms.ColumnHeader Changed;
        private System.Windows.Forms.Label lblFreeSpace;
        private System.Windows.Forms.Label lblTotalChanges;
        private System.Windows.Forms.Label lblTotalUpdated;
    }
}

