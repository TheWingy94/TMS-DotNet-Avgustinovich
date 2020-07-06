using System;
namespace HomeWork4
{
    partial class Program
    {
        private class Human : Animal, ISwimming, ITerrestrial
        {
            public Human() : base("Человек")
            {
            }

            public void Dive()
            {
                Console.WriteLine("  ");
            }

            public void Run()
            {
                Console.WriteLine("top top"); ;
            }

            public override string Say()
            {
                return "Hello animal's";
            }

            public void Swim()
            {
                Console.WriteLine("  "); ;
            }

            public void Walk()
            {
                Console.WriteLine("Top"); ;
            }
        }
    }
}
