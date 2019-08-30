using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Example1
{
    public class IOTest1
    {
        public static void Main()
        {
            //FileStream fs = new FileStream("C:\\CodeGym\\Practices\\NetCore\\Example1\\Example1\\Text1.txt", FileMode.Append);
            //using (StreamWriter writer = new StreamWriter(fs))
            //{
            //    writer.WriteLine($"[Log] - {DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}: this is a big bug.");
            //}

            //FileStream fsReader = new FileStream("C:\\CodeGym\\Practices\\NetCore\\Example1\\Example1\\Text1.txt", FileMode.Open);
            //using (StreamReader reader = new StreamReader(fsReader))
            //{
            //    string line = reader.ReadToEnd();
            //    Console.WriteLine(line);
            //}

            FileStream fs = new FileStream("C:\\CodeGym\\Practices\\NetCore\\Example1\\Example1\\Text1.txt", FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                Console.Write("intput size of array: ");
                var n = int.Parse(Console.ReadLine());
                writer.WriteLine(n);
                for(int i = 0; i < n; i++)
                {
                    Console.Write("Input A[{0}]: ", i);
                    var v = Console.ReadLine();
                    writer.Write(v.ToString() + " ");
                }
            }

            FileStream fsReader = new FileStream("C:\\CodeGym\\Practices\\NetCore\\Example1\\Example1\\Text1.txt", FileMode.Open);
            using (StreamReader reader = new StreamReader(fsReader))
            {
                string line1 = reader.ReadLine();
                Console.WriteLine(line1);
                string line2 = reader.ReadLine();
                Console.WriteLine(line2);
                string[] arr = line2.Split(' ');
                for(int i = 0; i< arr.Length; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }

            //FileStream fsWrite = new FileStream("C:\\CodeGym\\Practices\\NetCore\\Example1\\Example1\\Text1.txt", FileMode.Append);
            //using (BinaryWriter writer1 = new BinaryWriter(fsWrite))
            //{
            //    for(int i = 0; i<10; i++)
            //    {
            //        writer1.Write((byte)i++);
            //    }

            //}

            //FileStream fsReader = new FileStream("C:\\CodeGym\\Practices\\NetCore\\Example1\\Example1\\Text1.txt", FileMode.Open);
            //using (StringReader reader = new StringReader("C:\\CodeGym\\Practices\\NetCore\\Example1\\Example1\\Text1.txt"))
            //{
            //    var line = reader.ReadLine();
            //    Console.WriteLine(line);
            //}
        }
    }
}
