namespace ManageUI
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
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxSign = new System.Windows.Forms.CheckBox();
            this.checkBoxEncrypt = new System.Windows.Forms.CheckBox();
            this.groupBoxIdentities = new System.Windows.Forms.GroupBox();
            this.panelAll = new System.Windows.Forms.Panel();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxOptions.SuspendLayout();
            this.panelAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOptions.AutoSize = true;
            this.groupBoxOptions.Controls.Add(this.checkBoxSign);
            this.groupBoxOptions.Controls.Add(this.checkBoxEncrypt);
            this.groupBoxOptions.Location = new System.Drawing.Point(3, 408);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(750, 117);
            this.groupBoxOptions.TabIndex = 3;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // checkBoxSign
            // 
            this.checkBoxSign.AutoSize = true;
            this.checkBoxSign.Location = new System.Drawing.Point(7, 50);
            this.checkBoxSign.Name = "checkBoxSign";
            this.checkBoxSign.Size = new System.Drawing.Size(148, 21);
            this.checkBoxSign.TabIndex = 1;
            this.checkBoxSign.Text = "Sign My Messages";
            this.checkBoxSign.UseVisualStyleBackColor = true;
            // 
            // checkBoxEncrypt
            // 
            this.checkBoxEncrypt.AutoSize = true;
            this.checkBoxEncrypt.Location = new System.Drawing.Point(7, 22);
            this.checkBoxEncrypt.Name = "checkBoxEncrypt";
            this.checkBoxEncrypt.Size = new System.Drawing.Size(189, 21);
            this.checkBoxEncrypt.TabIndex = 0;
            this.checkBoxEncrypt.Text = "Send Privately If Possible";
            this.checkBoxEncrypt.UseVisualStyleBackColor = true;
            // 
            // groupBoxIdentities
            // 
            this.groupBoxIdentities.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxIdentities.Location = new System.Drawing.Point(3, 3);
            this.groupBoxIdentities.Name = "groupBoxIdentities";
            this.groupBoxIdentities.Size = new System.Drawing.Size(583, 399);
            this.groupBoxIdentities.TabIndex = 0;
            this.groupBoxIdentities.TabStop = false;
            this.groupBoxIdentities.Text = "Identities";
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.buttonRemove);
            this.panelAll.Controls.Add(this.buttonAdd);
            this.panelAll.Controls.Add(this.groupBoxIdentities);
            this.panelAll.Controls.Add(this.groupBoxOptions);
            this.panelAll.Location = new System.Drawing.Point(13, 13);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(757, 528);
            this.panelAll.TabIndex = 4;
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(593, 62);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(160, 40);
            this.buttonRemove.TabIndex = 5;
            this.buttonRemove.Text = "Remove Identity";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(593, 16);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(160, 40);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add Identity";
            this.buttonAdd.UseVisualStyleBackColor = true;
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
            this.Text = "Identities";
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.panelAll.ResumeLayout(false);
            this.panelAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.GroupBox groupBoxIdentities;
        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.CheckBox checkBoxSign;
        private System.Windows.Forms.CheckBox checkBoxEncrypt;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonAdd;


    }
}

