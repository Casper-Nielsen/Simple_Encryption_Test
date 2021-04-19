using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace Simple_Encryption
{
    class Program
    {
        static void Main()
        {
            // runs the encryption test
            Console.WriteLine("encryptor");
            Console.Write("test string : ");
            // Gets the test string
            string testData = Console.ReadLine();

            // Encryptes the test string
            string encrypted = Encrypter.Encrypt(testData);
            Console.WriteLine(encrypted);

            // Decryptes the encrypted string
            string raw = Encrypter.Decrypt(encrypted);
            Console.WriteLine(raw);
            
            // Runs the speed test
            Console.WriteLine("Speed test");
            Console.ReadLine();
            SpeedTest speedTest = new SpeedTest();
            // Runs the test with 1000 repeates
            speedTest.Run(1000);
            Console.ReadLine();
        }
    }
}
