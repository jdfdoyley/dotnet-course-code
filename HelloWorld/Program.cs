using Microsoft.VisualBasic;

namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        // Data Structures - Arrays
        // Array - An array is a fixed-size data structure that can hold elements of the same type. It is the simplest
        // form of data structure and provides fast access to its items by using an index. Arrays are defined with a
        // specific length, and once created, the size cannot be changed.

        // int[] numbers = new int[5]; // declare an array of integers with 5 elements
        // int[] initializedNumbers = { 1, 2, 3, 4, 5 }; // declares and initilizes an array

        // Console.WriteLine();

        // Data Structure - Lists
        // List<double> temperatures = new List<double> { 20.5, 22.3, 18.7, 19.5, 25.1, 21.3, 23.2 };
        // foreach (var temperature in temperatures)
        // {
        //     Console.WriteLine(temperature);
        // }
        // Console.WriteLine();

        // Add new temperature
        // temperatures.Add(24.4);
        // foreach (var temperature in temperatures)
        // {
        //     Console.WriteLine(temperature);
        // }
        // Console.WriteLine();

        // Remove specific temperature
        // temperatures.Remove(20.5);
        // foreach (var temperature in temperatures)
        // {
        //     Console.WriteLine(temperature);
        // }
        // Console.WriteLine();

        // Calculate average temperature
        // double averageTemp = temperatures.Average();
        // Console.WriteLine(averageTemp);

        // Store and retrieve data using literal and variable values in C#

        // Variables
        // int age = 30;  // Declaring and initializing an integer variable
        // double height = 5.9;  // Declaring and initializing a double variable
        // string name = "John"; // Declear and initializing a string variable

        // Console.WriteLine(age);
        // Console.WriteLine(height);
        // Console.WriteLine(name);

        // Constants
        // const double PI = 3.14159; // Declaring a constant
        // Console.WriteLine(PI);

        // Storing Data
        int a = 10; // Storing an integer literal in a variable
        a = 20; // Changing the value stored in the variable 'a'
        const string GREETING = "Hello, C#"; // Storing a string literal in a constant

        // Retrieving Data
        Console.WriteLine(a); // Output: 20
        Console.WriteLine(GREETING);
    }
}
