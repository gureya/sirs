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
            this.buttonCreate = new System.Windows.Forms.Button();
            this.maskedTextBoxKeyPass = new System.Windows.Forms.MaskedTextBox();
            this.labelKeyPass = new System.Windows.Forms.Label();
            this.comboBoxOutlookAccounts = new System.Windows.Forms.ComboBox();
            this.labelAccount = new System.Windows.Forms.Label();
            this.panelAll.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAll
            // 
            this.panelAll.Controls.Add(this.buttonCreate);
            this.panelAll.Controls.Add(this.maskedTextBoxKeyPass);
            this.panelAll.Controls.Add(this.labelKeyPass);
            this.panelAll.Controls.Add(this.comboBoxOutlookAccounts);
            this.panelAll.Controls.Add(this.labelAccount);
            this.panelAll.Location = new System.Drawing.Point(12, 12);
            this.panelAll.Name = "panelAll";
            this.panelAll.Size = new System.Drawing.Size(558, 329);
            this.panelAll.TabIndex = 0;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(215, 111);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(93, 23);
            this.buttonCreate.TabIndex = 4;
            this.buttonCreate.Text = "Create";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // maskedTextBoxKeyPass
            // 
            this.maskedTextBoxKeyPass.Location = new System.Drawing.Point(81, 53);
            this.maskedTextBoxKeyPass.Name = "maskedTextBoxKeyPass";
            this.maskedTextBoxKeyPass.Size = new System.Drawing.Size(465, 22);
            this.maskedTextBoxKeyPass.TabIndex = 3;
            // 
            // labelKeyPass
            // 
            this.labelKeyPass.AutoSize = true;
            this.labelKeyPass.Location = new System.Drawing.Point(8, 56);
            this.labelKeyPass.Name = "labelKeyPass";
            this.labelKeyPass.Size = new System.Drawing.Size(71, 17);
            this.labelKeyPass.TabIndex = 2;
            this.labelKeyPass.Text = "Key Pass:";
            // 
            // comboBoxOutlookAccounts
            // 
            this.comboBoxOutlookAccounts.FormattingEnabled = true;
            this.comboBoxOutlookAccounts.Location = new System.Drawing.Point(81, 14);
            this.comboBoxOutlookAccounts.Name = "comboBoxOutlookAccounts";
            this.comboBoxOutlookAccounts.Size = new System.Drawing.Size(465, 24);
            this.comboBoxOutlookAccounts.TabIndex = 1;
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
            // FormCreateNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.panelAll);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "FormCreateNew";
            this.Text = "Create New Identity";
            this.panelAll.ResumeLayout(false);
            this.panelAll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAll;
        private System.Windows.Forms.ComboBox comboBoxOutlookAccounts;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKeyPass;
        private System.Windows.Forms.Label labelKeyPass;
        private System.Windows.Forms.Button buttonCreate;
    }
}

