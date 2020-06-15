using System;

namespace HomeWork__1_3_
{
    class Program
    {
        static void Main(string[] args)
        {
                if (DateTime.Now.DayOfWeek == DayOfWeek.Monday)
                {
                    Console.WriteLine("Today is Monday!");
                }


                if (DateTime.Now.DayOfWeek == DayOfWeek.Tuesday)
                {
                    Console.WriteLine("Today is Tuesday");
                }


                if (DateTime.Now.DayOfWeek == DayOfWeek.Wednesday)
                {
                    Console.WriteLine("Today is Wensday!");
                }

                if (DateTime.Now.DayOfWeek == DayOfWeek.Thursday)
                {
                    Console.WriteLine("Today is Thursday!");
                }

                if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
                {
                    Console.WriteLine("Today is Friday!");
                }


                if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
                {
                    Console.WriteLine("Today is Saturday!");
                }


                if (DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                {
                    Console.WriteLine("Todat is Sunday!");
                }
        }
    }
}
