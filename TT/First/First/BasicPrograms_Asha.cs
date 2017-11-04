using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First
{
    public class BasicPrograms_Asha
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
        public void StudentEligible(int x, int y, int z)
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
            float p = T / 3;
            Console.WriteLine("Percentage: " + p);

            if (p >= 80.0)
                Console.WriteLine("Division : First");
            else if (p >= 70.0 && p < 80.0)
                Console.WriteLine("Division : Second");
            else if (p >= 60.0 && p < 70.0)
                Console.WriteLine("Division : Third");
            else
                Console.WriteLine("Below Average");
        }
        public void TemperatureState(int x)
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
        static void CallingMethods(string[] args)
        {
            BasicPrograms_Asha obj = new BasicPrograms_Asha();
            int option;
            //char ch='y';
            Console.WriteLine("Tasks: ");
            Console.WriteLine("1. To check whether two numbers are equal: ");
            Console.WriteLine("2. To check whether a given number is even or odd: ");
            Console.WriteLine("3. To check whether a given number is Positive or Negative: ");
            Console.WriteLine("4. To find whether a given year is a leap year or not: ");
            Console.WriteLine("5. To determine whether it is eligible for casting his/her own vote: ");
            Console.WriteLine("6. To categorize the person according to their height: ");
            Console.WriteLine("7. To find the largest of three numbers: ");
            Console.WriteLine("8. To find which quadrant the coordinate point lies: ");
            Console.WriteLine("9. To find the eligibility of admission : ");
            /*Console.WriteLine("10. To calculate the total, percentage and division of the student :");
            Console.WriteLine("11. To display a suitable message according to temperature state : ");
            Console.WriteLine("12. To check whether an alphabet is a vowel or consonant: ");
            Console.WriteLine("13. To calculate profit and loss on a transaction: ");
            Console.WriteLine("14. To calculate and print the Electricity bill of a given customer: ");
            Console.WriteLine("15. To accept a grade and declare the equivalent description : ");
            Console.WriteLine("16. To read any day number in integer and display day name in the word: ");
            Console.WriteLine("17. To to read any Month Number in integer and display the number of days for this month: ");*/
            Console.WriteLine("Enter option: ");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    {
                        Console.WriteLine("Enter number1: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter number2: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        obj.EqualOrNot(a, b);
                        break;

                    }
                case 2:
                    {
                        Console.WriteLine("Enter number: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        obj.EvenOrOdd(a);
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Enter number: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        obj.PositiveOrNegative(a);
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Enter a year: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        obj.LeapYear(a);

                        break;
                    }
                case 5:
                    {
                        Console.WriteLine("Enter the age of a candidate : ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        obj.EligibleOrNot(a);
                        break;
                    }
                case 6:
                    {
                        Console.WriteLine("Enter the height of a person : ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        obj.Height(a);

                        break;
                    }
                case 7:
                    {
                        Console.WriteLine("Enter number1 : ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter number2 : ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter number3 : ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        obj.Largest(a, b, c);

                        break;
                    }
                case 8:
                    {
                        Console.WriteLine("Enter X-coordinate : ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter y-coordinate : ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        obj.Quadrant(a, b);

                        break;
                    }
                case 9:
                    {
                        Console.WriteLine("Enter marks obtained in Mathematics : ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter marks obtained in Physics : ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter marks obtained in Chemistry : ");
                        int c = Convert.ToInt32(Console.ReadLine());
                        obj.StudentEligible(a, b, c);
                        break;

                    }
                    /* case 10:
                         {
                             Console.WriteLine("Enter  Roll Number of the student  : ");
                             int a = Convert.ToInt32(Console.ReadLine());
                             Console.WriteLine("Enter Name of the Student  : ");
                             string name = Console.ReadLine(); // Get string from user
                             if (name == "exit") // Check string
                             {
                                 break;
                             }
                             Console.WriteLine("Enter marks obtained in Physics : ");
                             int b = Convert.ToInt32(Console.ReadLine());
                             Console.WriteLine("Enter marks obtained in Chemistry : ");
                             int c = Convert.ToInt32(Console.ReadLine());
                             Console.WriteLine("Enter marks obtained in Computer Applications : ");
                             int d = Convert.ToInt32(Console.ReadLine());
                             obj.TotalPercentDiv(b, c, d);

                             break;
                         }
                    */


            }
            Console.ReadKey();
        }
    }
}