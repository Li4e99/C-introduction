using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите имя пользователя:");
            string UserName = Console.ReadLine(); // Сохраняем имя пользователя в переменную.
            DateTime myDate = DateTime.Now; // Сохраняем в переменную текущие дату и время.
               Console.WriteLine ($"Привет, {UserName}, сегодня {myDate}.");
        }
    }
}
