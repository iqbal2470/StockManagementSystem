using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StockManagementSystem.Licensing
{
    public static class MachineIdProvider
    {
        public static string GetMachineId()
        {
            string cpu = GetCpuId();
            string board = GetMotherboardId();
            string machineGuid = GetMachineGuid();

            string raw = $"{cpu}|{board}|{machineGuid}";

            using SHA256 sha = SHA256.Create();

            byte[] hash = sha.ComputeHash(Encoding.UTF8.GetBytes(raw));

            return string.Concat(hash.Select(x => x.ToString("X2")));
        }

        private static string GetCpuId()
        {
            try
            {
                using ManagementObjectSearcher searcher =
                    new("SELECT ProcessorId FROM Win32_Processor");

                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["ProcessorId"]?.ToString() ?? "";
                }
            }
            catch { }

            return "";
        }

        private static string GetMotherboardId()
        {
            try
            {
                using ManagementObjectSearcher searcher =
                    new("SELECT SerialNumber FROM Win32_BaseBoard");

                foreach (ManagementObject obj in searcher.Get())
                {
                    return obj["SerialNumber"]?.ToString() ?? "";
                }
            }
            catch { }

            return "";
        }

        private static string GetMachineGuid()
        {
            try
            {
                using RegistryKey key =
                    Registry.LocalMachine.OpenSubKey(
                    @"SOFTWARE\Microsoft\Cryptography");

                return key?.GetValue("MachineGuid")?.ToString() ?? "";
            }
            catch { }

            return "";
        }
    }
}
