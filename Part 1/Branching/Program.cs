using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the required welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight and convert it to a double
            Console.WriteLine("Please enter the package weight:");
            double weight = Convert.ToDouble(Console.ReadLine());

            // Check if the package exceeds the maximum weight limit
            if (weight > 50)
            {
                // Display error message and end the program if too heavy
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exits the Main method, ending the program
            }

            // Prompt the user for the package dimensions
            Console.WriteLine("Please enter the package width:");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package height:");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            double length = Convert.ToDouble(Console.ReadLine());

            // Calculate the sum of the dimensions to check size restrictions
            double dimensionsTotal = width + height + length;

            // Check if the total dimensions exceed the limit
            if (dimensionsTotal > 50)
            {
                // Display error message and end the program if too big
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exits the Main method, ending the program
            }

            // Calculate the shipping quote based on the formula:
            // (Width * Height * Length * Weight) / 100
            double quote = (width * height * length * weight) / 100;

            // Display the final calculated quote formatted as a dollar amount
            // The :F2 format string ensures it always prints with two decimal places (e.g., 528.00)
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            // Keeps the console window open until a key is pressed (useful for debugging in Visual Studio)
            Console.ReadLine();
        }
    }
}
