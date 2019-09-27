using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 1;
            Console.WriteLine("Введите А :");
            var A = Console.ReadLine();
            double a;
            while (!double.TryParse(A, out a))
            {
                Console.WriteLine("Ошибка ввода A!");
                A = Console.ReadLine();
            }
            a = Convert.ToDouble(A);
            Console.WriteLine("Введите N :");
            var N = Console.ReadLine();
            int n;
            while (!int.TryParse(N, out n))
            {
                Console.WriteLine("Ошибка ввода N!");
                N = Console.ReadLine();
            }
            n = Convert.ToInt32(N);
            for(int i = 0; i < n; i++)
            {
                d *= a;
            }
            Console.WriteLine($"Ответ: {d}");
        }
    }
}
