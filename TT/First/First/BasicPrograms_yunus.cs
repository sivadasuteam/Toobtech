using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First
{
    public class BasicPrograms_yunus
    {
        public static void Main(string[] args)
        {
            BasicPrograms_yunus calucalation = new BasicPrograms_yunus();
            calucalation.sub();
         //   calucalation.Mul();
           // calucalation.Name("shaik ", "yunus");
            //calucalation.Div(8, 6);
            //calucalation.Add(4, 9);
            Console.ReadLine();


        }
        public void sub()//without return type----without parameters
        {
            int a = 10, b = 5;
            int result = a - b;

            Console.WriteLine(result);
        }
        public int Mul()//with return type----without parameters 
        {
            int a = 10, b = 5; 
            int result = a * b;
            return result;
        }
        public string Name(string surname, string firstname)//with return type----with parameters 
        {
            return surname + firstname;

        }
        public int Div(int a, int b)//with return type----with parameters 
        {

            int result = a / b;
            return result;
        }
        public void Add(int a, int b)//without return type----with parameters 
        {

            int result = a + b;
            Console.WriteLine(result);
        }
    }
}