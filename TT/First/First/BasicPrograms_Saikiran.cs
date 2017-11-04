using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace First
{
    public class BasicPrograms_Saikiran
    {
        public void EqualOrNot(int a, int b)
        {
            {
                if (a == b)
                    Console.WriteLine("{0} and {1} are equal", a, b);
                else
                    Console.WriteLine("{0} and {1} are not equal", a, b);
                Console.ReadLine();
            }
        }


        public void EvenOrOdd(int i)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Entered number is an even number");

            }
            else
            {
                Console.WriteLine("Entered Number is an odd number");

            }
        }


        public void PositiveOrNegative(int num)
        {
            if (num >= 0)
            {
                Console.WriteLine("{0} is a positive number.", num);
            }
            else
            {
                Console.WriteLine("{0} is a negative number.", num);
            }
        }


        public void LeapYearOrNot(int i)
        {
            if (i % 4 == 0)
            {
                Console.WriteLine("Entered number is Leap year");

            }
            else
            {
                Console.WriteLine("Entered Number is not Leap year");

            }


        }


        public void EligableToVoteOrNot(int age)
        {
            if (age > 18)
            {
                Console.Write(" You are eligible for casting your vote");


            }
            else
                Console.Write("You are not eligible to caste your vote");
            Console.ReadLine();

        }


        public void HeightOfPerson(int Height)
        {
            if (Height < 150)
                Console.WriteLine("Person height is Dwarf");
            else if ((Height > 150) && (Height < 160))
                Console.WriteLine("Person height is average");
            else
                Console.WriteLine("Person height is taller");
            Console.ReadLine();
        }


        public void LargestNumber(int num1, int num2, int num3)
        {
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest among three ");
            else
                Console.Write("The 3rd Number is the greatest among three ");
            Console.ReadLine();
        }


        public void XYCoordinate(int a, int b)
        {
            if (a > 0 && b > 0)
                Console.WriteLine("The coordinate point ({0},{1}) lies in first coordinate", a, b);
            Console.ReadLine();
        }


        public void Temperature(int temp)
        {
            if (temp < 0)
            {
                Console.WriteLine("Freezing weather");
            }
            else if (temp > 10 && temp < 20)
            {
                Console.WriteLine("Very cold weather");
            }
            else if (temp > 20 && temp < 30)
            {
                Console.WriteLine("Normal in temperature");
            }
            else if (temp > 30 && temp < 40)
            {
                Console.WriteLine("Its hot");
            }
            else
            {
                Console.WriteLine("Its very hot");
            }
        }


        public void VowelOrConsonant(int i, int ch)
        {
            if (i >= 0 && i <= 1)
            {

            }
            else
            {
                switch (ch)
                {
                    case 'a':
                        Console.WriteLine("It is a vowel");
                        break;
                    case 'e':
                        Console.WriteLine("It is a vowel");
                        break;
                    case 'i':
                        Console.WriteLine("It is a vowel");
                        break;
                    case 'o':
                        Console.WriteLine("It is a vowel");
                        break;
                    case 'u':
                        Console.WriteLine("It is a vowel");
                        break;
                    default:
                        Console.WriteLine("It is not vowel");
                        break;

                }
            }
        }


        public void ElectricityBill(int units, double chrg, double amt, double surchrg, double netamt, string custid, string custnam)
        {
            {
                if (units < 200)
                    chrg = 1.20;
                else if (units > 200 && units < 400)
                    chrg = 1.50;
                else if (units > 400 && units < 600)
                    chrg = 1.80;
                else
                    chrg = 2.00;
                amt = units * chrg;
                if (amt > 250)
                    surchrg = amt * 15 / 100;


                netamt = amt + surchrg;
                if (netamt < 100)
                    netamt = 100;

                Console.WriteLine("Electricity Bill");
                Console.WriteLine("Customer IDNO ----------------      :{0}", custid);
                Console.WriteLine("Customer Name ----------------      :{0}", custnam);
                Console.WriteLine("unit Consumed ----------------      :{0}", units);
                Console.WriteLine("Amount Charges Rs. {0}  per unit     :{1}", chrg, amt);
                Console.WriteLine(" surcharge amount                   :{0}", surchrg);
                Console.WriteLine("Net Amount Paid By the Customer      :{0}", amt);
            }
        }


        public void Grade(char grd)
        {
            switch (grd)
            {
                case 'E':
                    Console.WriteLine("EXCELLENT");
                    break;
                case 'G':
                    Console.WriteLine("GOOD");
                    break;
                case 'A':
                    Console.WriteLine("AVERAGE");
                    break;
                case 'F':
                    Console.WriteLine("FAIL");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }


        public void DayNumber(int day)
        {
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday ");
                    break;
                case 2:
                    Console.WriteLine("Tuesday ");
                    break;
                case 3:
                    Console.WriteLine("Wednesday ");
                    break;
                case 4:
                    Console.WriteLine("Thursday ");
                    break;
                case 5:
                    Console.WriteLine("Friday ");
                    break;
                case 6:
                    Console.WriteLine("Saturday ");
                    break;
                case 7:
                    Console.WriteLine("Sunday  ");
                    break;
                default:
                    Console.WriteLine("Invalid day number");
                    break;

            }
        }

        public void MonthNumber(int month)
        {
            switch (month)
            {
                case 1:
                    Console.WriteLine("January Month have 31 days");
                    break;
                case 2:
                    Console.WriteLine("Feb has 28 days");
                    Console.WriteLine("leap year feb has 29 days");
                    break;
                case 3:
                    Console.WriteLine("March Month have 31 days");
                    break;
                case 4:
                    Console.WriteLine("April Month have 30 days");
                    break;
                case 5:
                    Console.WriteLine("May Month have 31 days");
                    break;
                case 6:
                    Console.WriteLine("June Month have 30 days");
                    break;
                case 7:
                    Console.WriteLine("July Month have 31 days");
                    break;
                case 8:
                    Console.WriteLine("August Month have 31 days");
                    break;
                case 9:
                    Console.WriteLine("September Month have 30 days");
                    break;
                case 10:
                    Console.WriteLine("October Month have 31 days");
                    break;
                case 11:
                    Console.WriteLine("November Month have 30 days");
                    break;
                case 12:
                    Console.WriteLine("December Month have 31 days");
                    break;

            }
        }


        public void palindrome(int n,int r,int rev=0)
        {

           
            Console.WriteLine("Palindrome numbers from 1 to 10000:");
            for (int i = 1; i <= 10000; i++)
            {
                n = i;
                while (n > 0)
                {
                    r = n % 10;
                    rev = (rev * 10) + (r);
                    n = n / 10;
                }
                if (rev == i)
                {
                    Console.WriteLine(i + " ");
                }
                rev = 0;
            }
        }


        public void PrintingStars(int n,int i, int j,int k)
        {
           for (i = 1; i <= n; i++)
            {
                //  Console.Write(" ");
                for (j = 1; j <= n - i; j++)
                {
                    //Console.WriteLine("*");
                }
                for (k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                for (k = n; k >= i; k--)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }

        public void Armstrong(int n,int b,int sum=0)
        {

            for (int i = 1; i <= 10000; i++)
            {
                n = i;
                while (n > 0)
                {
                    b = n % 10;
                    sum = sum + (b * b * b);
                    n = n / 10;
                }
                if (sum == i)
                {
                    Console.WriteLine(i + " ");
                }
                sum = 0;
            }
        }

    }
}