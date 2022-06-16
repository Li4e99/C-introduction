using System;
using System.IO;
using System.Text.Json;
using System.IO.Compression;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program
    {
        /// <summary>
        /// Задание № 1. Ввести с клавиатуры произвольный набор данных и сохранить его в текстовый файл.
        /// </summary>
        static void Task1()
        {
            Console.Write("Введите текст: ");
            var userInput = Console.ReadLine();
            string fileName = "task1.txt";
            File.WriteAllText(fileName, userInput);
            Console.WriteLine($"Текст сохранен в файл {fileName}");

        }
        /// <summary>
        /// Задание № 2. Написать программу, которая при старте дописывает текущее время в файл «startup.txt».
        /// </summary>
        static void Task2()
        {
            string fileName = "startup.txt";
            DateTime dateTime = DateTime.Now;
            File.AppendAllText(fileName, Convert.ToString(dateTime));
            Console.WriteLine($"В файл {fileName} добавлено текущее время.");
            File.AppendAllText(fileName, Environment.NewLine);
            Console.ReadLine();
        }
        /// <summary>
        /// Задание № 3. Ввести с клавиатуры произвольный набор чисел (0...255) и записать их в бинарный файл.
        /// </summary>
        static void Task3()
        {
            Console.Write("Введите числа от 0...255 через пробел: ");
            char[] separator = new char[] { ' ' };
            string[] InputArr = Console.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
            byte[] ByteArr = new byte[InputArr.Length];
            for (int i = 0; i < ByteArr.Length; i++)
            {
                try
                {
                    ByteArr[i] = Convert.ToByte(InputArr[i]);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели неверный формат данных.");
                }
            }
            File.WriteAllBytes("bytes.bin", ByteArr);

        }
        
        /// <summary>
        /// Вспомогательный метод для задания 4, который строит дерево файлов и папок в указанной пользователем директории.
        /// </summary>
        /// <param name="dir"> указанная директория</param>
        /// <param name="indent"> отступ </param>
        /// <param name="lastDirectory"> проверка на конечность директории</param>
        static void PrintDir1 (DirectoryInfo dir, string indent, bool lastDirectory)
        {
            Console.Write(indent);
            Console.Write(lastDirectory ? "└─" : "├─");
            indent += lastDirectory ? " " : "│ ";
            Console.WriteLine(dir.Name);

            FileInfo [] subFiles = dir.GetFiles();

            DirectoryInfo [] subDirs = dir.GetDirectories();
            
            for (int i = 0; i < subDirs.Length; i++)
            {
                PrintDir1(subDirs[i], indent, i == subDirs.Length - 1);
                

                for (int j = 0; j < subFiles.Length; j++)
                {
                    Console.Write(indent);
                    Console.Write(lastDirectory ? "└─" : "├─");
                    Console.WriteLine(subFiles[j]);
                }

            }
            
        }

        /// <summary>
        /// Задание 4. Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с рекурсией и без. 
        /// (на 2 вариант не хватило времени :( )
        /// </summary>
        static void Task4()
        {
            Console.Write("Укажите путь к необходимой директории: ");
            string dir = Console.ReadLine();
            PrintDir1(new DirectoryInfo ($@"{dir}"), "", true);
            // Не смог реализовать вывод в файл. Понимаю, что для записи в текстовый файл
            // метод должен быть string [], но реализовать так, чтобы все работало, не получилось.                

        }

        static void Main(string[] args)
        {
            bool b = true;
                while (b)
                {
                    Console.WriteLine("=======================================");
                    Console.Write("Введите номер задания от 1 до 4. Чтобы завершить работу программу введите 0: ");
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
                        case 4:
                            Console.WriteLine("Задание № 4");
                            Task4();
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
