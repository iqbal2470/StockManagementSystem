//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace InstallerHelper.Logging
//{
//    public static class InstallerLogger
//    {
//        public static void Info(string message)
//        {
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            Console.WriteLine(message);
//            Console.ResetColor();
//        }

//        public static void Success(string message)
//        {
//            Console.ForegroundColor = ConsoleColor.Green;
//            Console.WriteLine(message);
//            Console.ResetColor();
//        }

//        public static void Warning(string message)
//        {
//            Console.ForegroundColor = ConsoleColor.Yellow;
//            Console.WriteLine(message);
//            Console.ResetColor();
//        }

//        public static void Error(string message)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine(message);
//            Console.ResetColor();
//        }
//    }
//}


using System;
using System.IO;

namespace InstallerHelper.Logging
{
    public static class InstallerLogger
    {
        private static readonly string LogFile =
            Path.Combine(AppContext.BaseDirectory, "Installer.log");

        private static void Write(string type, string message)
        {
            string text =
                $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [{type}] {message}";

            Console.WriteLine(text);

            File.AppendAllText(LogFile, text + Environment.NewLine);
        }

        public static void Info(string message) => Write("INFO", message);
        public static void Success(string message) => Write("SUCCESS", message);
        public static void Warning(string message) => Write("WARNING", message);
        public static void Error(string message) => Write("ERROR", message);
    }
}