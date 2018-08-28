using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;
            double A;
            const double pi = 3.14;
            Console.WriteLine("type redius of circle here");
            r = Convert.ToInt32(Console.ReadLine());
            A = pi * r * r;
            Console.WriteLine("A : {0}", A);
            Console.ReadLine();

            int num1, num2;
            Console.WriteLine("enter num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            int Result;
            Result = num1 + num2;
            Console.WriteLine("Addition of num1{0},num2{1} is result{2}", num1, num2, Result);
            Result = num1 - num2;
            Console.WriteLine("substraction of two number {0}", Result);
            Result = num1 * num2;
            Console.WriteLine("multiplication of two number {0}", Result);
            Result = num1 / num2;
            Console.WriteLine("division of two number {0}", Result);
            Result = num1 % num2;
            Console.WriteLine("module of num1{0}", Result);
            Console.ReadLine();
        }
    }
}

