using System;
using System.Collections.Generic;
using System.Text;

namespace Example1.Example7
{
    public class StudentMark : IStudentMark
    {
        public int Id { get; set; }
        public string Fullname  { get; set; }
        public string ClassName { get; set; }
        public string Semester { get; set; }
        public float AverageRate { get; private set; }
        public int[] SubjectMarkList = new int[5];
        public string Display()
        {
            return $"Id: {Id}, Fullname: {Fullname}, Class: {ClassName}, Semester: {Semester}, AverageRate: {AverageRate}";
        }
        public void AveCal()
        {
            var total = 0;
            for(int i = 0; i < SubjectMarkList.Length; i++)
            {
                total += SubjectMarkList[i];
            }
            AverageRate = (float)(total / SubjectMarkList.Length);
        }
    }
}
