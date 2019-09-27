using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole6
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
            int k = n;
            for(int i = 1; i <= n; i++)
            {
                sum+= Math.Pow( i, k);
                if (k == 1) continue;
                k--;
            }
            Console.WriteLine($"Ответ: {sum}");
        }
    }
}
