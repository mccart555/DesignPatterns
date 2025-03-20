using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Functional;

public class HigherOrderFunction
{

    //Higher-order functions provide several benefits:
    //    Reusability: You can create general functions that work with various callbacks.
    //    Abstraction: They help in abstracting out common patterns and simplifying code.
    //    Flexibility: They allow passing behavior (functions) as arguments, providing more flexible design.

    //Explanation of the Code
    //    ApplyFunction: This is the higher-order function. It takes a list of integers and a function (func) that takes an integer and returns an integer (Func<int, int>). It applies the function to each element in the list and returns a new list with the results.
    //    Square and Double: These are sample functions that we can pass to ApplyFunction.
    //    Main Method: Here, we create a list of integers and use ApplyFunction to apply the Square and Double functions to it. The results are printed to the console.
    //
    //This example demonstrates how higher-order functions can be used to abstract common operations and apply different behaviors dynamically.


    // Higher-order function that takes a function and a list of integers
    public static List<int> ApplyFunction(List<int> numbers, Func<int, int> func)
    {
        List<int> result = new List<int>();
        foreach (var number in numbers)
        {
            result.Add(func(number));
        }

        return result;
    }

    // Sample functions to use with the higher-order function
    public static int Square(int x) => x * x;
    public static int Double(int x) => x * 2;

}