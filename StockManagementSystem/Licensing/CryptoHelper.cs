using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Licensing
{
    public static class CryptoHelper
    {
        // 32 Bytes = AES-256
        //private static readonly byte[] Key =
        //    Encoding.UTF8.GetBytes("TEAMARRIVE_SMS_LICENSE_KEY_2026");

        // 16 Bytes
        //private static readonly byte[] IV =
        //    Encoding.UTF8.GetBytes("SMS2026INITVECT");

        private const string SecretKey =
    "TEAMARRIVE_StockManagementSystem_2026_License_System";

        private static readonly byte[] Key =
            SHA256.HashData(Encoding.UTF8.GetBytes(SecretKey));

        private static readonly byte[] IV =
            MD5.HashData(Encoding.UTF8.GetBytes("TEAMARRIVE_IV"));

        public static string Encrypt(string plainText)
        {
            using Aes aes = Aes.Create();

            aes.Key = Key;
            aes.IV = IV;

            ICryptoTransform encryptor = aes.CreateEncryptor();

            using MemoryStream ms = new();

            using CryptoStream cs = new(ms, encryptor, CryptoStreamMode.Write);

            using StreamWriter sw = new(cs);

            sw.Write(plainText);

            sw.Close();

            return Convert.ToBase64String(ms.ToArray());
        }

        public static string Decrypt(string cipherText)
        {
            using Aes aes = Aes.Create();

            aes.Key = Key;
            aes.IV = IV;

            ICryptoTransform decryptor = aes.CreateDecryptor();

            byte[] buffer = Convert.FromBase64String(cipherText);

            using MemoryStream ms = new(buffer);

            using CryptoStream cs = new(ms, decryptor, CryptoStreamMode.Read);

            using StreamReader sr = new(cs);

            return sr.ReadToEnd();
        }
    }
}
