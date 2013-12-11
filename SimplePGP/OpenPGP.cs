using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DidiSoft.Pgp;

namespace SimplePGP
{
    class OpenPGP
    {
        public static void GenerateKeyPair(KeyStore ks, string userId, 
            string privateKeyPassword, 
            CypherAlgorithm[] cypher, HashAlgorithm[] hashing, 
            CompressionAlgorithm[] compression,
                int keySizeInBits, KeyAlgorithm algorithm)
        {

            bool containsKey = ks.ContainsKey(userId);

            if (!containsKey)
            {
                ks.GenerateKeyPair(keySizeInBits,
                               userId,
                               algorithm,
                               privateKeyPassword,
                               compression,
                               hashing,
                               cypher);
                Console.WriteLine("Your Key has been saved");
            }
            else
                Console.WriteLine(userId + " Already exists!");
    }

        public static void ListKeys(KeyStore ks)
        {
            //*** DISPLAY THE KEYS FROM THE KEYSTORE

            KeyPairInformation[] keys = ks.GetKeys();

            StringBuilder sb = new StringBuilder();
            sb.Append("Type".PadRight(10));
            sb.Append("Key Id".PadRight(30));
            sb.Append("Created".PadRight(20));
            sb.Append("User Id");
            Console.WriteLine(sb.ToString());

            foreach (KeyPairInformation key in keys)
            {
                sb.Remove(0, sb.Length);

                String keyType = null;
                if (key.HasPrivateKey)
                {
                    keyType = "pub/sec";
                }
                else
                {
                    keyType = "pub";
                }
                sb.Append(keyType.PadRight(10));

                sb.Append(Convert.ToString(key.KeyId).PadRight(30));
                sb.Append(key.CreationTime.ToShortDateString().PadRight(20));

                foreach (String id in key.UserIds)
                {
                    sb.Append(id);
                }

                Console.WriteLine(sb.ToString());

            }
        }

        public static void ImportPubKey(KeyStore ks, string importlocation) {
            ks.ImportPublicKey(@importlocation);
            Console.WriteLine("Key successfully imported!");
        }

        public static void ExportPubKey(KeyStore ks, string exportlocation, string userId,
            bool asciiArmored)
        {
            // export public key having the specified userId
            // all public sub keys are exported too
            ks.ExportPublicKey(@exportlocation,
                               userId,
                               asciiArmored);
            Console.WriteLine("Key successfully exported!");
        }

        public static string SingAndEncryptString(KeyStore ks, string signingKeyUserId,
            string signingKeyPassword, string encryptionKeyUserId, string plainText)
        {
 
            // if this key store contains a key with the desired recipient
            // userId then sign, otherwise notify that there is no such key
            if (ks.ContainsKey(encryptionKeyUserId))
            {
                PGPLib pgp = new PGPLib();

                string signedString =
                      pgp.SignAndEncryptString(plainText, ks,
                            signingKeyUserId,
                            signingKeyPassword,
                            encryptionKeyUserId);

                return signedString;
            }
            else
            {
                Console.WriteLine("No key with user Id:" +
                             encryptionKeyUserId +
                         " was found in this key store.");
               return String.Empty;
            }
        }

        public static void DecryptAndVerify(KeyStore ks, string signedString, string
            privateKeyDecryptionPassword) {
            // obtain an OpenPGP signed and enrypted message
            String signedAndEncryptedString = signedString;

            // Extract the message and check the validity of the signature
            String plainText;

            // create an instance of the library
            PGPLib pgp = new PGPLib();

            bool validSignature = pgp.DecryptAndVerifyString(signedAndEncryptedString,
                                     ks,
                                     privateKeyDecryptionPassword,
                                     out plainText);

            // Print the results
            Console.WriteLine("Extracted plain text message is " + plainText);
            if (validSignature)
            {
                Console.WriteLine("Signature is valid");
            }
            else
            {
                Console.WriteLine("Signature is invalid");
            }
        }

    }
}
