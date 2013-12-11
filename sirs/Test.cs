using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DidiSoft.Pgp;

namespace OpenPGP
{
    class Test
    {
        static void Main(string[] args)
        {

            // 1. Generate a new key pair into the keystore with minimum required fields

            // initialize the key store where the generated key
            // will be produced, if the file does not exist
            // it will be created
            // Specify location and password

            KeyStore ks = new KeyStore(@"test1.store",
                                           "test");

            // key primary user Id
            String userId = "test2013@test.com";
            // this is the password of the private key in the key pair
            String privateKeyPassword = "test";
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

            OpenPGP.GenerateKeyPair(ks, userId, privateKeyPassword, cypher, hashing, compression,
                keySizeInBits, algorithm);

            // 2. List the keys in the keystore

            OpenPGP.ListKeys(ks);

            // 3. Export a key from the Keystore

            String exportlocation = @"public_key_exported.asc";
            // should the exported files be ASCII or binary
            bool asciiArmored = true;
            OpenPGP.ExportPubKey(ks, exportlocation, userId, asciiArmored);

            // 4. Import a key into the keystore
            string importlocation = @"C:\Users\Daharewa\Desktop\test.asc";
            OpenPGP.ImportPubKey(ks, importlocation);

            // 5. Encrypt and Sign
            // our private key User Id
            string signingKeyUserId = "test@test.com";
            string signingKeyPassword = "test";
            // recipient public key User Id
            string encryptionKeyUserId = "test@test.com";
            string plainText = "Hello World";
            string singedAndencryptedText = OpenPGP.SingAndEncryptString(ks, signingKeyUserId,
                signingKeyPassword, encryptionKeyUserId, plainText);
            Console.WriteLine(singedAndencryptedText);

            // 6. Decrypt and Verify
            String privateKeyDecryptionPassword = "test";
            OpenPGP.DecryptAndVerify(ks, singedAndencryptedText, privateKeyDecryptionPassword);

            Console.ReadLine();
        }
    }
}
