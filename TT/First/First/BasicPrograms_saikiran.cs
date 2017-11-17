using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First
{
    public class BasicPrograms_saikiran
    {

        public void EqualOrNot(int x, int y)
        {
            if (x == y)
                Console.WriteLine(x + " and " + y + " are equal");
            else
                Console.WriteLine(x + " and " + y + " are not equal");
        }
        public void EvenOrOdd(int x)
        {
            if (x % 2 == 0)
                Console.WriteLine(x + " is an Even integer");
            else
                Console.WriteLine(x + " is an Odd integer");
        }
        public void PositiveOrNegative(int x)
        {
            if (x > 0)
                Console.WriteLine(x + " is a Positive number");
            else
                Console.WriteLine(x + " is a Negative");
        }
        public void LeapYear(int x)
        {
            if (x % 4 == 0 && x % 100 != 0 || x % 400 == 0)
                Console.WriteLine(x + " is a Leap Year");
            else
                Console.WriteLine(x + " is a not Leap Year");
        }
        public void EligibleOrNot(int x)
        {
            if (x >= 21)
                Console.WriteLine(" Congratulation! You are eligible for casting your vote.");
            else
                Console.WriteLine(" Sorry! You are not eligible for casting your vote.");
        }
        public void Height(int ht)
        {
            if (ht < 150)
                Console.WriteLine("The person is Dwarf");
            else if ((ht >= 150) && (ht <= 165))
                Console.WriteLine(" The Person is of Average Height");
            else if ((ht >= 165) && (ht <= 195))
                Console.WriteLine(" The person is Taller");
            else
                Console.WriteLine(" The Person is of Abnormal height");
        }
        public void Largest(int x, int y, int z)
        {
            if (x > y && x > z)
                Console.WriteLine(x + " is Largest of " + y + ", " + z);
            else if (y > x && y > z)
                Console.WriteLine(y + " is Largest of " + x + ", " + z);
            else
                Console.WriteLine(z + " is Largest of " + x + ", " + y);
        }
        public void Quadrant(int x, int y)
        {
            if (x > 0 && y > 0)
                Console.WriteLine(x + ", " + y + " lies in the First quandrant\n");
            else if (x < 0 && y > 0)
                Console.WriteLine(x + ", " + y + " lies in the Second quandrant\n");
            else if (x < 0 && y < 0)
                Console.WriteLine(x + ", " + y + " lies in the Third quandrant\n");
            else if (x > 0 && y < 0)
                Console.WriteLine(x + ", " + y + " lies in the Fourth quandrant\n");
            else if (x == 0 && y == 0)
                Console.WriteLine(x + ", " + y + " lies at the origin\n");
        }
        public void StudentEligibleForAdmission(int x, int y, int z)
        {
            if ((x >= 65 && y >= 55 && z >= 50 && (x + y + z) >= 180) || ((x + (x + y + z)) >= 140))
                Console.WriteLine("The candidate is eligible for admission.");
            else
                Console.WriteLine("The candidate is not eligible for admission.");
        }
        public void TotalPercentDiv(int x, int y, int z)
        {
            int T = x + y + z;
            Console.WriteLine("Total: " + T);
            float avg = T / 3;
            Console.WriteLine("Percentage: " + avg);

            if (avg >= 80.0)
                Console.WriteLine("Division : First");
            else if (avg >= 70.0 && avg < 80.0)
                Console.WriteLine("Division : Second");
            else if (avg >= 60.0 && avg < 70.0)
                Console.WriteLine("Division : Third");
            else
                Console.WriteLine("Below Average");
        }
        public void Temperature(int x)
        {
            if (x < 0)
                Console.WriteLine("Freezing weather ");
            else if (x > 0 && x <= 10)
                Console.WriteLine(" Very Cold weather ");
            else if (x > 10 && x <= 20)
                Console.WriteLine(" Cold weather ");
            else if (x > 20 && x <= 30)
                Console.WriteLine(" Normal in Temp ");
            else if (x > 30 && x <= 40)
                Console.WriteLine(" Its hot ");
            else if (x >= 40)
                Console.WriteLine(" Its very hot ");
        }
    }


}