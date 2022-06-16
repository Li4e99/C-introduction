using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        /// <summary>
        /// Задание 1.Написать программу, выводящую элементы двухмерного массива по диагонали.
        /// </summary>
        static void Task1()
        {
            int[,] array1 = { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 } };
            int space = 0;
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    Console.WriteLine($"{new string (' ', space)} {array1[i, j]}"); //всю голову сломал, как сделать на следующей строке пробел в цикле :( 
                    space++; //если честно, нагуглил эти 2 строчки, если не сложно, дайте, пожалуйста, пояснение по двум строчкам этим. Конкретно непонятно как работает вот это {new string (' ', space)} space++. Заранее спасибо.
                }
            }
        }

        /// <summary>
        /// Задание 2. Написать программу — телефонный справочник — создать двумерный массив 5*2, хранящий 
        /// список телефонных контактов: первый элемент хранит имя контакта, второй — номер/e-mail.
        /// </summary>
        static void Task2()
        {
            string [,] phones = new string[5, 2];
            phones [0,0] = "Иванов Иван Иванович";
            phones[0, 1] = "111111";
            phones[1, 0] = "Петров Петр Петрович";
            phones[1, 1] = "222222";
            phones[2, 0] = "Николаев Николай Николаевич";
            phones[2, 1] = "333333";
            phones[3, 0] = "Алексеев Алексей Алексеевич";
            phones[3, 1] = "444444";
            phones[4, 0] = "Андреев Андрей Андреевич";
            phones[4, 1] = "555555";
            bool a = true;
            while (a)
            { 
            Console.WriteLine("============================================");
            Console.Write("Введите порядковый номер абонента от 1 до 5. \nВведите 6 для показа всей телефонной книги. \nНажмите 0 для завершения работы справочника. ");
            int Call = int.Parse(Console.ReadLine());
                switch (Call)
                {
                    case 6:
                        for (int i = 0; i < phones.GetLength(0); i++)
                        {
                            for (int j = 0; j < phones.GetLength(1); j++)
                            {
                                Console.Write($"{phones[i, j]}\t");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 0:
                        a = false;
                        Console.WriteLine("Завершение работы справочника.");
                        break;
                    case 1:
                        Console.WriteLine($"{phones[0, 0]}\t {phones[0, 1]}");
                        break;
                    case 2:
                        Console.WriteLine($"{phones[1, 0]}\t {phones[1, 1]}");
                        break;
                    case 3:
                        Console.WriteLine($"{phones[2, 0]}\t {phones[2, 1]}");
                        break;
                    case 4:
                        Console.WriteLine($"{phones[3, 0]}\t {phones[3, 1]}");
                        break;
                    case 5:
                        Console.WriteLine($"{phones[4, 0]}\t {phones[4, 1]}");
                        break;
                    default:
                        Console.WriteLine("Вы ввели неправильный порядковый номер. Повторите попытку.");
                        break;

                }
            }
            

        }
        /// <summary>
        /// Задание 3.Написать программу, выводящую введенную пользователем строку в обратном порядке.
        /// </summary>
        static void Task3()
        {
            Console.Write("Введите любую фразу: ");
            string greeting = Console.ReadLine();
            for (int i = greeting.Length-1; i >=0; i--)
            {
                Console.Write($"{greeting[i]}");
            }
        }
        
        static void Main()
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
