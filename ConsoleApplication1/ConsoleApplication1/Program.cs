using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {

        static void Main(string[] args)
        {
            if (IsOdd(6) == true)
                Console.Write("so le");


        }
        public static bool IsOdd(int n)
        {
            if (n % 2 != 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsEven(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public static int Square(int n)
        {
            int nSqr = 1;
            return nSqr = n * n;
        }
        public static int Cube(int n)
        {
            int ncu = 1;
            return ncu = n * n * n;
        }
        public static int Pow(int x, int y)
        {
            if (y == 0) return 1;
            if (y == 1) return x;
            int a = y / 2;
            int xa = Pow(x, a);
            if (a + a == y)
                return xa * xa;
            else
                return xa * xa * x;
        }
        public static int Abs(int n)
        {
            return ((n < 0) ? (-n) : (n));
        }
        public static long Factorial(long n)
        {
            int nfactorial = 1;
            if (n == 0) return nfactorial = 1;
            for (int i = 1; i < n; i++)
            {
                nfactorial = nfactorial * i;
            }
            return nfactorial;
        }
        //input : x
        //output : int a that is smallest but not smaller than x
        //idea : int(n) then int(n)+1
        //if x is negative then a is unchange
        public static int Ceil(double n)
        {
            if (n % 1 > 0)
            {
                return (int)n + 1;
            }
            return (int)n;
        }
        //input : x
        //output : int a that is smallest but not smaller than x
        //idea : int(n) then int(n)-1
        //if x is negative then a is unchange
        public static int Floor(double n)
        {
            if (n % 1 < 0)
            {
                return (int)n - 1;
            }
            return (int)n;

        }
        public static int Random(int n)
        {
            Random rd = new Random();
            return n = rd.Next(0, 1073741824);
        }
        public static float random2()
        {
            Random rd2 = new Random();
            return rd2.Next(0, 1);
        }
    }
}

