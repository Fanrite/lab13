using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hlp
{
    class Hlp1
    {
        public static void Genarrd (ref double[] arr, ref int n, ref double a, ref double b )
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = a + r.NextDouble() * (b - a);
        }

        public static void Genarri (ref int[] arr, ref int n, ref int a, ref int b)
        {
            Random r = new Random();
            for (int i = 0; i < n; i++)
                arr[i] = r.Next(a,b);
        }

        public static void Printer (ref double[] arr, ref int n, ref string output ,string s)
        {
            output += s + "\n";
            for (int i = 0; i < n; i++)
                output += ($"arr[{i}]={arr[i]} ");
        }

        public static void Printeri (ref int[] arr, ref int n, ref string output, string s)
        {
            output += s + "\n";
            for (int i = 0; i < n; i++)
                output += ($"arr[{i}]={arr[i]} ");
        }
    }
}
