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
        public static String MY = "My";
        public static String OTHERS = "Others'";
        public String who;
        private bool backuping = false;
        public FormManageIdentity(String who)
        {
            this.who = who;
            InitializeComponent();
            this.Text = this.Text.Replace("%S%", who);
            if (String.Equals(who,OTHERS))
            {
                this.buttonCreate.Hide();
                this.buttonExportBackup.Hide();
            }
            ReBuildListViewItems();
            listViewIdentities.Refresh();
        }

        private void buttonImport_Click(object sender, EventArgs e)
        {
            importFileDialog.ShowDialog();
        }

        private void buttonExport_Click(object sender, EventArgs e)
        {
            if (listViewIdentities.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select an Item First", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            saveFileDialog.ShowDialog(this);


            // TODO export to file default extension is pgp use .Open()
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            FormCreateNew createNew = new FormCreateNew();
            createNew.FormClosed += new FormClosedEventHandler(ChildFormClosed);
            createNew.Show(this);



        }
        void ChildFormClosed(object sender, FormClosedEventArgs e)
        {
            // do something useful
            ReBuildListViewItems();
            listViewIdentities.Refresh();
      
        }
        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (listViewIdentities.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select an Item First", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            foreach (ListViewItem item in this.listViewIdentities.SelectedItems)
            {
                if (String.Equals(who, MY))
                {
                    FormRetrievePassword passret = new FormRetrievePassword("Please Enter Identity Passphrase to Continue");
                    passret.ShowDialog(this);

                    if (Globals.ThisAddIn.keyStore.GetKey(item.Text).CheckPassword(passret.password))
                    {
                        Globals.ThisAddIn.keyStore.DeleteKeyPair(item.Text);
                        System.Diagnostics.Debug.WriteLine("Deleting : " + item.Text);
                        this.listViewIdentities.Items.Remove(item);
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password!", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
                else //others
                {
                    FormRetrievePassword passret = new FormRetrievePassword("Please Enter Identity Store Password");
                    passret.ShowDialog(this);
                    if (String.Equals(Globals.ThisAddIn.keyStore.Password,passret.password))
                    {
                        Globals.ThisAddIn.keyStore.DeleteKeyPair(item.Text);
                        System.Diagnostics.Debug.WriteLine("Deleting : " + item.Text);
                        this.listViewIdentities.Items.Remove(item);
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password!", "Cannot Delete", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                }
            }
            //listViewIdentities.Items.Clear();
            this.listViewIdentities.Refresh();
        }
        private void ReBuildListViewItems()
        {
            KeyPairInformation[] keys = Globals.ThisAddIn.keyStore.GetKeys();
            this.listViewIdentities.Items.Clear();
            foreach (KeyPairInformation key in keys)
            {

                if (String.Equals(who, MY) && key.HasPrivateKey)
                {

                    String userID = key.UserId;
                    //String[] infos = Regex.Replace(userID, "<>", "").Split(' ');

                    System.Diagnostics.Debug.WriteLine(userID);
                    //System.Diagnostics.Debug.WriteLine(infos[1]);
                    ListViewItem item = new ListViewItem(userID);
                
                    this.listViewIdentities.Items.Add(item);

                }
                else if (String.Equals(who, OTHERS) && !key.HasPrivateKey)
                {

                    String userID = key.UserId;
                    //String[] infos = Regex.Replace(userID, "<>", "").Split(' ');

                    System.Diagnostics.Debug.WriteLine(userID);
                    //System.Diagnostics.Debug.WriteLine(infos[1]);
                    ListViewItem item = new ListViewItem(userID);
                    this.listViewIdentities.Items.Add(item);

                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("You shouldn't see me: FormManageIdentity");
                }
                System.Diagnostics.Debug.WriteLine("Items to be seen:");
                foreach (var item in this.listViewIdentities.Items)
                    System.Diagnostics.Debug.WriteLine(item.ToString());
            }
        }

        private void buttonExportBackup_Click(object sender, EventArgs e)
        {
            if(listViewIdentities.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select an Item First", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            FormRetrievePassword passret = new FormRetrievePassword("Please Enter Identity Passphrase to Continue");
            passret.ShowDialog(this);
            if (Globals.ThisAddIn.keyStore.GetKey(listViewIdentities.SelectedItems[0].Text).CheckPassword(passret.password))
            {
                backuping = true;
                saveFileDialog.ShowDialog(this);
                backuping = false;

            }
            else
            {
                MessageBox.Show("Wrong Password!", "Cannot Export for backup!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Exporting : " + saveFileDialog.FileName);
            //String exportlocation = @"public_key_exported.asc";
            // should the exported files be ASCII or binary
            bool asciiArmored = true;
            if(!backuping)
            {
                Globals.ThisAddIn.keyStore.ExportPublicKey(@saveFileDialog.FileName, listViewIdentities.SelectedItems[0].Text, asciiArmored);
   
            }
            else
            {
                Globals.ThisAddIn.keyStore.ExportKeyRing(@saveFileDialog.FileName, listViewIdentities.SelectedItems[0].Text, asciiArmored);
            }
                
        }

        private void importFileDialog_FileOk(object sender, CancelEventArgs e)
        {

            if(IsAlreadyExist(importFileDialog.FileName))
            {
                DialogResult wantToReplace = MessageBox.Show("There is already a key in the keystore, Do you want to replace this with the existing one?", "Key is Already Present", MessageBoxButtons.YesNo);
                if (wantToReplace == DialogResult.No) return;
            }
            if (String.Equals(who, MY))
            {

                System.Diagnostics.Debug.WriteLine("Importing keyring...");
               
                Globals.ThisAddIn.keyStore.ImportKeyRing(@importFileDialog.FileName);
            }
            else if (String.Equals(who, OTHERS))
            {
                System.Diagnostics.Debug.WriteLine("Importing public key...");
                Globals.ThisAddIn.keyStore.ImportPublicKey(@importFileDialog.FileName);
            }
            else
            {
                System.Diagnostics.Debug.WriteLine("You shouldn't see me: Importing...");
            }
            ReBuildListViewItems();
            this.listViewIdentities.Refresh();
            // TODO import file you can use importFileDialog.Open()
        }

        private Boolean IsAlreadyExist(String filename)
        {
            DidiSoft.Pgp.KeyStore tempstore = new KeyStore();
            tempstore.ImportKeyRing(@filename);
            return Globals.ThisAddIn.keyStore.ContainsKey(tempstore.GetKeys()[0].UserId);
        }

    }
}
