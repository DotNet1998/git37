using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: #");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите степень: #");
            int y = int.Parse(Console.ReadLine());
            Stepen(x, y);
            Console.WriteLine("Результат : " + Stepen(x, y));

        }
        public static int Stepen(int x, int y)
        {
            int res = 1;
            for (int i = 0; i < y; i++)
            {
                res *= x;
            }
            return res;
        }
    }
}

