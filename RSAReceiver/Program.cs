using System;
using System.Text;

namespace RSAReceiver
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public static void RsaWithRsaParameterKey(byte[] encryptedRsaParams)
        {
            var rsaParams = new DecryptData();
            const string original = "Text to encrypt";

            rsaParams.AssignNewPrivateKey();

            var decryptedRsaParams = rsaParams.Decrypt(encryptedRsaParams);


            Console.WriteLine("RSA Encryption Demonstration in .NET");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            Console.WriteLine("In Memory Key");
            Console.WriteLine();
            Console.WriteLine("   Original Text = " + original);
            Console.WriteLine();
            Console.WriteLine("   Encrypted Text = " + Convert.ToBase64String(encryptedRsaParams));
            Console.WriteLine();
            Console.WriteLine("   Decrypted Text = " + Encoding.Default.GetString(decryptedRsaParams));
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
