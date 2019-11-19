using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_16
{
    //no idea how to prevent classes from inheriting from that one
    public class BabyWolf : Wolf
    {
        public BabyWolf(string nameOfPack, string favouriteDogFood, string name) : base(nameOfPack, favouriteDogFood, name)
        {

        }

        public override void Bark()
        {
            Console.WriteLine("*baby bark*");
        }
    }
}
