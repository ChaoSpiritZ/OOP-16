using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_16
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse horace = new Horse(true, "horace");
            Console.WriteLine(horace);
            horace.MakeSound();

            Poodle poodly = new Poodle(2, "meat", "poodly");
            Console.WriteLine(poodly);
            poodly.MakeSound();

            Wolf wolfy = new Wolf("alpha", "flesh", "wolfy");
            Console.WriteLine(wolfy);
            wolfy.MakeSound();

            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine();

            Animal[] animals1 = new Animal[5];
            animals1[0] = new Horse(false, "horsey");
            animals1[1] = new Horse(true, "racey");
            animals1[2] = new Poodle(3, "bonzo", "pudding");
            animals1[3] = new Wolf("beta", "lions", "sif");
            animals1[4] = new BabyWolf("omega", "humans", "browny");

            AnimalSing(animals1);

            Console.WriteLine();
            Console.WriteLine("--------------");
            Console.WriteLine();

            Horse[] horses1 = new Horse[5];
            horses1[0] = new Horse(false, "horse1");
            horses1[1] = new Horse(true, "horse2");
            horses1[2] = new Horse(true, "horse3");
            horses1[3] = new Horse(false, "horse4");
            horses1[4] = new Horse(true, "horse5");

            Horse[] racingHorses1 = GetRacingHorses(horses1);

            for (int i = 0; i < racingHorses1.Length; i++)
            {
                Console.WriteLine(racingHorses1[i]);
            }
        }

        static void AnimalSing(Animal[] animals)
        {
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].MakeSound();
            }
        }

        static Horse[] GetRacingHorses(Horse[] horses)
        {
            int numOfRacingHorses = 0;
            for (int i = 0; i < horses.Length; i++)
            {
                if(horses[i].racingHorse == true)
                {
                    numOfRacingHorses++;
                }
            }
            Horse[] racingHorses = new Horse[numOfRacingHorses];
            int racingHorsesCounter = 0;
            for (int i = 0; i < horses.Length; i++)
            {
                if(horses[i].racingHorse == true)
                {
                    racingHorses[racingHorsesCounter] = horses[i];
                    racingHorsesCounter++;
                }
            }
            return racingHorses;
        }
    }
}
