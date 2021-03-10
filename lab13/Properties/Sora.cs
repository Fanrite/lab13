using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Sora
{
    class Sorano
    {
        public static void Buble (ref double[] arr, ref int n , ref string time)
        {
            double elem;
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < n -1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j+1])
                    {
                        elem = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = elem;
                    }
            sw.Stop();
            time = $"\nЧас виконання:{sw.Elapsed}";     
        }

        public static void Bublei (ref int[] arr, ref int n, ref string time)
        {
            int elem;
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        elem = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = elem;
                    }
            sw.Stop();
            time = $"\nЧас виконання:{sw.Elapsed}";
        }

        public static void P1 (ref double[] arr, ref int n, ref string time)
        {
            double elem;
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < n; i++)
            {
                int j = 0;
                elem = arr[i];
                while (j < i && arr[j] < arr[i])
                    j++;
                if (j<i)
                {
                    for (int k = i - 1; k >= j; k--)
                        arr[k + 1] = arr[k];
                    arr[j] = elem;
                }
            }
            sw.Stop();
            time = $"\nЧас виконання:{sw.Elapsed}";
        }

        public static void P2 (ref double[] arr, ref int n, ref string time)
        {
            int indx;
            double elem;
            var sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < n - 1; i++)
            {
                elem = arr[i];
                indx = i;
                for (int j = i + 1; j < n; j++)
                    if (arr[j] < elem)
                    {
                        elem = arr[j];
                        indx = j;
                    }
                if (indx > i)
                {
                    arr[indx] = arr[i];
                    arr[i] = elem;
                }
            }
            sw.Stop();
            time = $"\nЧас виконання:{sw.Elapsed}";
        }

        public static void Standart (ref double[] arr, ref string time)
        {
            var sw = new Stopwatch();
            sw.Start();
            Array.Sort(arr);
            sw.Stop();
            time = $"\nЧас виконання:{sw.Elapsed}";
        }

        public static void P3 (ref double[] arr, int i, int j)
        {
            if (i >= j) return;
            double elem = arr[i];
            int i1 = i, j1 = j;
            while (i1 < j1)
            {
                while (j1 > i1 && arr[j1] >= elem)
                    j1--;
                if (i1 < j1)
                {
                    arr[i1] = arr[j1];
                    arr[j1] = elem;
                    i1++;
                }
                while (i1 < j1 && arr[i1] <= elem)
                    i1++;
                if (i1 < j1)
                {
                    arr[j1] = arr[i1];
                    arr[i1] = elem;
                    j1--;
                }
            }
            P3(ref arr, i, i1 - 1);
            P3(ref arr, i1 + 1, j);  
        }
    }
}
