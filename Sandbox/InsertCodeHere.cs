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

            Human h3 = new Human(); //laver object, kalder constructor
            Console.WriteLine($"Navnet er {h3.Name} BMI { h3.BMI}");


            Human h4 = new Human("Kurt", 2, 90);
            Console.WriteLine($"Navnet er {h4.Name} BMI { h4.BMI}");
            // The LAST line of code should be ABOVE this line
        }
    }
}