using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6
{
    class Program
    {
        /// <summary>
        /// Задание 1. Написать консольное приложение Task Manager, которое выводит на экран запущенные процессы и 
        /// позволяет завершить указанный процесс.Предусмотреть возможность завершения процессов с
        /// помощью указания его ID или имени процесса.В качестве примера можно использовать консольные
        /// утилиты Windows tasklist и taskkill
        /// </summary>
        static void Task1 ()
        {
            Console.WriteLine("Нажмите любую клавишу для вывода всех запущенных процессов: ");
            Console.ReadKey(true);
            Console.WriteLine("Имя процесса\t ID");
            Process[] GetProcess = Process.GetProcesses();
            foreach (Process Process in GetProcess)
            {
               Console.WriteLine($"{Process.ProcessName}\t {Process.Id}");
            }
            Console.Write("Введите название процесса или его ID для завершения процесса: ");
            var UserChoice = Console.ReadLine();

            try
            {
                GetProcess.First(p => p.ProcessName == UserChoice || p.Id == Convert.ToInt32(UserChoice)).Kill();
                Console.WriteLine($"Процесс {UserChoice} завершен");
                Console.ReadKey();
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine($"Процесс {UserChoice} не найден.");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Некорректный ввод.");
            }
        }
        static void Main(string[] args)
        {
            bool b = true;
            while (b)
            {
                Console.WriteLine("=======================================");
                Console.Write("Для вызова диспетчера задач введите 1. Чтобы завершить работу приложения введите 0: ");
                int TaskNumber = Convert.ToInt32(Console.ReadLine());
                switch (TaskNumber)
                {
                    case 1:
                        Console.WriteLine("Диспетчер задач");
                        Task1();
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
