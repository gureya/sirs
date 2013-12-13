namespace SimplePGP
{
    partial class FormManageIdentity
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
            this.groupBoxIdentities = new System.Windows.Forms.GroupBox();
            this.listViewIdentities = new System.Windows.Forms.ListView();
            this.EmailColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelAll = new System.Windows.Forms.Panel();
            this.buttonExport = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.buttonExportBackup = new System.Windows.Forms.Button();
            this.groupBoxIdentities.SuspendLayout();
            this.panelAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIdentities
            // 
            this.groupBoxIdentities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIdentities.Controls.Add(this.listViewIdentities);
            this.groupBoxIdentities.Location = new System.Drawing.Point(3, 3);
            this.groupBoxIdentities.Name = "groupBoxIdentities";
            this.groupBoxIdentities.Size = new System.Drawing.Size(583, 393);
            this.groupBoxIdentities.TabIndex = 0;
            this.groupBoxIdentities.TabStop = false;
            this.groupBoxIdentities.Text = "Identities";
            // 
            // listViewIdentities
            // 
            this.listViewIdentities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewIdentities.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.EmailColumn});
            this.listViewIdentities.FullRowSelect = true;
            this.listViewIdentities.GridLines = true;
            this.listViewIdentities.Location = new System.Drawing.Point(7, 21);
            this.listViewIdentities.MultiSelect = false;
            this.listViewIdentities.Name = "listViewIdentities";
            this.listViewIdentities.Size = new System.Drawing.Size(570, 372);
            this.listViewIdentities.TabIndex = 10;
            this.listViewIdentities.TabStop = false;
            this.listViewIdentities.UseCompatibleStateImageBehavior = false;
            this.listViewIdentities.View = System.Windows.Forms.View.Details;
            // 
            // EmailColumn
            // 
            this.EmailColumn.Text = "Email";
            this.EmailColumn.Width = 560;
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.buttonExportBackup);
            this.panelAll.Controls.Add(this.buttonExport);
            this.panelAll.Controls.Add(this.buttonCreate);
            this.panelAll.Controls.Add(this.buttonRemove);
            this.panelAll.Controls.Add(this.buttonImport);
            this.panelAll.Controls.Add(this.groupBoxIdentities);
            this.panelAll.Location = new System.Drawing.Point(13, 13);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(757, 405);
            this.panelAll.TabIndex = 100;
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(593, 62);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(160, 40);
            this.buttonExport.TabIndex = 1;
            this.buttonExport.Text = "Export...";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(593, 154);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(160, 43);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create New...";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(593, 108);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(160, 40);
            this.buttonRemove.TabIndex = 2;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(593, 16);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(160, 40);
            this.buttonImport.TabIndex = 0;
            this.buttonImport.Text = "Import...";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // importFileDialog
            // 
            this.importFileDialog.DefaultExt = "pgp";
            this.importFileDialog.FileName = "myKey";
            this.importFileDialog.Filter = "Identities (*.pgp;*.gpg;*.asc)|*.pgp;*.gpg;*.asc|All Files (*.*)|*.*";
            this.importFileDialog.FilterIndex = 0;
            this.importFileDialog.Title = "Import...";
            this.importFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.importFileDialog_FileOk);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "asc";
            this.saveFileDialog.FileName = "myKey";
            this.saveFileDialog.Filter = "Identities (*.pgp;*.gpg;*.asc)|*.pgp;*.gpg;*.asc|All Files (*.*)|*.*";
            this.saveFileDialog.Title = "Export...";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // buttonExportBackup
            // 
            this.buttonExportBackup.Location = new System.Drawing.Point(593, 356);
            this.buttonExportBackup.Name = "buttonExportBackup";
            this.buttonExportBackup.Size = new System.Drawing.Size(160, 40);
            this.buttonExportBackup.TabIndex = 4;
            this.buttonExportBackup.Text = "Export for backup...";
            this.buttonExportBackup.UseVisualStyleBackColor = true;
            this.buttonExportBackup.Click += new System.EventHandler(this.buttonExportBackup_Click);
            // 
            // FormManageIdentity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(782, 428);
            this.Controls.Add(this.panelAll);
            this.MinimumSize = new System.Drawing.Size(800, 475);
            this.Name = "FormManageIdentity";
            this.Text = "%S% Identities";
            this.groupBoxIdentities.ResumeLayout(false);
            this.panelAll.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxIdentities;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.ListView listViewIdentities;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.OpenFileDialog importFileDialog;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ColumnHeader EmailColumn;
        private System.Windows.Forms.Button buttonExportBackup;


    }
}

