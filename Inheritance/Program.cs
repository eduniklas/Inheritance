using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initiate diffrent animal classes.
            Orca FredOrca = new Orca("Orca", "Fred", "Male", "Black & white", "Make a high pitch screech", 7, 3000, !true);
            Orca GertrudOrca = new Orca("Orca", "Gertrud", "Female", "Black & white", "Make a high pitch screech", 25, 4000, true);

            Koala GlenKoala = new Koala("Koala", "Glen", "Male", "Gray", "Scream like satans demon", 4, 10, true);
            Koala FionaKoala = new Koala("Koala", "Fiona", "Female", "Gray & brown", "Scream like satans demon", 6, 7, !true);
            
            Zebra MartyZebra = new Zebra("Zebra", "Marty", "Male", "White & black", "Talks, suspicusly enough like Chris Rock", 5, 320, true);
            Zebra SusanZebra = new Zebra("Zebra", "Susan", "Female", "White & black", "whines", 4, 270, !true);

            Dog LeonDog = new Dog("Dog", "Leon", "Male", "Black & gray", "Bark", 10, 18, "English Staffy");
            Bully LeiaDog = new Bully("Dog", "Leia", "Female", "Gray, white & brown", "Farts", 1, 21, "American Bully", true);
            Doberman FrodoDog = new Doberman("Dog", "Frodo", "Male", "Brown", "Stare so intense you hear his thoughts", 3, 44, "Doberman", 30);

            Animal baseAnimal = new Animal(); //Initiate base class 
            baseAnimal.PrintInfo();
            baseAnimal.LivesIn();

            FredOrca.PrintInfo();
            FredOrca.LivesIn();
            FredOrca.MakeSound();
            FredOrca.HumanKills();

            GertrudOrca.PrintInfo();
            GertrudOrca.LivesIn();
            GertrudOrca.MakeSound();
            GertrudOrca.HumanKills();

            GlenKoala.PrintInfo();
            GlenKoala.LivesIn();
            GlenKoala.HaveClamydia();
            GlenKoala.MakeSound();

            FionaKoala.PrintInfo();
            FionaKoala.LivesIn();
            FionaKoala.HaveClamydia();
            FionaKoala.MakeSound();

            MartyZebra.PrintInfo();
            MartyZebra.LivesIn();
            MartyZebra.MakeSound();
            MartyZebra.Dance();

            SusanZebra.PrintInfo();
            SusanZebra.LivesIn();
            SusanZebra.MakeSound();
            SusanZebra.Dance();

            LeonDog.PrintInfo();
            LeonDog.PrintBreed();
            LeonDog.LivesIn();
            LeonDog.MakeSound();

            LeiaDog.PrintInfo();
            LeiaDog.PrintBreed();
            LeiaDog.LivesIn();
            LeiaDog.MakeSound();
            LeiaDog.BullyData();

            FrodoDog.PrintInfo();
            FrodoDog.PrintBreed();
            FrodoDog.LivesIn();
            FrodoDog.MakeSound();
            FrodoDog.RuningSpeed();
        }
    }

}
