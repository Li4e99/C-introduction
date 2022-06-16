using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите логин: ");
            var a = Console.ReadLine();
            Console.Write("Введите пароль: ");
            var b = Console.ReadLine();
            bool c = a == "admin";
            bool d = b == "admin";

            if (c && d )
            {
                Console.WriteLine("Привет, админ.");
            }
            else
            {
                Console.WriteLine("Привет, юзер.");
            }
            Console.ReadKey(true);
        }
    }
}
