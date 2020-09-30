using System;

namespace Studio_AreaOfCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter a radius:");
            string input = Console.ReadLine();
            double r = double.Parse(input);
            Console.WriteLine("The area of a circle of radius " + r +  " is " + (Math.PI * r * r));
            //Console.ReadLine();
            Console.WriteLine("The circumference of a circle of radius " + r + " is " + (2*Math.PI * r));
            Console.WriteLine("What's your car's miles per gallon?");
            string inputMiles = Console.ReadLine();
            double gallons = double.Parse(inputMiles);
            Console.WriteLine("You would use " + (2 * Math.PI * r) * gallons + " gallons of fuel to go around this circle");
            
            Console.ReadLine();

        }
    }
}
