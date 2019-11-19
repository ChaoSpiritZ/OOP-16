using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_16
{
    public class Poodle : Dog
    {
        public int numberOfPonyTails;

        public Poodle(int numberOfPonyTails, string favouriteDogFood, string name) : base(favouriteDogFood, name)
        {
            this.numberOfPonyTails = numberOfPonyTails;
        }

        public override void Bark()
        {
            Console.WriteLine("AWUUUAWWUUAWUU!");
        }

        public override string ToString()
        {
            return base.ToString() + $", Number of Pony Tails = {numberOfPonyTails}";
        }
    }
}
