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
    public static class LicenseValidator
    {
        public static bool Verify(LicenseModel license, string signature)
        {
            string publicKey = File.ReadAllText("PublicKey.pem");

            using RSA rsa = RSA.Create();

            rsa.ImportFromPem(publicKey);

            string json = JsonSerializer.Serialize(license);

            byte[] data = Encoding.UTF8.GetBytes(json);

            byte[] signBytes = Convert.FromBase64String(signature);

            return rsa.VerifyData(
                data,
                signBytes,
                HashAlgorithmName.SHA256,
                RSASignaturePadding.Pkcs1);
        }
    }
}
