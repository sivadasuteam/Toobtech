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


    }
}