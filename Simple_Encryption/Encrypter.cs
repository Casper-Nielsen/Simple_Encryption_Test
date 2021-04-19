using System;
using System.Collections.Generic;
using System.Text;

namespace Simple_Encryption
{
    class Encrypter
    {
        /// <summary>
        /// Encryptes the string with Substitution encrypton using utf8
        /// </summary>
        /// <param name="raw">the text to be encrypted</param>
        /// <returns>returns the encrypted text</returns>
        public static string Encrypt(string raw)
        {
            // Gets the byte values for the string using utf8
            byte[] bytes = Encoding.UTF8.GetBytes(raw);
            for (int i = 0; i < bytes.Length; i++)
            {
                // adds 4 to each byte in the array
                bytes[i] += 4;
            }
            // Gets the string value for the byte array using utf8
            return Encoding.UTF8.GetString(bytes);
        }

        /// <summary>
        /// Decrypts the string with Substitution encrypton using utf8
        /// </summary>
        /// <param name="encrypted">The encrypted text that will be decrypted</param>
        /// <returns>The decrypted text</returns>
        public static string Decrypt(string encrypted)
        {
            // Gets the byte values for the string using utf8
            byte[] bytes = Encoding.UTF8.GetBytes(encrypted);
            for (int i = 0; i < bytes.Length; i++)
            {
                // Removes 4 for each byte in the array
                bytes[i] -= 4;
            }
            // Gets the string value for the byte array using utf8
            return Encoding.UTF8.GetString(bytes);
        }
    }
}
