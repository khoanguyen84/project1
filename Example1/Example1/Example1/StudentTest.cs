using Example1.Example7;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Example1
{
    public class StudentTest
    {
        public static ArrayList StudentList = new ArrayList();
        public static int Id = 0;
        public static void Main()
        {
            InitMenu();
        }
        public static void InitMenu()
        {
            int option = 0;
            do
            {
                Console.WriteLine("MARKS MANAGEMENT SYSTEM");
                Console.WriteLine("Please select an option from 1 to 4");
                Console.WriteLine("1. Insert new Student ...");
                Console.WriteLine("2. View list of Student ...");
                Console.WriteLine("3. Average Mark ...");
                Console.WriteLine("4. Exit");
                
                Console.Write("Option: ");
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    option = number;
                }
            }
            while (option > 4 || option <= 0);

            Process(option);
        }
        public static void Process(int selected)
        {
            Console.Clear();
            switch (selected)
            {
                case 1:
                    {
                        CreateStudent();
                        break;
                    }
                case 2:
                    {
                        DisplayStudent();
                        break;
                    }
                case 3:
                    {
                        AverageStudentMark();
                        break;
                    }
                case 4:
                default:
                    {
                        Environment.Exit(Environment.ExitCode);
                        break;
                    }
            }
            InitMenu();
        }
        public static void CreateStudent()
        {
            var student = new StudentMark();
            Id = Id + 1;
            student.Id = Id;

            Console.Write("Please input student fullname: ");
            student.Fullname = Console.ReadLine();

            Console.Write("Please input class name: ");
            student.ClassName = Console.ReadLine();

            Console.Write("Please input semester: ");
            student.Semester = Console.ReadLine();

            for(int i = 0; i < student.SubjectMarkList.Length; i++)
            {
                Console.Write("Please input mark of subject {0}: ", i+1);
                student.SubjectMarkList[i] = int.Parse(Console.ReadLine());
            }

            StudentList.Add(student);
        }
        public static void DisplayStudent()
        {
            foreach(StudentMark student in StudentList)
            {
                Console.WriteLine(student.Display());
            }
        }
        public static void AverageStudentMark()
        {
            foreach (StudentMark student in StudentList)
            {
                student.AveCal();
            }
        }
    }
    
}
