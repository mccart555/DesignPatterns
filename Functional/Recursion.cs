using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Functional;

public class Recursion
{

    //Recursion is a design pattern where a function calls itself to solve a problem. It is particularly useful for problems that can be broken down
    //into smaller, similar sub-problems. The key aspects of a recursive function are:
    //    A base case that stops the recursion.
    //    A recursive case that reduces the problem into smaller instances and calls the function itself.
    //Explanation
    //    Recursion allows you to solve complex problems by dividing them into simpler sub-problems, following the divide-and-conquer approach. It is
    //    important to ensure that the base case is defined correctly to avoid infinite recursion.
    //    Recursive function to calculate the factorial of a number

    //Explanation of the Code
    //    Factorial Function: This function takes an integer n and calculates its factorial using recursion.
    //    Base Case: If n is 0 or 1, the function returns 1 AND THE RECURSION ENDS - this is VERY important!
    //    Recursive Case: For other values of n, the function calls itself with n - 1 and multiplies the result by n.
    //    Main Method: Here, we test the Factorial function by calculating the factorial of 5 and printing the result.
    //This example demonstrates how recursion can be used to solve problems by breaking them down into smaller, similar sub-problems.

    public static int Factorial(int n)
    {
        // Base case: factorial of 0 or 1 is 1
        if (n == 0 || n == 1)
        {
            return 1;
        }
        // Recursive case: n * factorial of (n - 1)
        else
        {
            return n * Factorial(n - 1);
        }
    }
}

