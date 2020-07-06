using System;

namespace HomeWork4
{
    public class Cow : Animal, ITerrestrial
    {
        public Cow() : base("корова")
        {
        }

        public void Run()
        {
            Console.WriteLine("тыг гы дык");
        }

        public override string Say()
        {
            return "Mooooo";
        }

        public void Walk()
        {
            Console.WriteLine("top top top");
        }
    }
}
