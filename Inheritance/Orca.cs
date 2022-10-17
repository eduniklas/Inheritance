using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Inheritance
{
    class Orca : Animal
    {
        bool _Kills = true;
        public Orca(string animal, string name, string sex, string color, string sound, int age, double weight, bool kills)
        {
            this._Animal = animal;
            this._Name = name;
            this._Sex = sex;
            this._Color = color;
            this._Sound = sound;
            this._Age = age;
            this._Weight = weight;
            this._Kills = kills;
        }
        public void HumanKills()
        {
            if (_Kills == true)
            {
                Console.WriteLine(_Name + " have killed humans so keep your distans!");
            }
            else
            {
                Random rand = new Random();
                int rBodyPart = rand.Next(0, 7);
                string[] bodyPart = new string[] { "half a leg", "a hand", "one arm", "a big toe", "one ear", "a nose", "few fingers" };
                Console.WriteLine(_Name + " have bitten off " + bodyPart[rBodyPart] + " but not killed any humans... yet.");
            }
        }
    }
}
