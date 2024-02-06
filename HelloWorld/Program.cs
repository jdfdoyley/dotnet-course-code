﻿namespace HelloWorld;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello, World!");

        // Data Structures - Arrays
        // Array - An array is a fixed-size data structure that can hold elements of the same type. It is the simplest
        // form of data structure and provides fast access to its items by using an index. Arrays are defined with a
        // specific length, and once created, the size cannot be changed.

        int[] numbers = new int[5]; // declare an array of integers with 5 elements
        int[] initializedNumbers = { 1, 2, 3, 4, 5 }; // declares and initilizes an array

        Console.WriteLine();

        // Data Structure - Lists
        List<double> temperatures = new List<double> { 20.5, 22.3, 18.7, 19.5, 25.1, 21.3, 23.2 };
        foreach (var temperature in temperatures)
        {
            Console.WriteLine(temperature);
        }
        Console.WriteLine();

        // Add new temperature
        temperatures.Add(24.4);
        foreach (var temperature in temperatures)
        {
            Console.WriteLine(temperature);
        }
        Console.WriteLine();

        // Remove specific temperature
        temperatures.Remove(20.5);
        foreach (var temperature in temperatures)
        {
            Console.WriteLine(temperature);
        }
        Console.WriteLine();

        // Calculate average temperature
        double averageTemp = temperatures.Average();
        Console.WriteLine(averageTemp);
    }
}
