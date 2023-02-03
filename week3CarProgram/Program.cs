/*
 * Clark Comstock
 * Week 3 Car Program - Gets the make, model, and speed and determines whether or not to hit the vehicle with demerits
 * 2/3/2023
 */

using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace week3CarProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables needed for calculations and user input outside of the classes
            int status = 0;
            int speedLimit = 0;

            // example build, showcases how the program works
            Car c1 = new Car();
            Console.WriteLine("Example output:");
            Console.WriteLine("\nSpeed Limit: " + c1.speedLimit);   
            Console.WriteLine("\nVehicle Info: " + c1.make + " " + c1.model + " " + c1.speed + "MPH");
            status = (c1.speed - c1.speedLimit) / 5;
            if (status < 1) // if statements to check the demerit system
                Console.WriteLine("Status: OK");
            else if (status >= 1 && status <= 9)
                Console.WriteLine("Status: " + status + " demerit(s)");
            else
                Console.WriteLine("Status: " + status + " demerits <LICENSE SUSPENDED>");
            Console.WriteLine("\n---------------END EXAMPLE---------------"); // seperates the user's responses from the example

            // gets the speedlimit from the user
            Console.WriteLine("\nPlease enter the speed limit: ");
            speedLimit = Convert.ToInt32(Console.ReadLine());
            while (speedLimit <= 0) // checks to see if the user input a valid speed limit
            {
                Console.WriteLine("Please enter a number greater than 0: ");
                speedLimit = Convert.ToInt32(Console.ReadLine());
            }

            // shows the speed limit so the user can confirm their submission went through
            Console.WriteLine("\nSpeed limit set to: " + speedLimit);

            // first user submitted vehicle
            Car c2 = new Car();
            Console.WriteLine("\nCar 1:");
            Console.WriteLine("Please enter the car make: ");
            c2.make = Console.ReadLine();
            while (string.IsNullOrEmpty(c2.make)) // checks to see if the user typed anything at all. the constructor was used once, we don't need it again
            {
                Console.WriteLine("Make can not be empty, please enter a valid make: ");
                c2.make = Console.ReadLine();
            }
            Console.WriteLine("Please enter the car model: ");
            c2.model = Console.ReadLine();
            while (string.IsNullOrEmpty(c2.model)) // same as previous comment
            {
                Console.WriteLine("Make can not be empty, please enter a valid model: ");
                c2.model = Console.ReadLine();
            }
            Console.WriteLine("Please enter the speed: ");
            c2.speed = Convert.ToInt32(Console.ReadLine());
            while (c2.speed <= 0) // similar to speed limit comment, a car can't be idle on the street or have a negative speed
            {
                Console.WriteLine("Please enter a number greater than 0: ");
                c2.speed = Convert.ToInt32(Console.ReadLine());
            }

            // second user submitted car, same format as the first car so comments would be the same
            Car c3 = new Car();
            Console.WriteLine("\nCar 2:");
            Console.WriteLine("Please enter the car make: ");
            c3.make = Console.ReadLine();
            while (string.IsNullOrEmpty(c3.make))
            {
                Console.WriteLine("Make can not be empty, please enter a valid make: ");
                c3.make = Console.ReadLine();
            }
            Console.WriteLine("Please enter the car model: ");
            c3.model = Console.ReadLine();
            while (string.IsNullOrEmpty(c3.model))
            {
                Console.WriteLine("Make can not be empty, please enter a valid model: ");
                c3.model = Console.ReadLine();
            }
            Console.WriteLine("Please enter the speed: ");
            c3.speed = Convert.ToInt32(Console.ReadLine());
            while (c3.speed <= 0)
            {
                Console.WriteLine("Please enter a number greater than 0: ");
                c3.speed = Convert.ToInt32(Console.ReadLine());
            }

            // third car, same comments as previous two cars
            Car c4 = new Car();
            Console.WriteLine("\nCar 3:");
            Console.WriteLine("Please enter the car make: ");
            c4.make = Console.ReadLine();
            while (string.IsNullOrEmpty(c4.make))
            {
                Console.WriteLine("Make can not be empty, please enter a valid make: ");
                c4.make = Console.ReadLine();
            }
            Console.WriteLine("Please enter the car model: ");
            c4.model = Console.ReadLine();
            while (string.IsNullOrEmpty(c4.model))
            {
                Console.WriteLine("Make can not be empty, please enter a valid model: ");
                c4.model = Console.ReadLine();
            }
            Console.WriteLine("Please enter the speed: ");
            c4.speed = Convert.ToInt32(Console.ReadLine());
            while (c4.speed <= 0)
            {
                Console.WriteLine("Please enter a number greater than 0: ");
                c4.speed = Convert.ToInt32(Console.ReadLine());
            }

            // results of the user's submissions, follows the same format as the example output
            Console.WriteLine("----------Results----------"); // to make the program look a little nicer on the output, seperates the output from the user's responses
            Console.WriteLine("\nSpeed Limit: " + speedLimit);
            Console.WriteLine("\nVehicle 1 Info: " + c2.make + " " + c2.model + " " + c2.speed + "MPH");
            status = (c2.speed - speedLimit) / 5;
            if (status < 1)
                Console.WriteLine("Status: OK");
            else if (status >= 1 && status <= 9)
                Console.WriteLine("Status: " + status + " demerit(s)");
            else
                Console.WriteLine("Status: " + status + " demerits <LICENSE SUSPENDED>");

            Console.WriteLine("\nVehicle 2 Info: " + c3.make + " " + c3.model + " " + c3.speed + "MPH");
            status = (c3.speed - speedLimit) / 5;
            if (status < 1)
                Console.WriteLine("Status: OK");
            else if (status >= 1 && status <= 9)
                Console.WriteLine("Status: " + status + " demerit(s)");
            else
                Console.WriteLine("Status: " + status + " demerits <LICENSE SUSPENDED>");

            Console.WriteLine("\nVehicle 3 Info: " + c4.make + " " + c4.model + " " + c4.speed + "MPH");
            status = (c4.speed - speedLimit) / 5;
            if (status < 1)
                Console.WriteLine("Status: OK");
            else if (status >= 1 && status <= 9)
                Console.WriteLine("Status: " + status + " demerit(s)");
            else
                Console.WriteLine("Status: " + status + " demerits <LICENSE SUSPENDED>");

        }
        // the car class, allows the program to function
        class Car
        {
            public Car() // a new constructor for the example to follow, replaces the default constructor
            {
                make = "Jeep";
                model = "Cherokee";
                speed = 40;
                speedLimit = 35;
            }
            public string make = "";
            public string model = "";
            public int speed = 0;
            public int speedLimit = 0;
        }
    }
}