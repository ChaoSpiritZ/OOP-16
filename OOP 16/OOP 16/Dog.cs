using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_16
{
    public abstract class Dog : Animal
    {
        public string favouriteDogFood;

        public Dog(string favouriteDogFood, string name) : base(name)
        {
            this.favouriteDogFood = favouriteDogFood;
        }

        public override void MakeSound()
        {
            this.Bark();
        }

        public virtual void Bark()
        {
            Console.WriteLine("Bark!");
        }

        public override string ToString()
        {
            return base.ToString() + $", Favourite Dog Food = {favouriteDogFood}";
        }
    }
}
