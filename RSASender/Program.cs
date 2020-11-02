using System;
using System.Text;

namespace RSASender
{
    public class Program
    {
        static void Main(string[] args)
        {
            RsaWithRsaParameterKey();
        }
        private static void RsaWithRsaParameterKey()
        {
            var rsaParams = new EncryptData();
            const string original = "Text to encrypt";

            rsaParams.AssignNewPublicKey();

            var encryptedRsaParams = rsaParams.Encrypt(Encoding.UTF8.GetBytes(original));
            RSAReceiver.Program.RsaWithRsaParameterKey(encryptedRsaParams);


            //Console.WriteLine("RSA Encryption Demonstration in .NET");
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("In Memory Key");
            //Console.WriteLine();
            //Console.WriteLine("   Original Text = " + original);
            //Console.WriteLine();
            //Console.WriteLine("   Encrypted Text = " + Convert.ToBase64String(encryptedRsaParams));
            //Console.WriteLine();
            //Console.WriteLine("   Decrypted Text = " + Encoding.Default.GetString(decryptedRsaParams));
            //Console.WriteLine();
            //Console.WriteLine();
        }
    }
}
