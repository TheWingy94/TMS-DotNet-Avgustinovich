using System;
using System.Security.Cryptography;

namespace HomeWork_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //пользователю нужно сообщить о введении операции
            Console.Write("Введите номер дня недели(от 1 до 7): ");
            //считать вывод пользователя и сохранить в переменную
            var userEnter = Console.ReadLine();
            //преобразование из одного типа данных в другой
            int result;
            var parced = int.TryParse(userEnter, out result);
            //если пользователь ввёл не число, показать пользователю сообщение об ошибке
            if (parced == false)
            {
                Console.WriteLine("Научись на цифры нажимать!");
            }
            //если пользователь ввёл число, не от одного до семи, тогда вывести сообщение об ошибке
            else if (result > 7 || result < 1)
            {
                Console.WriteLine("Тебе же выше написали, от 1 до 7! ");
            }
            else
            {
                //если день недели равен одному - тогда будет понедельник, повторить для остальных 6-ти дней
                if (result == 1)
                {
                    Console.WriteLine("Этот день понедельник");
                }
                else if (result == 2)
                {
                    Console.WriteLine("Этот день вторник");
                }
                else if (result == 3)
                {
                    Console.WriteLine("Этот день среда");
                }
                else if (result == 4)
                {
                    Console.WriteLine("Этот день четверг");
                }
                else if (result == 5)
                {
                    Console.WriteLine("Этот день пятница");
                }
                else if (result == 6)
                {
                    Console.WriteLine("Этот день суббота");
                }
                else if (result == 7)
                {
                    Console.WriteLine("Этот день воскресенье");
                }
            }
        }
    }
}
