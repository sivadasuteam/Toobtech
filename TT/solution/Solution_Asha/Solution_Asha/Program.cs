using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution_Asha
{
    class Program
    {
              /*   x+y*z+(x/y)+z=0   */
        static void Main(string[] args)
        {

            Program obj = new Program();
            int x = 4, y = 2, z = 1;
            float res;
            int t = obj.add(x, y);
            t = obj.mul(t, z);
            float t1 = obj.Div(x, y) + z;
            res = t + t1;
            Console.WriteLine(res);
            Console.ReadKey();
        }
        public float Div(int x, int y)
        {
            //float a = 15, b = 5, result;
            float result = x / y;
            //Console.WriteLine("result =" + result);
            return result;
        }
        public int mul(int x, int y)
        {
            //float a = 15, b = 5, result;
            int result = x * y;
            //Console.WriteLine("result =" + result);
            return result;
        }
        public int add(int x, int y)
        {
            //float a = 15, b = 5, result;
            int result = x + y;
            //Console.WriteLine("result =" + result);
            return result;
        }

    }
}
