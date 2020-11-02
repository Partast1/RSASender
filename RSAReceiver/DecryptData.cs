using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace RSAReceiver
{
    public class DecryptData
    {
        private RSAParameters _privateKey;

        public void AssignNewPrivateKey()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                _privateKey = rsa.ExportParameters(true);
            }
        }

        public byte[] Decrypt(byte[] dataToDecrypt)
        {
            byte[] plain;

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;

                rsa.ImportParameters(_privateKey);
                plain = rsa.Decrypt(dataToDecrypt, true);
            }

            return plain;
        }
    }
}
