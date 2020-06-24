using System;

namespace HomeWork3
{
    class ToDo
    {
        private DateTime _created;
        public ToDo(DateTime created)
        {
            _created = created;
        }
        public string Name { get; set; }
        public void Show()
        {
            Console.WriteLine($"{Name}, {_created}");
        }
    }
}
