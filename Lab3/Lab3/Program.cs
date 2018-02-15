using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            int a;
            method1(ref i);
            Console.WriteLine("Value After Ref method: " + i);
            method2(out a, i);
            Console.WriteLine("Value After out method: " + a);
            Console.WriteLine("Sum of all values Passed in ParamsMethod: " + ParamsMethod(1, 2, 3, 4, 4, 5, 6));

            Console.ReadLine();

        }
        public static void method1(ref int x)
        {
            x = x + 10;

        }
        public static void method2(out int a, int i)
        {
            a = i + 10;
        }
        public static int ParamsMethod(params int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }

    }
}
