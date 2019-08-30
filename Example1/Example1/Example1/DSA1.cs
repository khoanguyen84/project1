using System;
using System.Collections.Generic;
using System.Text;

namespace Example1
{
    public class DSA1
    {
        public static void Main()
        {
            //Console.Write("Input n = ");
            //var n = int.Parse(Console.ReadLine());

            //Console.WriteLine("{0}! = {1}", n, GiaiThua(n));

            //int[] B = { 5, 7, 9, 8, 4, 8, 6, 5, 9, 2, 1, 3, 6 };
            //Console.WriteLine(string.Join(",", B));
            //Console.WriteLine("Sum of Array B is {0}", SumArr(B, B.Length));

            int[] C = { 5, 7, 9, 8, 4, 8, 6, 5, 9, 2, 1, 3, 6, 4, 6, 8, 10, 12 };

            Console.WriteLine(string.Join(",", C));
            //Console.WriteLine("Sum of Array C is {0}", SumArr(C, C.Length));
            Console.WriteLine("-------------------------------------------------");
            SelectionSort(C);
            Console.WriteLine(string.Join(",", C));

            try
            {
                var d = 0;
                var s = 10 / d;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static long GiaiThua(int n)
        {
            if (n == 1 || n == 0)
                return 1;
            return n * GiaiThua(n - 1);
        }

        public static long GiaiThua2(int n)
        {
            long sum = 1;
            for (int i = 1; i <= n; i++)
            {
                sum *= i;
            }
            return sum;
        }

        public static long SumArr(int[] A, int n)
        {
            if (n == 0)
                return 0;
            return SumArr(A, n - 1) + A[n - 1];
        }

        public static void SelectionSort (int[] A)
        {
            for(int i = 0; i < A.Length - 1; i++)
            {
                var min = A[i];
                var pos = i;
                for (int j = i+1; j< A.Length; j++)
                {
                    if(A[j] < min)
                    {
                        min = A[j];
                        pos = j;
                    }
                }
                var tem = A[i];
                A[i] = A[pos];
                A[pos] = tem;
            }
        }

        public class AgeException : ApplicationException
        {
            public AgeException(string mesage) : base(mesage) { }
        }
    }
}
