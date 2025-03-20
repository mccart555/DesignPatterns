using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Functional;

public class PureFunctions
{
    //Pure functions are functions that:
    //    Always produce the same output for the same input.
    //    Have no side effects(they do not alter any state or change variables outside their scope).
    //    This makes pure functions predictable, easier to test, and more reliable in concurrent programming.
    //Explanation
    //    Pure Functions ensure that the behavior of a function is consistent and doesn't affect or rely on external states.
    //    This makes the code more modular and easier to understand.

    // Pure function that calculates the square of a number
    public static int Square(int x)
    {
        return x * x;
    }

    // Pure function that adds two numbers
    public static int Add(int a, int b)
    {
        return a + b;
    }
}

