using System;

namespace HomeWork4
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var pinguin = new Pinguin();
            Console.WriteLine(pinguin.Kind);
            Console.WriteLine(pinguin.Say());
            pinguin.Dive();
            pinguin.Fly();
            pinguin.Run();
            pinguin.Swim();
            pinguin.Walk();

            Console.WriteLine("=====================================");
            
            var cow = new Cow();
            Console.WriteLine(cow.Kind);
            Console.WriteLine(cow.Say());
            cow.Run();
            cow.Walk();

            Console.WriteLine("=====================================");

            var human = new Human();
            Console.WriteLine(human.Kind);
            Console.WriteLine(human.Say());
            human.Run();
            human.Swim();
            human.Dive();
            human.Walk();
        }
    }
}
