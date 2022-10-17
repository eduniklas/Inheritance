using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Inheritance
{
    class Animal
    {
        public string _Animal = "RandomZooAnimal";
        public string _Sex = "Gender Confused";
        public string _Color = "Pink";
        public string _Sound = "FartSound";
        public int _Age = 10;
        public double _Weight = 300.5;
        public string _Name = "DangerFloff";
        public string _HeOrShe;
        public virtual void MakeSound()
        {
            Console.WriteLine(_Name + " the " + _Animal.ToLower() + " " + _Sound.ToLower());
        }
        public virtual void PrintInfo()
        {
            if (_Sex == "Male")
            {
                this._HeOrShe = "He";
            }
            else if (_Sex == "Female")
            {
                this._HeOrShe = "She";
            }
            else
            {
                this._HeOrShe = "The alien";
            }
            Console.WriteLine("\nThis is " + _Name + ", a " + _Sex + " " + _Animal + "." +
                "\n" + _HeOrShe + " is the color " + _Color.ToLower() +
                "\nand " + _HeOrShe.ToLower() + " is " + _Age + "years old and weigh " + _Weight + "kg");
        }
        public virtual void LivesIn()
        {
            string[] waterAnimal = { "GoldFish", "Shark", "Squid", "Turtel", "Orca" };
            string[] landAnimal = new string[] { "Koala", "Bear", "Dog", "Zebra", "Cat" };
            if (waterAnimal.Contains(_Animal))
            {
                Console.WriteLine(_Animal + "s live in the water");
            }
            else if (landAnimal.Contains(_Animal))
            {
                Console.WriteLine(_Animal + "s live on land");
            }
            else
            {
                Console.WriteLine("This one might be extra terrestrial");
            }
        }
    }
}
