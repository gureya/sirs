using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using DidiSoft.Pgp;
using DidiSoft.Pgp.Exceptions;

namespace SimplePGP
{
    public partial class MainRibbon
    {
        private void MainRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            this.checkBoxSign.Checked = Globals.ThisAddIn.SignMessages;
            this.checkBoxEncrypt.Checked = Globals.ThisAddIn.EncryptMessages;
        }

        private void buttonConfigureMe_Click(object sender, RibbonControlEventArgs e)
        {
            ThisAddIn.openKeyStore();
          
            new FormManageIdentity("My").Show();
            
        }

        private void buttonConfigureOthers_Click(object sender, RibbonControlEventArgs e)
        {
            ThisAddIn.openKeyStore();
            new FormManageIdentity("Others'").Show();
        }

      
        

        private void checkBoxSign_Click(object sender, RibbonControlEventArgs e)
        {
            
            Globals.ThisAddIn.SignMessages = checkBoxSign.Checked;
            System.Diagnostics.Debug.WriteLine("Sign Checkbox changed to {0}", checkBoxSign.Checked);
        }

        private void checkBoxEncrypt_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.EncryptMessages = checkBoxEncrypt.Checked;
            if(!Globals.ThisAddIn.EncryptMessages)
            {
                checkBoxSign.Checked = false;
                Globals.ThisAddIn.SignMessages = false;
                this.checkBoxSign.Enabled = false;
            }
            else
            {
                this.checkBoxSign.Enabled = true;
            }
            System.Diagnostics.Debug.WriteLine("Encrypt Checkbox changed to {0}", checkBoxEncrypt.Checked);
        }
        


    }
}
