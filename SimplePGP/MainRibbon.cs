using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace SimplePGP
{
    public partial class MainRibbon
    {
        private void MainRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            this.checkBoxSign.Checked = Config.SignMessages;
            this.checkBoxEncrypt.Checked = Config.EncryptMessages;
        }

        private void buttonConfigureMe_Click(object sender, RibbonControlEventArgs e)
        {
            new FormManageIdentity("My").Show();
        }

        private void buttonConfigureOthers_Click(object sender, RibbonControlEventArgs e)
        {
            new FormManageIdentity("Others'").Show();
        }

        private void checkBox1_(object sender, RibbonControlEventArgs e)
        {

        }

        private void checkBoxSign_Click(object sender, RibbonControlEventArgs e)
        {
            
            Config.SignMessages = checkBoxSign.Checked;
            System.Diagnostics.Debug.WriteLine("Sign Checkbox changed to {0}", checkBoxSign.Checked);
        }

        private void checkBoxEncrypt_Click(object sender, RibbonControlEventArgs e)
        {
            Config.EncryptMessages = checkBoxEncrypt.Checked;
            System.Diagnostics.Debug.WriteLine("Encrypt Checkbox changed to {0}", checkBoxEncrypt.Checked);
        }
    }
}
