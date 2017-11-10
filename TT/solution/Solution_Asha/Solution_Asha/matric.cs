using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_Asha
{
    class matric
    {
        public void MatricMethod()
        {
            int[,] A = new int[2,2];
            int i, j;
            for (i = 0; i <= 1; i++)
            {
                for (j = 0; j <= 1; j++)
                {
                   A[i,j] = Convert.ToInt32(Console.ReadLine());
                  
                }
            }
            for (i = 0; i <= 1; i++)
            {
                for (j = 0; j <= 1; j++)

                {
                   Console.Write(A[i,j]);

                }
                Console.WriteLine();

            }

        }
       /* static void Main(string[] args )
        {
            matric obj = new matric();
            obj.MatricMethod();
        }*/
    }
}
