using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;


namespace RSASender
{
    public class EncryptData
    {
        private RSAParameters _publicKey;

        public void AssignNewPublicKey()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                _publicKey = rsa.ExportParameters(false);
            }
        }

        public byte[] Encrypt(byte[] dataToEncrypt)
        {
            byte[] cipherbytes;

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(_publicKey);

                cipherbytes = rsa.Encrypt(dataToEncrypt, true);
            }

            return cipherbytes;
        }

      
    }
}
