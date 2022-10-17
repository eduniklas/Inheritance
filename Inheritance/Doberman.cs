using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Doberman : Dog
    {
        int _Speed = 10;
        public Doberman(string animal, string name, string sex, string color, string sound, int age, double weight, string breed, int speed)
            : base(animal, name, sex, color, sound, age, weight, breed)
        {
            Speed = speed;
        }
        public int Speed // if speed input is higer then top speed put top speed.
        { 
            get { return _Speed; }
            set
            {
                if (value > 56)
                {
                    this._Speed = 56;   
                }
                else
                {
                    this._Speed = value;
                }
            }
        }
        public void RuningSpeed()
        {
            Console.WriteLine("This doberman runs at a speed of " + _Speed + "kp/h right now");
        }
    }
}
