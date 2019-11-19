using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_16
{
    public class Wolf : Dog
    {
        public string nameOfPack;

        public Wolf(string nameOfPack, string favouriteDogFood, string name) : base(favouriteDogFood, name)
        {
            this.nameOfPack = nameOfPack;
        }

        public override string ToString()
        {
            return base.ToString() + $", Name of Pack = {nameOfPack}";
        }
    }
}
