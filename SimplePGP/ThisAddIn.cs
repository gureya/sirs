using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using DidiSoft.Pgp;
using Microsoft.Office.Interop.Outlook;
using System.Windows.Forms;
using DidiSoft.Pgp;
using System.IO;

namespace SimplePGP
{
    public partial class ThisAddIn
    {
        public KeyStore keyStore = null;
        public bool EncryptMessages = true;
        public bool SignMessages = false;
        Outlook.Inspectors inspectors;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            inspectors = this.Application.Inspectors;
            inspectors.NewInspector +=
            new Microsoft.Office.Interop.Outlook.InspectorsEvents_NewInspectorEventHandler(Inspectors_NewInspector);
            Application.ItemSend += new ApplicationEvents_11_ItemSendEventHandler(MyItemSendEventHandler);
        
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        void Inspectors_NewInspector(Microsoft.Office.Interop.Outlook.Inspector Inspector)
        {
            Outlook.MailItem mailItem = Inspector.CurrentItem as Outlook.MailItem;

            
           
            if (mailItem != null) 
            {

                if (mailItem.EntryID == null) // composing
                {
                   
                }
                else // not composing
                {
                    PGPLib pgp = new PGPLib();
                    openKeyStore();

                    Outlook.Folder myFolder = Application.ActiveExplorer().CurrentFolder as Outlook.Folder;
                    Outlook.Account currentAccount = GetAccountForFolder(myFolder);
                    System.Diagnostics.Debug.WriteLine(currentAccount.DisplayName);

                    bool verification = false;

                    if(keyStore.ContainsPrivateKey(currentAccount.DisplayName))
                    {
                        bool success = false;
                        while (!success)
                        {
                            FormRetrievePassword passret = new FormRetrievePassword("Enter Passphrase for " + currentAccount.DisplayName);
                            passret.ShowDialog();
                            try
                            {
                                String result;
                                result = pgp.DecryptString(mailItem.Body, keyStore, passret.password);
                                verification = pgp.DecryptAndVerifyString(mailItem.Body, keyStore, passret.password, out result);
                                mailItem.Body = result;
                                System.Diagnostics.Debug.WriteLine("Verification : " + verification);
                                success = true;

                            }
                            catch (System.Exception e)
                            {
                                MessageBox.Show("Wrong Password!", "Password is Required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                }

            }
        }
        Outlook.Account GetAccountForFolder(Outlook.Folder folder)
        {
            // Obtain the store on which the folder resides.
            Outlook.Store store = folder.Store;

            // Enumerate the accounts defined for the session.
            foreach (Outlook.Account account in Application.Session.Accounts)
            {
                // Match the DefaultStore.StoreID of the account
                // with the Store.StoreID for the currect folder.
                if (account.DeliveryStore.StoreID == store.StoreID)
                {
                    // Return the account whose default delivery store
                    // matches the store of the given folder.
                    return account;
                }
            }
            // No account matches, so return null.
            return null;
        }

        void MyItemSendEventHandler(object item,ref bool status)
        {
            // You don't want encryption, you don't get encryption
            if (!Globals.ThisAddIn.EncryptMessages) return;
            PGPLib pgp = new PGPLib();
            
            Outlook.MailItem mailItem = item as Outlook.MailItem;
            Outlook.Inspector curr_inspector = Application.ActiveInspector();

            openKeyStore();
            if (EncryptMessages && !SignMessages)
            {
                System.Diagnostics.Debug.WriteLine("Encryption to do!");
                foreach (Recipient destination in mailItem.Recipients)
                {
                    MailItem perDestination = mailItem.Copy();
                    if (keyStore.ContainsPublicKey(destination.Address))
                    {
                        perDestination.Body = pgp.EncryptString(mailItem.Body, keyStore, destination.Address);
                    }
                    perDestination.Send();
                    status = true;
                    try { curr_inspector.Close(OlInspectorClose.olDiscard); }
                    catch { }

                }
            }
            else if(EncryptMessages && SignMessages)
            {
                System.Diagnostics.Debug.WriteLine("Encryption to do!");
                foreach (Recipient destination in mailItem.Recipients)
                {
                    MailItem perDestination = mailItem.Copy();
                    if (keyStore.ContainsPublicKey(destination.Address))
                    {
                        bool success = false;
                        while (!success)
                        {
                            FormRetrievePassword passret = new FormRetrievePassword("Enter Passphrase for "+mailItem.SendUsingAccount.DisplayName);
                            passret.ShowDialog();
                          
 
                            try
                            {

                                perDestination.Body = pgp.SignAndEncryptString(mailItem.Body, keyStore, mailItem.SendUsingAccount.DisplayName, passret.password, destination.Address);
                                perDestination.Send();
                                status = true;
                                success = true;
                            }
                            catch (System.Exception e)
                            {
                                MessageBox.Show("Wrong Password!", "Password is Required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            }
                        }
                    }
                }
                try { curr_inspector.Close(OlInspectorClose.olDiscard); }
                catch { }
            }
            //}
            //else
            //{
            //    System.Diagnostics.Debug.WriteLine("You don't want encryption, you don't get encryption");
            //    return;
            //}
           



            
        }

        public static void openKeyStore()
        {
            if (Globals.ThisAddIn.keyStore != null) return;
            String fullPath = Path.GetFullPath(@"default.store");
            bool storeExist = File.Exists(fullPath);
            System.Diagnostics.Debug.WriteLine(@fullPath);
            if (!storeExist)
            {
                MessageBox.Show("Hello! To keep your identities safe, you need to set a general password!", "Password is Required", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            bool truePassword = false;
            while (!truePassword)
            {
                FormRetrievePassword passget = new FormRetrievePassword("Please Enter Identity Store Password");
                passget.ShowDialog();
                try
                {
                    Globals.ThisAddIn.keyStore = new KeyStore("default.store", passget.password);
                    truePassword = true;
                }
                catch (System.Exception e)
                {
                    MessageBox.Show("Wrong Password!", "Password is Required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
            if (!storeExist) Globals.ThisAddIn.keyStore.Save();



        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        
        #endregion
    }
}
