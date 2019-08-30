using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
namespace Example1
{
    public class ExceptionTest
    {
        public static void Main()
        {
            //FileStream file = new FileStream($"C:\\CodeGym\\Practices\\NetCore\\Example1\\Example1\\Log_{DateTime.Now.ToString("dd_MM_yyyy")}.txt", FileMode.Append);
            try
            {
                Console.Write("Input a = ");
                var a = int.Parse(Console.ReadLine());
                Console.Write("Input b = ");
                var b = int.Parse(Console.ReadLine());
                var result = a / b;
                Console.WriteLine("{0}/{1}={2}", a, b, result);
            }
            catch (DivideByZeroException dze)
            {
                //using (StreamWriter writer = new StreamWriter(file))
                //{
                //    writer.WriteLine($"[Error]:{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}:{dze.Message}");
                //}
                Helper.WriteLog(dze.Message);
                Console.Write("[Error]:" + dze.Message);
            }
            catch (FieldAccessException fae)
            {
                Console.Write(fae.Message);
            }
            catch (Exception ex)
            {
                using (StreamWriter writer = new StreamWriter(file))
                {
                    writer.WriteLine($"[Error]:{DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt")}:{ex.Message}");
                }
                Console.Write("Something went wrong, please again later.");
            }
            finally
            {
                Console.Write("go to finally");
            }
            file.Close();
            FileStream file1 = new FileStream($"C:\\CodeGym\\Practices\\NetCore\\Example1\\Example1\\Log_{DateTime.Now.ToString("dd_MM_yyyy")}.txt", FileMode.Open, FileAccess.Read);
            using (StreamReader reader = new StreamReader(file1))
            {
                var content = reader.ReadLine();
                Console.Write(content);
            }

            Helper.WriteLog()
        }
    }
}
