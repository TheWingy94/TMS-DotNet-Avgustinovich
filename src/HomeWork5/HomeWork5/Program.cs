using System;
using System.Collections.Generic;

namespace HomeWork5
{
    class Program
    {
        static void Main(string[] args)
        { 
            var cages = new IAnimal[3];
            cages[0] = new Cow();
            cages[1] = new Cat();
            cages[2] = new Dog();

            Console.WriteLine("Выбирете клетку: ");

            var cage = int.Parse(Console.ReadLine());
            cages[cage].Say();
        }
    }
}
