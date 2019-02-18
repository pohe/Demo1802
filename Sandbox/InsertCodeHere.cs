using System;

namespace Sandbox
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            //Console.WriteLine("Hello world!");

            Human h1 = new Human(); //laver object, kalder constructor
            h1.Name = "Poul";
            h1.Height = 2;
            h1.Weight = 86;
            Console.WriteLine($"Navnet er {h1.Name} BMI { h1.BMI}");
            Human h2 = new Human(); //laver object, kalder constructor
            h2.Name = "Peter";
            h2.Height = 2;
            h2.Weight = 90;
            Console.WriteLine($"Navnet er {h2.Name} BMI { h2.BMI}");

            h2.PrintAllInformation();
            Human h3 = new Human(); //laver object, kalder constructor
            Console.WriteLine($"Navnet er {h3.Name} BMI { h3.BMI}");


            Human h4 = new Human("Kurt", 2, 90);
            Console.WriteLine($"Navnet er {h4.Name} BMI { h4.BMI}");

            // Bord 1

            Boat b1 = new Boat("Kurt", 800, 40, "Bogø");
            Console.WriteLine($"Navnet på båden er {b1.Name}, og den har {b1.Hk} hestekræfter, og er {b1.Feet} fod lang, og ligger pt på {b1.Location}");

            Boat b2 = new Boat();
            b2.Name = "Olga2";
            b2.Hk = 1000;
            b2.Feet = 60;
            b2.Location = "Omø";
            Console.WriteLine($"båden hedder {b2.Name} og ´har {b2.Hk}. Den er{b2.Feet} og ligger på {b2.Location}.");
            b2.TestAverage(1000);


            // Bord 2

            Animal a1 = new Animal();
            a1.Name = "lion";
            a1.Age = 5;
            a1.Alive = false;
            Console.WriteLine($"Dit dyr er en { a1.Name}. Det { a1.Age} år et den i live { a1.Alive}");

            // Bord 3

            Fly plane1 = new Fly("boeing", "Hongkong", 5839, 350);
            Console.WriteLine($"Fly:{ plane1.Name} Destination: { plane1.Destination} Flynummer: { plane1.Number} Passagere: { plane1.Passengers}");

            Fly plane2 = new Fly("airbus", "Copenhagen", 5676, 59);

            Console.WriteLine($"Fly:{ plane2.Name} destination: { plane2.Destination} flynummer: { plane2.Number} passagere: { plane2.Passengers}");

            // Bord 4

            Car c1 = new Car("Audi", "A4", 2.0);
            c1.Brand = "Audi";
            c1.Model = "A4";
            c1.engineSize = 2.0;
            Console.WriteLine($"Bilen er en { c1.Brand}, modellen er en { c1.Model}, og motorens størrelse er { c1.engineSize}");

            Car c2 = new Car("BMW", "M2", 2.0);
            c2.Brand = "BMW";
            c2.Model = "M2";
            c2.engineSize = 2.0;
            Console.WriteLine($"Bilen er en { c2.Brand}, modellen er en { c2.Model}, og motorens størrelse er { c2.engineSize}");


            // Bord 5

            //Vi kalder på en ny warrior - dvs. Bruger mønstret til at lave en kopi

            Warrior w1 = new Warrior("Wombat", 100, 10, 1000);
            Warrior w2 = new Warrior("Racoon", 80, 10, 50);
           // Console.WriteLine($"{ w1.Name} and { w2.Name} both have the same height, which is { w2.Height}   meters. { w1.Name} has { w1.Life} lives and { w1.Strength} hit points. { w2.Name} has { w2.Life} lives and { w2.Strength} hit points.");
            Console.ReadKey();



            // The LAST line of code should be ABOVE this line
        }
    }
}