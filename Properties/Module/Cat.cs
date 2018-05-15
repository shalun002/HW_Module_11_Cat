using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties.Module
{
    public enum Food { mouse, fish, whiskass, meat, ibuprofen }

    public struct Cat
    {
        public int SatietyLevel { get; set; }

        public void EatSomething()
        {
            Food food = new Food();
            Random rand = new Random();
            food = (Food)rand.Next(0, 4);
            switch (food)
            {
                case Food.fish:
                    SatietyLevel = 50;
                    Console.WriteLine($"The Cat was fed {food} and satiet level is {SatietyLevel}");
                    break;
                case Food.meat:
                    SatietyLevel = 49;
                    Console.WriteLine($"The Cat was fed {food} and satiet level is {SatietyLevel}");
                    break;
                case Food.mouse:
                    SatietyLevel = 30;
                    Console.WriteLine($"The Cat was fed {food} and satiet level is {SatietyLevel}");
                    break;
                case Food.whiskass:
                    SatietyLevel = 20;
                    Console.WriteLine($"The Cat was fed {food} and satiet level is {SatietyLevel}");
                    break;
                case Food.ibuprofen:
                    SatietyLevel = 0;
                    Console.WriteLine($"The Cat was fed {food} and cat is died out");
                    break;
            }
        }
    }
}