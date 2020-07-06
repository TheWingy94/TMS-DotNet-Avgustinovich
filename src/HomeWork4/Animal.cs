using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork4
{
    public abstract class Animal
    {
        private string _kind;
        public string Kind
        {
            get
            {
                return _kind;
            }
        }
        public Animal(string kind)
        {
            _kind = kind;
        }
        public abstract string Say();
    }
}
