using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_16
{
    public class Horse : Animal
    {
        public bool racingHorse;

        public Horse(bool racingHorse, string name) : base(name)
        {
            this.racingHorse = racingHorse;
        }

        public override void MakeSound()
        {
            this.Neigh();
        }

        public virtual void Neigh()
        {
            Console.WriteLine("NEEEEEEEIIIIGH!!!");
        }

        public override string ToString()
        {
            return base.ToString() + $", Racing Horse = {racingHorse}";
        }
    }
}
