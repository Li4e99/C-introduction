using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        /// <summary>
        /// Вспомогательный метод для ввода данных пользователя
        /// </summary>
        /// <returns>Возвращает ФИО для внесения в базу данных</returns>
        static string GetFullName(string firstname, string lastname, string patronymic)
        {
          return $"{firstname} {lastname} {patronymic}";
        }
        
        
        
        /// <summary>
        /// Вспомогательный метод для создания базы данных
        /// </summary>
        /// <returns> Возвращает массив данных </returns>
         static string [] CreateUsers()
         {

             Console.Write("Введите количество пользователей:");
             int count = Convert.ToInt32(Console.ReadLine());
             
             
             string[] Data = new string[count];
             for (int i = 0; i < Data.Length; i++)
             {
                Console.Write("Введите Вашу фамилию:");
                string firstname = Convert.ToString(Console.ReadLine());
                Console.Write("Введите Ваше имя: ");
                string lastname = Convert.ToString(Console.ReadLine());
                Console.Write("Введите Ваше отчество: ");
                string patronymic = Convert.ToString(Console.ReadLine());
                Data[i] = GetFullName(firstname, lastname, patronymic);
                Console.WriteLine("Пользователь сохранён.");
                Console.WriteLine("======================");
            }
            return Data;

         }
        /// <summary>
        /// Задание 1. Написать метод GetFullName(string firstName, string lastName, string patronymic),
        /// принимающий на вход ФИО в разных аргументах и возвращающий 
        /// объединённую строку с ФИО.Используя метод, написать программу, выводящую в консоль 3–4 разных ФИО.
        /// </summary>
         static void Task1()
      {
            string[] Data = CreateUsers();
            Console.WriteLine("Вывод базы данных:");
            for (int i = 0; i < Data.Length; i++)
            {
                Console.WriteLine($"{Data[i]}");
            }
            Console.ReadKey();
      }
        /// <summary>
        /// Задание 2. Написать программу, принимающую на вход строку — набор чисел, разделенных пробелом, и
        /// возвращающую число — сумму всех чисел в строке.Ввести данные с клавиатуры и вывести
        /// результат на экран
        /// </summary>
        static void Task2 ()
        {
            Console.Write("Введите набор чисел через пробел: ");
            string input = Convert.ToString(Console.ReadLine());
            string[] numbers = input.Split();
            int sum = default;
            for (int i = 0; i<numbers.Length; i++)
            {
                sum += int.Parse(numbers[i]);
            }

            Console.WriteLine($"Сумма введенных чисел: {sum} ");

        }
       
        enum Season
        {
            Winter,
            Spring,
            Summer,
            Autumn,
            Error
            
        }
         /// <summary>
         /// Метод по определению времени года. На вход подаётся число – порядковый номер месяца.
         /// <summary>
         /// <returns>значение из перечисления(enum) — Winter, Spring, Summer,Autumn</returns>
        static Season Season1 (int SeasonNumber)
        {
            if (SeasonNumber == 12|| SeasonNumber == 1 || SeasonNumber == 2)
            {
                return Season.Winter;
            }
            if (SeasonNumber == 3 || SeasonNumber == 4 || SeasonNumber == 5)
            {
                return Season.Spring;
            }
            if (SeasonNumber == 6 || SeasonNumber == 7 || SeasonNumber == 8)
            {
                return Season.Summer;
            }
            if (SeasonNumber == 9 || SeasonNumber == 10 || SeasonNumber == 11)
            {
                return Season.Autumn;
            }
            return Season.Error;

        }
        /// <summary>
        /// Метод, принимающий на вход значение из этого перечисления
        /// </summary>
        /// <returns>Название времени года(зима, весна, лето, осень).</returns>
        static string Season2 (Season Name)
        {
            if (Name == Season.Winter)
            {
                return "Сейчас зима.";
            }
            if (Name == Season.Spring)
            {
                return "Сейчас весна.";
            }
            if (Name == Season.Summer)
            {
                return "Сейчас лето.";
            }

            if (Name == Season.Autumn)
            {
                return "Сейчас осень.";
            }
                return "Ошибка: введите число от 1 до 12.";
        }
        /// <summary>
        /// Задание 3. Написать метод по определению времени года. На вход подаётся число – порядковый номер месяца.
        /// На выходе — значение из перечисления(enum) — Winter, Spring, Summer, Autumn.
        /// Написать метод, принимающий на вход значение из этого перечисления и возвращающий название времени года(зима, весна, лето, осень). 
        /// Используя эти методы, ввести с клавиатуры номер месяца и вывести название времени года.
        /// Если введено некорректное число, вывести в консоль текст «Ошибка: введите число от 1 до 12»
        /// </summary>
        static void Task3()
        {
            bool a = true;
            while (a)
            {
                Console.Write("Введите порядковый номер месяца. Введите 0 для завершения программы: ");

                int SeasonNumber = int.Parse(Console.ReadLine());
                if (SeasonNumber == 0)
                {
                    a = false;
                    Console.WriteLine("Переход в главное меню...");
                    return;
                }
                Season season = Season1(SeasonNumber);
                Console.WriteLine($"{Season2(season)}");
            }
                Console.ReadKey();
        }
        static void Main(string[] args)
        {
            bool b = true;
            while (b)
            {
                Console.WriteLine("=======================================");
                Console.Write("Введите номер задания от 1 до 3. Чтобы завершить работу программу введите 0: ");
                int TaskNumber = Convert.ToInt32(Console.ReadLine());
                switch (TaskNumber)
                {
                    case 1:
                        Console.WriteLine("Задание № 1");
                        Task1();
                        break;
                    case 2:
                        Console.WriteLine("Задание № 2");
                        Task2();
                        break;
                    case 3:
                        Console.WriteLine("Задание № 3");
                        Task3();
                        break;
                    case 0:
                        b = false;
                        Console.WriteLine("Завершение работы приложения.");
                        break;
                    default:
                        Console.WriteLine("Вы ввели неправильный номер задания. Повторите попытку.");
                        break;
                }
            }
        }
    }
    
}
