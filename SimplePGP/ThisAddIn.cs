using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using DidiSoft.Pgp;

namespace SimplePGP
{
    public partial class ThisAddIn
    {
        public KeyStore keyStore;
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            keyStore = new DidiSoft.Pgp.KeyStore(@"default.store","test");
            //String userId = "Seckin <test2013@test.com>";
            //// this is the password of the private key in the key pair
            //String privateKeyPassword = "test";
            //// Preferred symmetric key algorithms for this key
            //CypherAlgorithm[] cypher = { CypherAlgorithm.CAST5,
            //                      CypherAlgorithm.AES_128 };

            //// Preferred digital signature (hash) algorithms for this key
            //HashAlgorithm[] hashing = { HashAlgorithm.SHA1,
            //                   HashAlgorithm.MD5,
            //       HashAlgorithm.SHA256 };

            //// Preferred compression algorithms for this key
            //CompressionAlgorithm[] compression =
            //     { CompressionAlgorithm.ZIP,
            //  CompressionAlgorithm.UNCOMPRESSED};

            //int keySizeInBits = 2048;
            //// asymmetric encryption algorithm  
            //KeyAlgorithm algorithm = KeyAlgorithm.RSA;

            //OpenPGP.GenerateKeyPair(keyStore, userId, privateKeyPassword, cypher, hashing, compression,
            //    keySizeInBits, algorithm);
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
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
