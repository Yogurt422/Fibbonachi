using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DanyaCSharp
{
    internal class Fib
    {
        public static int[] fibbonachi(int n)
        {
            int[] result = new int[n];

            result[0] = 0;
            result[1] = 1;
            
            for (int i = 2; i < n; i++)
            {
                result[i] = result[i-1] + result[i-2];
            }
            return result;
        }

    }
}
/*
  using DanyaCSharp;

int num = 10;

var fib = string.Join(" ", (Fib.fibbonachi(num)));
Console.WriteLine(fib);

 */
