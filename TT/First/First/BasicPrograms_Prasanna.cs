using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First
{
    public class BasicPrograms_Prasanna
    {
        public void Even()
        {
            for (int num = 2; num <= 1000; num++)
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            Console.ReadLine();
        }
        public void febinoccint()
        {
            int num1 = 0;
            int num2 = 1;
            int sum = 1;
            while (num1 <= 10000)
            {
                sum = num1 + num2;
                num1 = num2;
                num2 = sum;
                Console.WriteLine(num2);
            }
            Console.ReadLine();
        }
        public void calculator()
        {
            double num1, num2;
            void read()
            {
                Console.WriteLine("\n Enter any two numbers:");
                Console.Write("\n Number1 : ");
                num1 = double.Parse(Console.ReadLine());
                Console.Write("\n Number2 : ");
                num2 = double.Parse(Console.ReadLine());
            }
             void add()
            {
                double sum = num1 + num2;
                Console.WriteLine("\n Result : ({0}) + ({1}) = {2}", num1, num2, sum);
            }
             void subtract()
            {
                double diff = num1 - num2;
                Console.WriteLine("\n Result : ({0}) - ({1}) = {2}", num1, num2, diff);
            }
             void multiply()
            {
                double prod = num1 * num2;
                Console.WriteLine("\n Result : ({0}) X ({1}) = {2}", num1, num2, prod);
            }
            void divide()
            {
                double qt = num1 / num2;
                Console.WriteLine("\n Result : ({0}) / ({1}) = {2}", num1, num2, qt);
            }
        }






        }
    }