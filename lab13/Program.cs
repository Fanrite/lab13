using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using Hlp;
using Inputdata;
using Sora;
using System.Diagnostics;


namespace lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10, v = 1;
            bool flag = true;
            while (flag)
            {
                string output = "";
                string time = "";

                Input.Inint(ref v, "Виберіть номер завдвння (1-5:)");
                if (v != 1 && v != 2 && v != 3 && v != 4 && v != 5)
                   MessageBox.Show("Ви не ввели варіанта", "Завершення", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (v == 1)
                {
                    double a = 10, b = 40;
                    Input.Inint(ref n, "Введіть кількість елементів:");
                    double[] arr = new double[n];
                    Hlp1.Genarrd(ref arr, ref n, ref a, ref b);
                    Hlp1.Printer(ref arr, ref n, ref output, "Початковий массив:");
                    Sorano.Buble(ref arr, ref n, ref time);
                    Hlp1.Printer(ref arr, ref n, ref output, "\nКінцевий бульбашуовий массив:");
                    output += time;
                }

                if (v == 2)
                {
                    int a = 10, b = 40;
                    Input.Inint(ref n, "Введіть кількість елементів:");
                    int[] arr = new int[n];
                    Hlp1.Genarri(ref arr, ref n, ref a, ref b);
                    Hlp1.Printeri(ref arr, ref n, ref output, "Початковий массив:");
                    Sorano.Bublei(ref arr, ref n, ref time);
                    Hlp1.Printeri(ref arr, ref n, ref output, "\nКінцевий бульбашуовий массив:");
                    output += time;
                }

                if (v == 3)
                {
                    double a = 10, b = 40;
                    Input.Inint(ref n, "Введіть кількість елементів:");
                    double[] arr = new double[n];
                    Hlp1.Genarrd(ref arr, ref n, ref a, ref b);
                    Hlp1.Printer(ref arr, ref n, ref output, "Початковий массив:");
                    Sorano.P1(ref arr, ref n, ref time);
                    Hlp1.Printer(ref arr, ref n, ref output, "\nКінцевий прямого включення массив:");
                    output += time;
                }

                if (v == 4)
                {
                    double a = 10, b = 40;
                    Input.Inint(ref n, "Введіть кількість елементів:");
                    double[] arr = new double[n];
                    Hlp1.Genarrd(ref arr, ref n, ref a, ref b);
                    Hlp1.Printer(ref arr, ref n, ref output, "Початковий массив:");
                    Sorano.P2(ref arr, ref n, ref time);
                    Hlp1.Printer(ref arr, ref n, ref output, "\nКінцевий прямого вибору массив:");
                    output += time;
                }

                if (v == 5)
                {
                    double a = 10, b = 40;
                    Input.Inint(ref n, "Введіть кількість елементів:");
                    double[] arr = new double[n];
                    Hlp1.Genarrd(ref arr, ref n, ref a, ref b);
                    Hlp1.Printer(ref arr, ref n, ref output, "Початковий массив:");
                    var sw = new Stopwatch();
                    sw.Start();
                    Sorano.P3(ref arr, 0, n -1);
                    sw.Stop();
                    time = $"\nЧас виконання:{sw.Elapsed}";
                    Hlp1.Printer(ref arr, ref n, ref output, "\nКінцевий швидкого сортування обміном навеликих відстанях массив:");
                    output += time;
                    Hlp1.Genarrd(ref arr, ref n, ref a, ref b);
                    Hlp1.Printer(ref arr, ref n, ref output, "Початковий массив:");
                    Sorano.Standart(ref arr, ref time);
                    Hlp1.Printer(ref arr, ref n, ref output, "\nКінцевий сортування стандартним методом массив:");
                    output += time;
                }

                //exit or begin 
                if (MessageBox.Show(output + "\n\nПовторити?", "Результат", MessageBoxButtons.YesNo) == DialogResult.No)
                    flag = false;
            }
        }
    }
}
