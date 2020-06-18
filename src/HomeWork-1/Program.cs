using System;
using System.Security.Cryptography;

namespace HomeWork_1
{
    class Program
    {
        static void VariantOne()
        {
            //пользователю нужно сообщить о введении операции
            Console.Write("Введите номер дня недели(от 1 до 7): ");
            //считать вывод пользователя и сохранить в переменную
            var userEnter = Console.ReadLine();
            //преобразование из одного типа данных в другой
            var parced = int.TryParse(userEnter, out int result);
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

        static void VariantTwo()
        {
            //показать пользователю что мы от него хотим
            Console.Write("Введите день недели: ");
            //пользователь должен ввести строку
            string userEnter = Console.ReadLine();
            userEnter = userEnter.ToLower();
            //если строка = понедельник, значит выводим 1 и т.д
            if (userEnter == "понедельник" || userEnter == "monday")
            {
                Console.WriteLine("День недели 1");
            }
            else if (userEnter == "вторник" || userEnter == "tuesday")
            {
                Console.WriteLine("День недели 2");
            }
            else if (userEnter == "среда" || userEnter == "wednesday")
            {
                Console.WriteLine("День недели 3");
            }
            else if (userEnter == "четверг" || userEnter == "thursday")
            {
                Console.WriteLine("День недели 4");
            }
            else if (userEnter == "пятница" || userEnter == "friday")
            {
                Console.WriteLine("День недели 5");
            }
            else if (userEnter == "суббота" || userEnter == "saturday")
            {
                Console.WriteLine("День недели 6");
            }
            else if (userEnter == "воскресенье" || userEnter == "sunday")
            {
                Console.WriteLine("День недели 7");
            }
            //если не совпало - показать ошибку
            else
            {
                Console.WriteLine("Error!");
            }
        }

        static void VariantThree()
        {
            var now = DateTime.Now.DayOfWeek;

            if (now == DayOfWeek.Monday)
            {
                Console.WriteLine("Today is Monday!");
            }
            else if (now == DayOfWeek.Tuesday)
            {
                Console.WriteLine("Today is Tuesday");
            }
            else if (now == DayOfWeek.Wednesday)
            {
                Console.WriteLine("Today is Wensday!");
            }
            else if (now == DayOfWeek.Thursday)
            {
                Console.WriteLine("Today is Thursday!");
            }
            else if (now == DayOfWeek.Friday)
            {
                Console.WriteLine("Today is Friday!");
            }
            else if (now == DayOfWeek.Saturday)
            {
                Console.WriteLine("Today is Saturday!");
            }
            else if (now == DayOfWeek.Sunday)
            {
                Console.WriteLine("Today is Sunday!");
            }
            else
            {
                Console.WriteLine("Bad value.");
            }
        }

        static void Main(string[] args)
        {
            VariantOne();
            Console.WriteLine(new string('=', 10));
            VariantTwo();
            Console.WriteLine(new string('=', 10));
            VariantThree();
        }
    }
}
