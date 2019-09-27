using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 1,sum=0;
            Console.WriteLine("Введите N :");
            var N = Console.ReadLine();
            int n;
            while (!int.TryParse(N, out n))
            {
                Console.WriteLine("Ошибка ввода N!");
                N = Console.ReadLine();
            }
            n = Convert.ToInt32(N);
            for(int i = 1; i <= n ; i++)
            {
                d *= i;
                sum += d;
            }
            Console.WriteLine($"Ответ: {sum}");
        }
    }
}
