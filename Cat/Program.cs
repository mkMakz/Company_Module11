using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    class Program
    {
        public enum Food { fish, meat, mouse, whiskas }

        struct Cat
        {
            public int SatietLlevel { get; set; }

            public void EatSomething()
            {
                Food food = new Food();
                Random rand = new Random();
                food = (Food)rand.Next(1, 3);
                switch (food)
                {
                    case Food.fish:
                        SatietLlevel = 50;
                        Console.WriteLine($"The Cat was fed {food} and satiet level is {SatietLlevel}");
                        break;
                    case Food.meat:
                        SatietLlevel = 49;
                        Console.WriteLine($"The Cat was fed {food} and satiet level is {SatietLlevel}");
                        break;
                    case Food.mouse:
                        SatietLlevel = 30;
                        Console.WriteLine($"The Cat was fed {food} and satiet level is {SatietLlevel}");
                        break;
                    case Food.whiskas:
                        SatietLlevel = 20;
                        Console.WriteLine($"The Cat was fed {food} and satiet level is {SatietLlevel}");
                        break;
                }

            }
        }
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.EatSomething();
        }
    }
}
