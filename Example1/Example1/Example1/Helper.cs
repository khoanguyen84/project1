using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Example1
{
    public static class Helper
    {
        public static string fileName = $"C:\\CodeGym\\Practices\\NetCore\\Example1\\Example1\\Log_{DateTime.Now.ToString("dd_MM_yyyy")}.txt";
        public static void WriteLog(string message)
        {
            FileStream file = new FileStream(fileName, FileMode.Append);
            using (StreamWriter writer = new StreamWriter(file))
            {
                writer.WriteLine($"[Error]:{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}:{message}");
            }
        }

        public static string ReadLog(string fileName)
        {
            return string.Empty;
        }
    }
}
