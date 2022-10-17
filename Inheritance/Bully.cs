using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Bully : Dog
    {
        bool _Buff = !true;
        public Bully(string animal, string name, string sex, string color, string sound, int age, double weight, string breed, bool buff)
        : base(animal, name, sex, color, sound, age, weight, breed)
        {
            this._Buff = buff;
        }
        public void BullyData()
        {
            if (_Buff == true)
            {
                Console.WriteLine("This bully is built like Arnold was in the 80's");
            }
        }
    }
}
