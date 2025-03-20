using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Functional;

public static class PatternMatchingCalculator
{
    //Pattern matching is a feature that allows you to check a value against a pattern and execute code based on the match. It's commonly used in
    //functional programming languages, but C# also supports pattern matching starting from C# 7.0.

    //Explanation
    //    Pattern Matching helps you to simplify complex conditional logic by allowing you to match values against patterns directly within switch
    // statements, if statements, or expressions.  It makes the code more readable and maintainable.

    //Explanation of the Code
    //    Shape Class Hierarchy: We have an abstract base class Shape and three derived classes Circle, Rectangle, and Triangle.
    //    CalculateArea Function: This function takes a Shape object and uses a switch expression with pattern matching to calculate the area based on
    //    the specific shape type.
    //    For Circle, it calculates the area using the formula π * Radius².
    //    For Rectangle, it calculates the area using the formula Width * Height.
    //    For Triangle, it calculates the area using the formula 0.5 * Base * Height.
    //    Main Method: Here, we create instances of different shapes and use the CalculateArea function to calculate and print their areas.
    //This example demonstrates how pattern matching can simplify conditional logic and make your code more readable.
    public static double CalculateArea(Shape shape)
    {
        // Using pattern matching to calculate area based on the shape type
        return shape switch
        {
            Circle c => Math.PI * c.Radius * c.Radius,
            Rectangle r => r.Width * r.Height,
            Triangle t => 0.5 * t.Base * t.Height,
            _ => throw new ArgumentException(message: "Unknown shape", paramName: nameof(shape))
        };
    }
}

public abstract class Shape
{
    // Define the base class for shapes
}

public class Circle : Shape
{
    public double Radius { get; }
    public Circle(double radius) => Radius = radius;
}

public class Rectangle(double width, double height) : Shape
{
    public double Width { get; } = width;
    public double Height { get; } = height;
}

public class Triangle(double @base, double height) : Shape
{
    public double Base { get; } = @base;
    public double Height { get; } = height;
}

