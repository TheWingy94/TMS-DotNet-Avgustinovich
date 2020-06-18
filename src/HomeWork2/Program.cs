using System;
using System.Text;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Какую игру вы хотите? 1-StarWars\t2-Dota2 ");
            var a1 = Console.ReadLine();
            switch (a1)
            {
                case "1":
                    Console.WriteLine("Какую сторону ты выбирешь? 1-Тёмная\t2-Светлая ");
                    var a1_2 = Console.ReadLine();
                    switch (a1_2)
                    {
                        case "1":
                            Console.WriteLine("За кого вы будете играть? 1-Darth Wader\t2-Darth Maul ");
                            var a1_2_1 = Console.ReadLine();
                            switch (a1_2_1)
                            {
                                case "1":
                                    Console.WriteLine("Игра Star Wars\nТёмная Сторона\nГерой Darth Wader ");
                                    break;
                                case "2":
                                    Console.WriteLine("Игра Star Wars\nТёмная Стороная\nГерой Darth Maul");
                                    break;
                                default:
                                    Console.WriteLine("Error! ");
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("За кого вы будете играть? 1-Luke\t2-Han Solo ");
                            var a1_2_2 = Console.ReadLine();
                            switch (a1_2_2)
                            {
                                case "1":
                                    Console.WriteLine("Game is Star Wars\nBright Side\nHero - Luke ");
                                    break;
                                case "2":
                                    Console.WriteLine("Game is Star Wars\nBright Side\nHero - Han Solo ");
                                    break;
                                default:
                                    Console.WriteLine("Error!");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Error!");
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Какую сторону ты вибираешь? 1-Силы Тьмы\t2-Силы Света ");
                    var a2_2 = Console.ReadLine();
                    switch (a2_2)
                    {
                        case "1":
                            Console.WriteLine("За кого вы будете играть? 1-Spectre\t2-Wraith King ");
                            var a2_2_1 = Console.ReadLine();
                            switch (a2_2_1)
                            {
                                case "1":
                                    Console.WriteLine("Game is Dota 2\nDark Side\nHero - Spectre");
                                    break;
                                case "2":
                                    Console.WriteLine("Game is Dota 2\nDark Side\nHero - Wraith King ");
                                    break;
                                default:
                                    Console.WriteLine("Error");
                                    break;
                            }
                            break;
                        case "2":
                            Console.WriteLine("За кого вы будете играть? 1-Naga Sirena\t2-Bounty Hunter ");
                            var a2_2_2 = Console.ReadLine();
                            switch (a2_2_2)
                            {
                                case "1":
                                    Console.WriteLine("Game is Dota 2\nBright Side\nHero - Naga Sirena ");
                                    break;
                                case "2":
                                    Console.WriteLine("Game is Dota 2\nBright Side\nHero - Bounty Hunter ");
                                    break;
                                default:
                                    Console.WriteLine("Error");
                                    break;
                            }
                            break;
                        default:
                            Console.WriteLine("Error!");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
