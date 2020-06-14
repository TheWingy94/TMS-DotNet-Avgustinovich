using System;

namespace HomeWork___1_2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //показать пользователю что мы от него хотим
            Console.Write("Введите день недели: ");
            //пользователь должен ввести строку
            string userEnter = Console.ReadLine();
            userEnter = userEnter.ToLower();
            //если строка = понедельник, значит выводим 1 и т.д
            if (userEnter == "понедельник" || userEnter == "sunday")
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
    }
}
