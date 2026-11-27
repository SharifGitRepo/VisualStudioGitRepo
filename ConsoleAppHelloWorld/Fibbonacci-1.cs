using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHelloWorld
{
    internal class Fibbonacci_1
    {
        public static long Fibo(int n)
        {
            if (n <= 1)
                return 0;

            long prev=0;
            long current=1;
            for(int i=2;i<=n;i++)
            {
                long next = prev + current;
                prev=current;
                current = next;
            }
            return current;
        }
        public static void Main(string[] args)
        {
            Fibo(8);
        }
    }
}
