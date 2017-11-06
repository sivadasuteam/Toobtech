using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First
{
    public class BasicPrograms1
    {
        public void EqualOrNot()
        {
            int x = 5; int y = 5;
            if (x == y)
                Console.WriteLine(x + " and " + y + " are Equal");
            else
                Console.WriteLine(x + " and " + y + " are Not Equal");
        }
        public void EvenOrOdd(int x)
        {
            if (x % 2 == 0)
                Console.WriteLine(x + " is an Even integer");
            else
                Console.WriteLine(x + " is an Odd integer");
        }
        public void PositiveOrNegative()
        {
            int Z = 10;
            if (Z >= 0)
                Console.WriteLine(Z + " is a Positive number");
            else
                Console.WriteLine(Z + " is a Negative");
        }
        public void CheckLeapYear(int x)
        {
            if (x % 4 == 0)
                Console.WriteLine(x + " is a Leap Year");
            else
                Console.WriteLine(x + " is a Not a Leap Year");
        }
        public void CastingVote(int x)
        {
            if (x >= 18)
                Console.WriteLine(" Congratulation! You are eligible for casting your vote.");
            else
                Console.WriteLine(" Sorry! You are not eligible for casting your vote.");
        }
        public void Heightofperson()
        {
            float HGT;
            Console.WriteLine("Enter  the Height in centimeters \n");
            HGT = Convert.ToSingle(Console.ReadLine());

            if (HGT < 150.0)
            {
                Console.WriteLine("Dwarf");
            }

            else if ((HGT >= 150.0) && (HGT <= 165.0))
            {
                Console.WriteLine(" Average Height");
            }

            else if ((HGT >= 165.0) && (HGT <= 195.0))
            {
                Console.WriteLine("Taller");
            }

            else
                Console.WriteLine("Abnormal height");
        }
        public void DisplayvalueN()
        {
            Console.WriteLine("Enter M Value");
            int m = Convert.ToInt32(Console.ReadLine());
            int n;

            if (m > 0)
            {
                Console.WriteLine("n =1");

            }
            else if (m == 0)
            {
                Console.WriteLine("n = 0");
            }
            else if (m < 0)
            {
                Console.WriteLine("n = -1");
            }

        }
        public void Largest()
        {
            int x = 63;
            int y = 55;
            int z = 50;



            if (x > y && x > z)
                Console.WriteLine(x + " is Largest of " + y + ", " + z);
            else if (y > x && y > z)
                Console.WriteLine(y + " is Largest of " + x + ", " + z);
            else
                Console.WriteLine(z + " is Largest of " + x + ", " + y);

        }

    }
}