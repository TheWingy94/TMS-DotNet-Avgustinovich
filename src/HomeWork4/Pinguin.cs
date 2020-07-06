using System;

namespace HomeWork4
{
    public class Pinguin : Animal, IFlying, ITerrestrial, ISwimming
    {
        public Pinguin() : base("пингвин")
        {
        }

        public void Dive()
        {
            Console.WriteLine("Bool' Bool'");
        }

        public void Fly()
        {
            Console.WriteLine("HA-HA idiots");
        }

        public void Run()
        {
            Console.WriteLine("top top top top");
        }

        public override string Say()
        {
            return "beeeeeeep";
        }

        public void Swim()
        {
            Console.WriteLine("pluh pluh");
        }

        public void Walk()
        {
            Console.WriteLine("top top top top");
        }
    }
}
