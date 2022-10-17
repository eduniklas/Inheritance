using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Inheritance
{
    class Koala : Animal
    {
        bool _Clamydia = true;
        public Koala(string animal, string name, string sex, string color, string sound, int age, double weight, bool clamydia)
        {
            this._Animal = animal;
            this._Name = name;
            this._Sex = sex;
            this._Color = color;
            this._Sound = sound;
            this._Age = age;
            this._Weight = weight;
            this._Clamydia = clamydia;
        }
        public void HaveClamydia()
        {
            if (_Clamydia == true)
            {
                Console.WriteLine(_Name + " have clamydia so be careful");
            }
            else
            {
                Console.WriteLine(_Name + " don't have clamydia, this one is safe");
            }
        }
    }
}

