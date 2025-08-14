
using System;

class PackageDeliveryEstimator
{
    static void Main()
    {
        Console.WriteLine("Hello and welcome to Package Express!");
        Console.WriteLine("To continue, please enter the requested package details below.");

        Console.Write("Package Weight (lbs): ");
        bool isWeightValid = decimal.TryParse(Console.ReadLine(), out decimal weight);

        if (!isWeightValid)
        {
            Console.WriteLine("Invalid input for weight. Please restart the program.");
            return;
        }

        if (weight > 50)
        {
            Console.WriteLine("Unfortunately, your package exceeds the maximum weight limit for shipping.");
            Console.WriteLine("Please try a different carrier. Goodbye!");
            return;
        }

        Console.Write("Package Width (inches): ");
        bool isWidthValid = decimal.TryParse(Console.ReadLine(), out decimal width);

        Console.Write("Package Height (inches): ");
        bool isHeightValid = decimal.TryParse(Console.ReadLine(), out decimal height);

        Console.Write("Package Length (inches): ");
        bool isLengthValid = decimal.TryParse(Console.ReadLine(), out decimal length);

        if (!isWidthValid || !isHeightValid || !isLengthValid)
        {
            Console.WriteLine("One or more dimensions were entered incorrectly. Please restart and try again.");
            return;
        }

        decimal totalSize = width + height + length;

        if (totalSize > 50)
        {
            Console.WriteLine("The combined size of your package is too large to be shipped with us.");
            return;
        }

        decimal costEstimate = (width * height * length * weight) / 100;
        Console.WriteLine($"Estimated shipping fee: ${costEstimate:0.00}");
        Console.WriteLine("We appreciate your business. Have a great day!");
    }
}
