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

namespace SimplePGP
{
    public partial class FormCreateNew : Form
    {
        public FormCreateNew()
        {
            InitializeComponent();
            Outlook.Accounts accounts = Globals.ThisAddIn.Application.Session.Accounts;
            List<String> emails = new List<String>();
            emails.Add("Please Select...");
            foreach (Outlook.Account current in accounts)
            {
                System.Diagnostics.Debug.WriteLine(current.DisplayName);
                if(! Globals.ThisAddIn.keyStore.ContainsPrivateKey(current.DisplayName))
                    emails.Add(current.DisplayName);
            }
            if (emails.Count() == 0)
            {
                MessageBox.Show("There is no user accounts to bind identities, please first create one!", "No User Accounts", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                this.Close();
            }
            else
            {
                comboBoxOutlookAccounts.DataSource = emails;
            }

        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Debug.WriteLine("Selected this:");
            System.Diagnostics.Debug.WriteLine(comboBoxOutlookAccounts.SelectedItem.ToString());
            if (String.Equals(comboBoxOutlookAccounts.SelectedItem.ToString(), "Please Select..."))
            {
                MessageBox.Show("Please Select an Account", "Account is not Selected", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if(!String.Equals(textBoxPassphrase.Text,textBoxPassphraseSecond.Text))
            {
                MessageBox.Show("Passphrases don't match","Passphrase Mismatch",MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if(textBoxPassphraseSecond.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Passphrase", "Passphrase is Required", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            String userId = comboBoxOutlookAccounts.SelectedItem.ToString();
            // this is the password of the private key in the key pair
            String privateKeyPassword = textBoxPassphrase.Text;
            // Preferred symmetric key algorithms for this key
            CypherAlgorithm[] cypher = { CypherAlgorithm.CAST5,
                                  CypherAlgorithm.AES_128 };

            // Preferred digital signature (hash) algorithms for this key
            HashAlgorithm[] hashing = { HashAlgorithm.SHA1,
                               HashAlgorithm.MD5,
                   HashAlgorithm.SHA256 };

            // Preferred compression algorithms for this key
            CompressionAlgorithm[] compression =
                 { CompressionAlgorithm.ZIP,
              CompressionAlgorithm.UNCOMPRESSED};

            int keySizeInBits = 2048;
            // asymmetric encryption algorithm  
            KeyAlgorithm algorithm = KeyAlgorithm.RSA;
            
            KeyPairInformation info =Globals.ThisAddIn.keyStore.GenerateKeyPair(keySizeInBits,
                               userId,
                               algorithm,
                               privateKeyPassword,
                               compression,
                               hashing,
                               cypher);

            MessageBox.Show("New Identity is generated, now you can use it!", "Operation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }
    }
}
