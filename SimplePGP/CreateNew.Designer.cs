namespace SimplePGP
{
    partial class FormCreateNew
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
            this.panelAll = new System.Windows.Forms.Panel();
            this.textBoxPassphrase = new System.Windows.Forms.TextBox();
            this.labelKeyPass = new System.Windows.Forms.Label();
            this.comboBoxOutlookAccounts = new System.Windows.Forms.ComboBox();
            this.labelAccount = new System.Windows.Forms.Label();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.textBoxPassphraseSecond = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.textBoxPassphraseSecond);
            this.panelAll.Controls.Add(this.label1);
            this.panelAll.Controls.Add(this.buttonCreate);
            this.panelAll.Controls.Add(this.textBoxPassphrase);
            this.panelAll.Controls.Add(this.labelKeyPass);
            this.panelAll.Controls.Add(this.comboBoxOutlookAccounts);
            this.panelAll.Controls.Add(this.labelAccount);
            this.panelAll.Location = new System.Drawing.Point(12, 12);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(558, 210);
            this.panelAll.TabIndex = 0;
            // 
            // textBoxPassphrase
            // 
            this.textBoxPassphrase.Location = new System.Drawing.Point(148, 53);
            this.textBoxPassphrase.Name = "textBoxPassphrase";
            this.textBoxPassphrase.PasswordChar = '*';
            this.textBoxPassphrase.Size = new System.Drawing.Size(398, 22);
            this.textBoxPassphrase.TabIndex = 1;
            // 
            // labelKeyPass
            // 
            this.labelKeyPass.AutoSize = true;
            this.labelKeyPass.Location = new System.Drawing.Point(8, 56);
            this.labelKeyPass.Name = "labelKeyPass";
            this.labelKeyPass.Size = new System.Drawing.Size(115, 17);
            this.labelKeyPass.TabIndex = 2;
            this.labelKeyPass.Text = "Key Passphrase:";
            // 
            // comboBoxOutlookAccounts
            // 
            this.comboBoxOutlookAccounts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutlookAccounts.FormattingEnabled = true;
            this.comboBoxOutlookAccounts.Location = new System.Drawing.Point(81, 14);
            this.comboBoxOutlookAccounts.Name = "comboBoxOutlookAccounts";
            this.comboBoxOutlookAccounts.Size = new System.Drawing.Size(465, 24);
            this.comboBoxOutlookAccounts.TabIndex = 0;
            // 
            // labelAccount
            // 
            this.labelAccount.AutoSize = true;
            this.labelAccount.Location = new System.Drawing.Point(8, 18);
            this.labelAccount.Name = "labelAccount";
            this.labelAccount.Size = new System.Drawing.Size(67, 17);
            this.labelAccount.TabIndex = 0;
            this.labelAccount.Text = "Account :";
            // 
            // buttonCreate
            // 
            this.buttonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCreate.Location = new System.Drawing.Point(230, 140);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(93, 27);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // textBoxPassphraseSecond
            // 
            this.textBoxPassphraseSecond.Location = new System.Drawing.Point(148, 84);
            this.textBoxPassphraseSecond.Name = "textBoxPassphraseSecond";
            this.textBoxPassphraseSecond.PasswordChar = '*';
            this.textBoxPassphraseSecond.Size = new System.Drawing.Size(398, 22);
            this.textBoxPassphraseSecond.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Passphrase Again:";
            // 
            // FormCreateNew
            // 
            this.AcceptButton = this.buttonCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 234);
            this.Controls.Add(this.panelAll);
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "FormCreateNew";
            this.Text = "Create New Identity";
            this.panelAll.ResumeLayout(false);
            this.panelAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelKeyPass;
        private System.Windows.Forms.ComboBox comboBoxOutlookAccounts;
        private System.Windows.Forms.TextBox textBoxPassphrase;
        private System.Windows.Forms.TextBox textBoxPassphraseSecond;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreate;
    }
}

