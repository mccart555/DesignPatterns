using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Functional;

public class FunctionCompositionExample
{
    //Function Composition involves combining two or more functions to form a new function. The result of one function is passed as the input to the next
    //function in the chain. This approach simplifies complex operations by breaking them down into smaller, manageable functions.
    //Explanation of the Code
    //    MultiplyByTwo and AddTen: These are simple functions that perform basic transformations on an integer.
    //    MultiplyByTwo multiplies the input by 2.
    //    AddTen adds 10 to the input.
    //    Compose Function: This function takes two functions(f1 and f2) as parameters and returns a new function that applies f1 to the input and then
    //    applies f2 to the result.It effectively composes the two functions.
    //    Main Method: Here, we create a list of integers and use the Compose function to combine MultiplyByTwo and AddTen. We then apply the composed
    //    function to each number in the list using Select, and print the transformed numbers.
    //This example demonstrates how function composition allows you to create more complex transformations by combining simple functions.

    // Function to multiply a number by 2
    public static int MultiplyByTwo(int x)
    {
        return x * 2;
    }

    // Function to add 10 to a number
    public static int AddTen(int x)
    {
        return x + 10;
    }

    // Function composition: Compose MultiplyByTwo and AddTen
    public static Func<int, int> Compose(Func<int, int> f1, Func<int, int> f2)
    {
        return x => f2(f1(x));
    }

}
