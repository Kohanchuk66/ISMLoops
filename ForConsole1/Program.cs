using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int d = 1;
            Console.WriteLine("Введите А :");
            var A = Console.ReadLine();
            int a;
            while (!int.TryParse(A, out a))
            {
                Console.WriteLine("Ошибка ввода A!");
                A = Console.ReadLine();
            }
            a = Convert.ToInt32(A);
            Console.WriteLine("Введите B :");
            var B = Console.ReadLine();
            int b;
            while (!int.TryParse(B, out b))
            {
                Console.WriteLine("Ошибка ввода B!");
                B = Console.ReadLine();
            }
            b = Convert.ToInt32(B);
            for (int i = a; i <= b; i++)
            {
                d = d*i;
            }
            Console.WriteLine("Ответ : ");
            System.Console.WriteLine($"{d}");
        }
    }
}
