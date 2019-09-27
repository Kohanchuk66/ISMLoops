using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            Console.WriteLine("Введите N :");
            var N = Console.ReadLine();
            int n;
            while (!int.TryParse(N, out n))
            {
                Console.WriteLine("Ошибка ввода N!");
                N = Console.ReadLine();
            }
            n = Convert.ToInt32(N);
            Console.WriteLine("Введите K :");
            var K = Console.ReadLine();
            int k;
            while (!int.TryParse(K, out k))
            {
                Console.WriteLine("Ошибка ввода K!");
                K = Console.ReadLine();
            }
            k = Convert.ToInt32(K);
            for(int i = 1; i <= n; i++)
            {
               sum+= Math.Pow(i, k);
            }
            Console.WriteLine($"Ответ: {sum}");
        }
    }
}
