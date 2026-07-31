using LicenseGeneratorTool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LicenseGeneratorTool.Services
{
    public static class LicenseSigner
    {
        public static string Sign(LicenseModel license)
        {
            // JSON without Signature
            string json = JsonSerializer.Serialize(license);

            // Read Private Key
            string privateKey = File.ReadAllText("PrivateKey.pem");

            using RSA rsa = RSA.Create();

            rsa.ImportFromPem(privateKey);

            byte[] data = Encoding.UTF8.GetBytes(json);

            byte[] signature = rsa.SignData(
                data,
                HashAlgorithmName.SHA256,
                RSASignaturePadding.Pkcs1);

            return Convert.ToBase64String(signature);
        }
    }
}
