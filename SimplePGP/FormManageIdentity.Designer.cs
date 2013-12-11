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
            this.panelAll = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.importFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.buttonExport = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxIdentities.SuspendLayout();
            this.panelAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxIdentities
            // 
            this.groupBoxIdentities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIdentities.Controls.Add(this.listView1);
            this.groupBoxIdentities.Location = new System.Drawing.Point(3, 3);
            this.groupBoxIdentities.Name = "groupBoxIdentities";
            this.groupBoxIdentities.Size = new System.Drawing.Size(583, 399);
            this.groupBoxIdentities.TabIndex = 0;
            this.groupBoxIdentities.TabStop = false;
            this.groupBoxIdentities.Text = "Identities";
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.buttonExport);
            this.panelAll.Controls.Add(this.buttonCreate);
            this.panelAll.Controls.Add(this.buttonRemove);
            this.panelAll.Controls.Add(this.buttonImport);
            this.panelAll.Controls.Add(this.groupBoxIdentities);
            this.panelAll.Location = new System.Drawing.Point(13, 13);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(757, 528);
            this.panelAll.TabIndex = 4;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(593, 108);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(160, 40);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonImport
            // 
            this.buttonImport.Location = new System.Drawing.Point(593, 16);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(160, 40);
            this.buttonImport.TabIndex = 4;
            this.buttonImport.Text = "Import...";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(7, 21);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(570, 372);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(593, 154);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(160, 43);
            this.buttonCreate.TabIndex = 6;
            this.buttonCreate.Text = "Create New...";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // importFileDialog
            // 
            this.importFileDialog.FileName = "importFileDialog";
            this.importFileDialog.Filter = "Identities (*.pgp;*.gpg;*.asc)|*.pgp;*.gpg;*.asc|All Files (*.*)|*.*";
            this.importFileDialog.FilterIndex = 0;
            this.importFileDialog.Title = "Import...";
            // 
            // buttonExport
            // 
            this.buttonExport.Location = new System.Drawing.Point(593, 62);
            this.buttonExport.Name = "buttonExport";
            this.buttonExport.Size = new System.Drawing.Size(160, 40);
            this.buttonExport.TabIndex = 7;
            this.buttonExport.Text = "Export...";
            this.buttonExport.UseVisualStyleBackColor = true;
            this.buttonExport.Click += new System.EventHandler(this.buttonExport_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "pgp";
            this.saveFileDialog.Title = "Export...";
            // 
            // FormManageIdentity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.panelAll);
            this.MinimumSize = new System.Drawing.Size(800, 600);
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
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.OpenFileDialog importFileDialog;
        private System.Windows.Forms.Button buttonExport;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;


    }
}

