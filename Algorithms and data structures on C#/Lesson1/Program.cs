using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Program
    {
        /// <summary>
        /// Метод для задания № 1, написанный на основе блок-схемы, которая описывает алгоритм проверки, простое число или нет.
        /// </summary>
        /// <param name="n">Вводимое пользователем число</param>
        /// <returns></returns>
        static bool Task1 (long n)
        {
            int i = 2;
            int d = 0;
                while (i < n)
                {
                    if (n % i == 0)
                    {
                        d++;
                        i++;
                    }
                    else
                        i++;
                }
                if (d == 0)
                    return true;
                else
                    return false;
        }
        /// <summary>
        /// Вспопогательный класс для тестирования.
        /// </summary>
        public class TestCase
        {
            public long X { get; set; }
            public bool Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }
        /// <summary>
        /// Вспомогательный метод для тестирования
        /// </summary>
        /// <param name="testCase"> </param>
        static void Test(TestCase testCase)
        {
            try
            {
                bool actual = Task1(testCase.X);
                if (actual == testCase.Expected)
                {
                    Console.WriteLine("Простое число.");
                }
                else
                {
                    Console.WriteLine("Не простое число");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine("Ошибка.");
                }
                else
                {
                    Console.WriteLine("Нет ошибки");
                }
            }
        }
        /// <summary>
        /// Задание № 2. Посчитайте сложность функции.
        /// </summary>
        /// <param name="inputArray"> вводимый пользователем массив</param>
        /// <returns></returns>
        public static int StrangeSum(int[] inputArray) // Асимптотическая сложность функции - O(n^3).
        {
            int sum = 0;
            for (int i = 0; i < inputArray.Length; i++)
            {
                for (int j = 0; j < inputArray.Length; j++)
                {
                    for (int k = 0; k < inputArray.Length; k++)
                    {
                        int y = 0;
                        if (j != 0)
                        {
                            y = k / j;
                        }
                        sum += inputArray[i] + i + k + j + y;
                    }
                }
            }
            return sum;
        }
        /// <summary>
        /// Метод для вычисления числа Фиббоначи для заданного числа через цикл.
        /// </summary>
        /// <param name="n">Число</param>
        /// <returns>Результат вычисления</returns>
        static uint FibCycle(uint n)
        {
            uint a0 = 0;
            uint a1 = 1;
            uint a = a1;
            for (int i = 2; i <= n; i++)
            {
                a = a0 + a1;
                a0 = a1;
                a1 = a;
            }
            return a1;
        }

        /// <summary>
        /// Метод для вычисления числа Фиббоначи для заданного числа через рекурсию.
        /// </summary>
        /// <param name="n">Число</param>
        /// <returns>Результат вычисления</returns>
        static uint FibRecursion(uint n)
        {
            if (n == 0 || n == 1) return n;
            return FibRecursion(n - 1) + FibRecursion(n - 2);
        }

        /// <summary>
        /// Задание № 3. Требуется реализовать рекурсивную версию и версию без рекурсии (через цикл).
        /// </summary>
        static void Task3()
        {
            Console.Write("Введите число: ");
            uint n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Число Фиббоначи через цикл: {FibCycle(n)}");
            Console.WriteLine($"Число Фиббоначи через рекурсию: {FibRecursion(n)}");
            Console.ReadKey(true);
        }
        static void Main()
        {
            bool b = true;
            while (b)
            {
                    Console.WriteLine("============================================================================");
                    Console.Write("Введите номер задания от 1 до 3. Чтобы завершить работу программу введите 0: ");
                    int TaskNumber = int.Parse(Console.ReadLine());
                    switch (TaskNumber)
                    {
                        case 1:
                            Console.WriteLine("Задание № 1");
                        //Не знаю. зачем нужен этот тест, но сделал согласно ТЗ.
                        var testCase1 = new TestCase()
                            {
                            X = 2,
                            Expected = true,
                            ExpectedException = null
                            };
                        var testCase2 = new TestCase()
                            {
                                X = 1,
                                Expected = false,
                                ExpectedException = null
                            };
                        Console.WriteLine("Тестовые прогоны.");
                        //Тестовые прогоны
                        Console.Write("Тестовый прогон от числа 2...\t");
                        Test(testCase1);
                        Console.Write("Тестовый прогон от числа 1...\t");
                        Test(testCase2);
                        //Основная программа
                        Console.Write("Введите число: ");
                        if (Task1(long.Parse(Console.ReadLine())))
                                    Console.WriteLine("Число простое.");
                                else
                                    Console.WriteLine("Число не простое.");
                                Console.ReadKey(true);
                        Main();
                            break;
                        case 2:
                            Console.WriteLine("Задание № 2");
                            Console.WriteLine("Асимптотическая сложность функции - O(n ^ 3).");
                            GC.Collect();
                            Main();
                            break;
                        case 3:
                            Console.WriteLine("Задание № 3");
                            Task3();
                            GC.Collect();
                            Main();
                            break;
                        case 0:
                            b = false;
                            Console.WriteLine("Завершение работы приложения.");
                            Console.ReadKey(true);
                            Process.GetCurrentProcess().Kill();
                            break;
                        default:
                            Console.WriteLine("Вы ввели неправильный номер задания. Повторите попытку.");
                            GC.Collect();
                            Main();
                            break;
                    }
            }
        }
    }
}
