using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 1;
            double s = 10;
            Console.WriteLine("Введите P :");
            var P = Console.ReadLine();
            double p;
            while (!double.TryParse(P, out p))
            {
                Console.WriteLine("Ошибка ввода P!");
                P = Console.ReadLine();
            }
            p = Convert.ToDouble(P);
            while (s <= 200)
            {
                s += s * p / 100;
                k++;
            }
            Console.WriteLine($"Количество дней: {k} Суммарный пробег: {s}");
        }
    }
}
