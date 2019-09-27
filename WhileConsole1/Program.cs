using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите N :");
            var N = Console.ReadLine();
            int n;
            while (!int.TryParse(N, out n))
            {
                Console.WriteLine("Ошибка ввода N!");
                N = Console.ReadLine();
            }
            n = Convert.ToInt32(N);
            int k = 1;
            while(Math.Pow(3, k) <= n)
            {
                k++;
            }
            Console.WriteLine($"Ответ: {k}");
        }
    }
}
