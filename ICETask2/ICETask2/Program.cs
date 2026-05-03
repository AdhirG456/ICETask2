using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICETask2 { 
 // Step 1: Declare the delegate
    delegate double Converter(double temperature);

class Program
{
    // Method to convert Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    // Method to convert Fahrenheit to Celsius
    static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Temperature Converter ===\n");

        // Ask user for temperature
        Console.Write("Enter the temperature: ");
        double temp;
        while (!double.TryParse(Console.ReadLine(), out temp))
        {
            Console.Write("Invalid input! Please enter a valid number: ");
        }

        // Ask user for conversion type
        Console.WriteLine("\nChoose conversion:");
        Console.WriteLine("1 → Celsius to Fahrenheit");
        Console.WriteLine("2 → Fahrenheit to Celsius");
        Console.Write("Enter your choice (1 or 2): ");

        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
        {
            Console.Write("Invalid choice! Please enter 1 or 2: ");
        }

        // Declare delegate and assign appropriate method
        Converter converter;

        if (choice == 1)
        {
            converter = CelsiusToFahrenheit;
            Console.WriteLine($"\nConverting {temp}°C to Fahrenheit...");
        }
        else
        {
            converter = FahrenheitToCelsius;
            Console.WriteLine($"\nConverting {temp}°F to Celsius...");
        }

        // Use delegate to perform conversion
        double result = converter(temp);

        // Display result
        if (choice == 1)
        {
            Console.WriteLine($"Result: {result:F2}°F");
        }
        else
        {
            Console.WriteLine($"Result: {result:F2}°C");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
  }
}


