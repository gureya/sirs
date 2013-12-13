namespace SimplePGP
{
    partial class MainRibbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MainRibbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainTab = this.Factory.CreateRibbonTab();
            this.groupMe = this.Factory.CreateRibbonGroup();
            this.buttonConfigureMe = this.Factory.CreateRibbonButton();
            this.groupOthers = this.Factory.CreateRibbonGroup();
            this.buttonConfigureOthers = this.Factory.CreateRibbonButton();
            this.groupOptions = this.Factory.CreateRibbonGroup();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.checkBoxEncrypt = this.Factory.CreateRibbonCheckBox();
            this.checkBoxSign = this.Factory.CreateRibbonCheckBox();
            this.mainTab.SuspendLayout();
            this.groupMe.SuspendLayout();
            this.groupOthers.SuspendLayout();
            this.groupOptions.SuspendLayout();
            // 
            // mainTab
            // 
            this.mainTab.Groups.Add(this.groupMe);
            this.mainTab.Groups.Add(this.groupOthers);
            this.mainTab.Groups.Add(this.groupOptions);
            this.mainTab.Label = "Simple PGP";
            this.mainTab.Name = "mainTab";
            // 
            // groupMe
            // 
            this.groupMe.Items.Add(this.buttonConfigureMe);
            this.groupMe.Label = "Me";
            this.groupMe.Name = "groupMe";
            // 
            // buttonConfigureMe
            // 
            this.buttonConfigureMe.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonConfigureMe.Description = "Configure your identities...";
            this.buttonConfigureMe.Label = "My Identities";
            this.buttonConfigureMe.Name = "buttonConfigureMe";
            this.buttonConfigureMe.OfficeImageId = "LastModifiedBy";
            this.buttonConfigureMe.ShowImage = true;
            this.buttonConfigureMe.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonConfigureMe_Click);
            // 
            // groupOthers
            // 
            this.groupOthers.Items.Add(this.buttonConfigureOthers);
            this.groupOthers.Label = "Others";
            this.groupOthers.Name = "groupOthers";
            // 
            // buttonConfigureOthers
            // 
            this.buttonConfigureOthers.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.buttonConfigureOthers.Description = "Manage others\' identities...";
            this.buttonConfigureOthers.Label = "Others\' Identities";
            this.buttonConfigureOthers.Name = "buttonConfigureOthers";
            this.buttonConfigureOthers.OfficeImageId = "SocialAccountSettings";
            this.buttonConfigureOthers.ShowImage = true;
            this.buttonConfigureOthers.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.buttonConfigureOthers_Click);
            // 
            // groupOptions
            // 
            this.groupOptions.Items.Add(this.label1);
            this.groupOptions.Items.Add(this.checkBoxEncrypt);
            this.groupOptions.Items.Add(this.checkBoxSign);
            this.groupOptions.Label = "Options";
            this.groupOptions.Name = "groupOptions";
            // 
            // label1
            // 
            this.label1.Label = "If Possible...";
            this.label1.Name = "label1";
            // 
            // checkBoxEncrypt
            // 
            this.checkBoxEncrypt.Label = "Send Privately";
            this.checkBoxEncrypt.Name = "checkBoxEncrypt";
            this.checkBoxEncrypt.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.checkBoxEncrypt_Click);
            // 
            // checkBoxSign
            // 
            this.checkBoxSign.Label = "Sign My Messages";
            this.checkBoxSign.Name = "checkBoxSign";
            this.checkBoxSign.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.checkBoxSign_Click);
            // 
            // MainRibbon
            // 
            this.Name = "MainRibbon";
            this.RibbonType = "Microsoft.Outlook.Explorer";
            this.Tabs.Add(this.mainTab);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.MainRibbon_Load);
            this.mainTab.ResumeLayout(false);
            this.mainTab.PerformLayout();
            this.groupMe.ResumeLayout(false);
            this.groupMe.PerformLayout();
            this.groupOthers.ResumeLayout(false);
            this.groupOthers.PerformLayout();
            this.groupOptions.ResumeLayout(false);
            this.groupOptions.PerformLayout();

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab mainTab;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupMe;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonConfigureMe;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupOthers;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton buttonConfigureOthers;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup groupOptions;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBoxEncrypt;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBoxSign;
    }

    partial class ThisRibbonCollection
    {
        internal MainRibbon MainRibbon
        {
            get { return this.GetRibbon<MainRibbon>(); }
        }
    }
}
