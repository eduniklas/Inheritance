using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Inheritance
{
    class Zebra : Animal 
    {
        bool _Dance = !true;
        public Zebra(string animal, string name, string sex, string color, string sound, int age, double weight, bool dance)
        {
            this._Animal = animal;
            this._Name = name;
            this._Sex = sex;
            this._Color = color;
            this._Sound = sound;
            this._Age = age;
            this._Weight = weight;
            this._Dance = dance;
        }
        public void Dance()
        {
            if (_Dance == true)
            {
                Random rand = new Random();
                int rDance = rand.Next(0, 3);
                string[] dance = new string[] { " does all the moves from Dirty Dancing ", " does some tango moves ", " does all the tiktok dances " };
                Console.WriteLine(_Name + " want to show you what " + _HeOrShe.ToLower() + " knows so " + _HeOrShe.ToLower() + dance[rDance]);
            }
            else
            {
                Console.WriteLine(_Name + " can't dance and thinks you should go home and watch Madagaskar!..Where such nonsense exist!");
            }
        }
    }
}
