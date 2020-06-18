using System;
using System.Text;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            //задать вопрос пользователю
            Console.WriteLine("Какую игру вы хотите? 1-StarWars \t2-Dota2");
            var a1 = Console.ReadLine();
            switch (a1)
            {
                case "1":
                    //
                    break;
                case "2":
                    //
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
