using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Выберите игру\n" +
                    "1 - Угадай число\n" +
                    "2 - Таблица умножения\n" +
                    "3 - Делители числа");

                switch (Console.ReadLine())
                {
                    case "1":
                        {
                            Console.Clear();
                            Console.WriteLine("Угадайте загаданное число от 0 до 100");
                            Random rand = new Random();

                            int game_number = rand.Next(0, 100);

                            while (true)
                            {
                                int user_number = Convert.ToInt32(Console.ReadLine());
                                if (user_number > game_number)
                                {
                                    Console.WriteLine("Загаданное число меньше вашего");
                                }
                                else if (user_number == game_number)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Вы победили!!!");
                                    Console.ReadKey();
                                    break;
                                }
                                else if (user_number < game_number)
                                {
                                    Console.WriteLine("Загаданное число больше вашего");
                                }
                            }
                        }
                        break;

                    case "2":
                        {
                            Console.Clear();
                            Console.WriteLine("Таблица умножения");


                            Console.ReadLine();
                        }
                        break;

                    case "3":
                        {
                            Console.Clear();
                            Console.Write("Введи число ");
                            int number = Convert.ToInt32(Console.ReadLine());

                            for (int a = 1; a <= number; a++)
                            {
                                if (number % a == 0)
                                {
                                    Console.Write("{0}  ", a);
                                }
                            }
                            Console.ReadLine();
                        }
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
