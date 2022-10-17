using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class Dog : Animal
    {
        string _Breed = "Pigmypuff";
        public Dog(string animal, string name, string sex, string color, string sound, int age, double weight, string breed)
        {
            this._Animal = animal;
            this._Name = name;
            this._Sex = sex;
            this._Color = color;
            this._Sound = sound;
            this._Age = age;
            this._Weight = weight;
            this._Breed = breed;
        }
        public void PrintBreed()
        {
            Console.WriteLine(_Name + " is of the breed " + _Breed);
        }
    }
}
