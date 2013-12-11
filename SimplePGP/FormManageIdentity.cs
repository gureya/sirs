using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using DidiSoft.Pgp;
using System.Text.RegularExpressions;

namespace SimplePGP
{
    public partial class FormManageIdentity : Form
    {
        public FormManageIdentity(String who)
        {
            InitializeComponent();
            this.Text = this.Text.Replace("%S%", who);
            KeyPairInformation[] keys = Globals.ThisAddIn.keyStore.GetKeys();
            foreach(KeyPairInformation key in keys)
            {
   
                if ( who.Equals("My") && key.HasPrivateKey)
                {
                  
                        String userID = key.UserId;
                        String[] infos = Regex.Replace(userID, "<>", "").Split(' ');

                        System.Diagnostics.Debug.WriteLine(infos[0]);
                        System.Diagnostics.Debug.WriteLine(infos[1]);
                        ListViewItem item = new ListViewItem(infos);
                        this.listViewIdentities.Items.Add(item);
                    
                }
                else if(who.Equals("Others'") && !key.HasPrivateKey)
                {

                        String userID = key.UserId;
                        String[] infos = Regex.Replace(userID, "<>", "").Split(' ');

                        System.Diagnostics.Debug.WriteLine(infos[0]);
                        System.Diagnostics.Debug.WriteLine(infos[1]);
                        ListViewItem item = new ListViewItem(infos);
                        this.listViewIdentities.Items.Add(item);
                    
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("You shouldn't see me: FormManageIdentity");
                }
            }
            
           
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            importFileDialog.ShowDialog();
            // TODO import file you can use importFileDialog.Open()
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            // TODO export to file default extension is pgp use .Open()
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormCreateNew createNew = new FormCreateNew();
            createNew.Show();
        }
    }
}
