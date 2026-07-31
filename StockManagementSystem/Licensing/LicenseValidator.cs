using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StockManagementSystem.Licensing
{
    public static class LicenseValidator
    {
        public static bool Verify(LicensePackage package)
        {
            string publicKeyPath = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Keys",
                "PublicKey.pem");

            if (!File.Exists(publicKeyPath))
                throw new FileNotFoundException("Public key not found.");

            string publicKey = File.ReadAllText(publicKeyPath);

            using RSA rsa = RSA.Create();

            rsa.ImportFromPem(publicKey);

            string json = JsonSerializer.Serialize(package.License);

            byte[] data = Encoding.UTF8.GetBytes(json);

            byte[] signature = Convert.FromBase64String(package.Signature);

            return rsa.VerifyData(
                data,
                signature,
                HashAlgorithmName.SHA256,
                RSASignaturePadding.Pkcs1);
        }
    }
}
