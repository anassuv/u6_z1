using System;

namespace Z
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Сколько чисел вы хотите ввести: ");
            int m = Int32.Parse(Console.ReadLine());
            int k = 0;
            for (int i = 0; i < m; i++)
            {
                Console.Write("Введите {0}-e число: ", i + 1);
                int x = Int32.Parse(Console.ReadLine());
                if (x > 0) k++;                
            }
            Console.WriteLine("Чисел больше нуля: {0}", k);
            Console.ReadKey();
        }
    }
}