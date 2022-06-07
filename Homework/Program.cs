using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {

       
        
        static void Main(string[] args)
        {
            bool f = true;

            while (f)
            {
                Console.Clear();
                Console.WriteLine($"Домашняя работа. Урок 1");
                Console.WriteLine($"Студент: Ануров Артемий Владимирович");
                Console.WriteLine("=====================================");
                Console.WriteLine("Мои задачи");
                Console.WriteLine("=================================");
                Console.WriteLine("1 -> Задача 1");
                Console.WriteLine("2 -> Задача 2");
                Console.WriteLine("3 -> Задача 3");
                Console.WriteLine("5 -> Задача 5");
                Console.WriteLine("0 -> Завершение работы приложения");
                Console.WriteLine("=================================");
                Console.WriteLine();
                Console.Write("Введите номер задачи: ");
                int number = int.Parse(Console.ReadLine());

                switch (number)
                {
                    case 0:
                        f = false;
                        Console.WriteLine("Завершение работы приложения ...");
                        break;
                    case 1:
                        Work1();
                        break;
                    case 2:
                        Work2();
                        break;
                    case 3:
                        Work3();
                        break;
                    /*case 4:
                        Work4();
                        break;
                    */
                    case 5:
                        Work5();
                        break;
                    default:
                        Console.WriteLine("Некорректный номер задачи.\nПовторите ввод.");
                        break;
                }
            }

            Console.ReadKey();

        }


        #region Первое задание
        static void Work1() //Задание 1: Программа "Анкета"
        
        {
            Console.WriteLine("Ваше имя? ");
            string name = Console.ReadLine();
            Console.WriteLine("Ваша фамилия? ");
            string secondName = Console.ReadLine();
            Console.WriteLine("Ваш возраст? ");
            string age = Console.ReadLine();
            Console.WriteLine("Ваш рост? ");
            string height = Console.ReadLine();
            Console.WriteLine("Ваш вес? ");
            string weight = Console.ReadLine();

            Console.WriteLine("Имя-" + name + ", фамилия-" + secondName + ", возраст-" + age + ", рост-" + height + ", вес-" + weight + ".");
            Console.WriteLine("Имя-{0}, фамилия-{1}, возраст-{2}, рост-{3}, вес-{4}.", name, secondName, age, height, weight );
            Console.WriteLine($"имя-{name}, фамилия-{secondName}, возраст-{age}, рост-{height}, вес-{weight}.");
            Console.ReadLine();

        }
        #endregion 

        #region Второе задание
        static void Work2() //Задание 2: Расчет и вывод ИМТ
        {
            Console.WriteLine("Введите свой рост в см?");
            string height = Console.ReadLine();
            double h = Convert.ToDouble(height);
            
            Console.WriteLine("Введите свой вес в кг?");
            string weignt = Console.ReadLine();
            double m = Convert.ToDouble(weignt);

            h = h / 100;
            double i = m / (h * h);
            
            Console.WriteLine("Ваш Индекс массы тела составляет: {0}", i);
            Console.ReadLine();

        }
#endregion

        #region Третье задание
        static void Work3() //Задание 3: Программа для подсчета расстояния между двумя точками
        {
            Console.WriteLine("Введите координату x1 ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y1 ");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату x2 ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координату y2 ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            Console.WriteLine($"{r:F2}");
            Console.ReadLine();

        }
        #endregion

        #region Четвертое задание
        static void Work4() //Задание 4: программа обмена значениями двух переменных 
        {
            //Под буквой "а" - с использованием третьей переменной
            int a = 10;
            int b = 15;
            int c = a;
            a = b;
            b = c;

            //Под буквой "б" - бес использования третьей переменной
            int x = 3;
            int y = 5;
            x = x + y;
            y = y - x;
            y = -y;
            x = x - y;


        }
        #endregion

        #region Пятое задание
        static void Work5() // Задание 5: программа для запроса и вывода данных по центру экрана
        {
            
            Console.Clear();
            Console.WriteLine("Введите ваше имя ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите вашу фамилию ");
            string secondName = Console.ReadLine();
            Console.WriteLine("Введите ваш город проживания ");
            string city = Console.ReadLine();
            Console.Clear();
            
            string hello = "Здравсвуйте,";
            string from = "из города";

            int centerX = (Console.WindowWidth / 2) - (hello.Length / 2) - (from.Length / 2) - (name.Length / 2) - (secondName.Length / 2) - (city.Length / 2);
            int centerY = (Console.WindowHeight / 2) - 1;
            Console.SetCursorPosition(centerX, centerY);
            Console.Write($"{hello} {name} {secondName} {from} {city}!");

            Console.ReadKey();

        }
        #endregion
    }
}
