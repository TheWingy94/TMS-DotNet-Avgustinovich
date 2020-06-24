using System;

namespace HomeWork3
{
    class Program
    {
        static void Main()
        {
            var todo1 = new ToDo(DateTime.Now)
            {
                Name = "My first task"
            };
            todo1.Show();

            var todo2 = new ToDo(DateTime.Now)
            {
                Name = "Very hard task"
            };
            todo2.Show();
        }

    }
}
