﻿using System;

namespace HomeWork4
{
    class Program
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
        }
    }
}
