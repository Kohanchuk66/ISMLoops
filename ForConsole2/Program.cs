using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 0;
            Console.WriteLine("Введите N :");
            var N = Console.ReadLine();
            int n;
            while (!int.TryParse(N, out n))
            {
                Console.WriteLine("Ошибка ввода N!");
                N = Console.ReadLine();
            }
            n = Convert.ToInt32(N);
            for(int i = 1; i<=n; i++)
            {
                d += (double)1/i;
            }
            Console.WriteLine($"Ответ: {d}");
        }
    }
}
