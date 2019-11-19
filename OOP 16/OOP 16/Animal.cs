using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_16
{
    public abstract class Animal
    {
        public string name;

        public Animal(string name)
        {
            this.name = name;
        }

        public abstract void MakeSound();

        public override string ToString()
        {
            return $"Name = {name}";
        }
    }
}
