using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        /// <summary>
        /// Метод для расчета среднесуточной температуры
        /// </summary>
        static void Task1()
        {
            Console.WriteLine("Пожалуйста, введите минимальную температуру сегодня: ");
            double Min_T = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите максимальную температуру сегодня: ");
            double Max_T = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Средняя температура сегодня - {(Min_T + Max_T) / 2} ");
            Console.ReadKey();

        }
        /// <summary>
        /// Метод для определения наименования месяца, порядковый номер которого запросил пользователь
        /// </summary>
        static void Task2()
        {
            Console.WriteLine("Пожалуйста, введите порядковый номер текущего месяца: ");
            int Months = Convert.ToInt32(Console.ReadLine());

            switch (Months)
            {
                case 1:
                    Console.WriteLine("Сейчас за окном Январь.");
                    Task5();
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Сейчас за окном Февраль.");
                    Task5();
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Сейчас за окном Март. Весна пришла! :(");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Сейчас за окном Апрель. Вы не забыли пошутить надо друщьями 1-го числа?");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Сейчас за окном Май. С праздником труда и Великой победы!");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Сейчас за окном Июнь. Первый месяц лета!");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine("Сейчас за окном Июль. Уже были в отпуске?");
                    Console.ReadKey();
                    break;
                case 8:
                    Console.WriteLine("Сейчас за окном Август. Последний месяц лета. Надеюсь, Вы отдохнули на море!");
                    Console.ReadKey();
                    break;
                case 9:
                    Console.WriteLine("Сейчас за окном Сентябрь. Хорошо, что уже не надо в школу :)");
                    Console.ReadKey();
                    break;
                case 10:
                    Console.WriteLine("Сейчас за окном Октябрь. Дожди и серость за окном, но Вы держитесь :)");
                    Console.ReadKey();
                    break;
                case 11:
                    Console.WriteLine("Сейчас за окном Ноябрь. Когда уже лето?");
                    Console.ReadKey();
                    break;
                case 12:
                    Console.WriteLine("Сейчас за окном Декабрь.");
                    Task5();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильный номер месяца. Напоминаю, их всего 12 :) Попробуйте снова :)");
                    Task2();
                    break;
            }
        }
        static void Task3()
        {
            Console.WriteLine("Пожалуйста, введите число: ");
            int UserNumber = Convert.ToInt32(Console.ReadLine());
            if ((UserNumber % 2) == 0) Console.WriteLine("Число четное.");
            else Console.WriteLine("Число нечетное.");
            Console.ReadKey();
        }
        /// <summary>
        /// Метод для генерирования чека. Сделал примитивный вариант работы "а-ля считыватель штрихкода", но без обращения к БД.
        /// Пользователь (кассир) вводит стоимость 1 товара, потом второго, получает чек с суммой.
        /// </summary>
        static void Task4()
        {
            string IE_name = "ООО ГикБрейнс"; //Наименование ИП
            string Address = "25167, г. Москва, Ленинградский проспект, д.39, \nстр.79 этаж 23, помещение XXXIV, часть комнаты 1"; // Юридический адресс
            string Cashier = "Касса № 1";
            string Cashier_Fullname = "Иванов Иван Иванович"; // ФИО кассира
            Console.WriteLine("Введите стоимость первого товара: ");
            double buy1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите стоимость второго товара: ");
            double buy2 = Convert.ToDouble(Console.ReadLine());
            double sum = Convert.ToDouble(buy1 + buy2); //сумма покупок
            Console.WriteLine("=======================================");
            Console.WriteLine(IE_name);
            Console.WriteLine(Address);
            Console.WriteLine(Cashier);
            Console.WriteLine($"Ф.И.О. кассира {Cashier_Fullname}");
            Console.WriteLine($"Стоимость товара № 1 = {buy1} рублей.");
            Console.WriteLine($"Стоимость товара № 2 = {buy2} рублей.");
            Console.WriteLine($"Сумма Вашей покупки {sum} рублей.");
            Console.WriteLine("Спасибо за покупки! Ждем Вас снова!");
            Console.WriteLine("=======================================");
            Console.ReadKey();
        }
        static void Main()
        {
            Console.WriteLine("=======================================");
            Console.Write("Введите номер задания от 1 до 5. Чтобы завершить работу программу введите 0: ");
            int TaskNumber = Convert.ToInt32(Console.ReadLine());
            switch (TaskNumber)
            {
                case 1:
                    Console.WriteLine("Задание № 1");
                    Task1();
                    Main();
                    break;
                case 2:
                    Console.WriteLine("Задание № 2+*");
                    Task2();
                    Main();
                    break;
                case 3:
                    Console.WriteLine("Задание № 3");
                    Task3();
                    Main();
                    break;
                case 4:
                    Console.WriteLine("Задание № 4");
                    Task4();
                    Main();
                    break;
                case 5:
                    Console.WriteLine("Задание № 5(6) на битовые маски");
                    Task6();
                    Main();
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("Вы ввели неправильный номер задания. Повторите попытку.");
                    Main();
                    break;

            }

        }
        /// <summary>
        /// Вспомогательный метод для задания № 2 
        /// для выполнения условия № 5 со звездочкой
        /// </summary>
        static void Task5()
        {
            Console.WriteLine("Пожалуйста, введите минимальную температуру загаданного месяца: ");
            double Min_T = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Пожалуйста, введите максимальную температуру загаданного месяца: ");
            double Max_T = Convert.ToDouble(Console.ReadLine());
            if ((Min_T + Max_T) / 2 > 0)
                Console.WriteLine($"Дождливая зима.");
            else
                Console.WriteLine("На улице холодно. Не забудьте надеть шапку :)");
        }
        [FlagsAttribute]
       
        public enum DaysOfWeek
        {
            Monday = 0b_0000_0001,
            Tuesday = 0b_0000_0010,
            Wednesday = 0b_0000_0100,
            Thursday = 0b_0000_1000,
            Friday = 0b_0001_0000,
            Saturday = 0b_0010_0000,
            Sunday = 0b_0100_0000,
        }

       /// <summary>
       /// Метод представляющий выборку рабочих дней для выбранного офиса
       /// </summary>
        static void Task6()
        {
            //Маска рабочих дней офисов
            DaysOfWeek Office1 = DaysOfWeek.Monday | DaysOfWeek.Tuesday | DaysOfWeek.Friday | DaysOfWeek.Saturday;
            DaysOfWeek Office2 = DaysOfWeek.Wednesday | DaysOfWeek.Thursday | DaysOfWeek.Saturday | DaysOfWeek.Sunday;
            DaysOfWeek WorkingDays = (DaysOfWeek)0b_0111_1111; // Дни работы компании в числовой записи
            DaysOfWeek Office1Ready = Office1 & WorkingDays;
            DaysOfWeek Office2Ready = Office2 & WorkingDays;
            Console.WriteLine("=======================================");
            Console.Write("Выберите офис №1 или № 2: ");
            int Office = Convert.ToInt32(Console.ReadLine());
            if (Office == 1)
                Console.WriteLine($"График работы офиса № 1: {Office1Ready}");
            if (Office == 2)
                Console.WriteLine($"График работы офиса № 2: {Office2Ready}");
            Console.ReadKey();
        }
    }
}