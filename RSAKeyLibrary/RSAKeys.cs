using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSAKeyLibrary
{
    public class RSAKeys
    {
        static private RSAParameters _publicKey;
        static private RSAParameters _privateKey;


        static public RSACryptoServiceProvider GetPublicKey()
        {
             
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                _publicKey = rsa.ExportParameters(false);
                return rsa;
            }
        }

    }
}
