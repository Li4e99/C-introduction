using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {

        static void Main(string[] args)
        {
            string Greetings = Properties.Settings.Default.GreetingsIntro;
            string UserName = Properties.Settings.Default.UserName;
            int UserAge = Properties.Settings.Default.UserAge;
            string UserJob = Properties.Settings.Default.UserJob;
            Console.WriteLine(Greetings);
            if (string.IsNullOrEmpty(Properties.Settings.Default.UserName))
            {
                Console.Write("Введите имя пользователя: ");
                Properties.Settings.Default.UserName = Console.ReadLine();
                Console.Write("Введите Ваш возраст: ");
                Properties.Settings.Default.UserAge = int.Parse(Console.ReadLine());
                Console.Write("Введите род Вашей деятельности: ");
                Properties.Settings.Default.UserJob = Console.ReadLine();
                Properties.Settings.Default.Save();
            }
            bool b = true;
            while (b)
            {
                Console.Write("Чтобы отобразить информацию о последнем пользователе введите 1.\n " +
                    "Чтобы ввести новые данные нажмите 2.\n Чтобы завершить работу приложения нажмите 0.\t");
                
                try
                {
                    int UserChoice = int.Parse(Console.ReadLine());
                    switch (UserChoice)
                    {
                        case 1:
                            Console.WriteLine($"Имя пользователя: {UserName}");
                            Console.WriteLine($"Возраст пользователя: {UserAge}");
                            Console.WriteLine($"Род деятельности пользователя: {UserJob}");
                            break;
                        case 2:
                            Console.Write("Введите имя пользователя: ");
                            Properties.Settings.Default.UserName = Console.ReadLine();
                            Console.Write("Введите Ваш возраст: ");
                            Properties.Settings.Default.UserAge = int.Parse(Console.ReadLine());
                            Console.Write("Введите род Вашей деятельности: ");
                            Properties.Settings.Default.UserJob = Console.ReadLine();
                            Properties.Settings.Default.Save();
                            break;
                        case 0:
                            b = false;
                            Console.WriteLine("Завершение работы приложения...");
                            Console.ReadKey(true);
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Некорректный ввод.");
                } 
                
               
            }
        



            }
    }
}
