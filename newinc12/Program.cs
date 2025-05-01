using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

// Required namespaces for new features in C# 12
using System.Numerics;

// Example of a new feature in C# 12: Primary Constructors for Classes
public class Person(string name, int age)
{
    public string Name { get; } = name;
    public int Age { get; } = age;

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

public static class Program
{
    public static void Main()
    {
        // Example usage of the new feature
        var person = new Person("Alice", 30);
        person.DisplayInfo();

        // Lambda expression with no parameters
        Action noParameterLambda = () => Console.WriteLine("This is a lambda with no parameters.");
        noParameterLambda();

        // Lambda expression with a single parameter
        Func<int, int> singleParameterLambda = x => x * x;
        Console.WriteLine($"Square of 5: {singleParameterLambda(5)}");

        // Lambda expression with multiple parameters
        Func<int, int, int> multipleParametersLambda = (x, y) => x + y;
        Console.WriteLine($"Sum of 3 and 4: {multipleParametersLambda(3, 4)}");
    }

    // Action and Func are built-in generic delegate types in C#
    // that simplify working with method references and lambda expressions.
    // They serve as ready-to-use templates for common method signatures.
}

