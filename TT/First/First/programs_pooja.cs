using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First
{
    public class exerciselogics
    {
        public static void Main()
        {

            int int1, int2;


            Console.Write("Input 1st number: ");
            int1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int2 = Convert.ToInt32(Console.ReadLine());

            if (int1 == int2)
                Console.WriteLine("{0} and {1} are equal.\n", int1, int2);
            else
                Console.WriteLine("{0} and {1} are not equal.\n", int1, int2);

        }
    }
}
public class programs_pooja
{
    public static void Main()
    {
        int vote_age;
        Console.Write("Input the age of the candidate : ");
        vote_age = Convert.ToInt32(Console.ReadLine());
        if (vote_age < 18)
        {
            Console.Write("Sorry, You are not eligible to caste your vote.\n");
            Console.Write("You would be able to caste your vote after {0} year.\n\n", 18 - vote_age);
        }
        else
            Console.Write("Congratulation! You are eligible for casting your vote.\n\n");


        {
            int dayno;

           Console.Write("Input Day No : ");
            dayno = Convert.ToInt32(Console.ReadLine());

            switch (dayno)
            {
                case 1:
                    Console.Write("Monday \n");
                    break;
                case 2:
                    Console.Write("Tuesday \n");
                    break;
                case 3:
                    Console.Write("Wednesday \n");
                    break;
                case 4:
                    Console.Write("Thursday \n");
                    break;
                case 5:
                    Console.Write("Friday \n");
                    break;
                case 6:
                    Console.Write("Saturday \n");
                    break;
                case 7:
                    Console.Write("Sunday  \n");
                    break;
                default:
                    Console.Write("Invalid day number. \nPlease try again ....\n");
                    break;
            }
        }
    }
}
