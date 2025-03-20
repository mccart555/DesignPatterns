using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural;
//The Facade pattern provides a unified interface to a set of interfaces in a subsystem, making it easier to use and understand.
//It helps to simplify interactions between the client and the complex subsystem.

//Summary
//    Facade Pattern: Provides a simplified interface to a complex subsystem.
//    Subsystem Classes: Perform the actual work and have complex interfaces.
//    Facade Class: Delegates client requests to the appropriate subsystem classes through a simplified interface.

//The Facade pattern is useful when you need to simplify the interaction with a complex subsystem or when you want to decouple the
//client from the subsystem's implementation details. By using a Facade, you can make your code more readable, maintainable, and
//easier to work with.

//First, define the classes that make up the subsystem.These classes perform the actual work but might have complex interfaces.
public class SubsystemA
{
    public void OperationA()
    {
        Console.WriteLine("SubsystemA: OperationA");
    }
}

public class SubsystemB
{
    public void OperationB()
    {
        Console.WriteLine("SubsystemB: OperationB");
    }
}

public class SubsystemC
{
    public void OperationC()
    {
        Console.WriteLine("SubsystemC: OperationC");
    }
}

//The Facade class provides a simplified interface to the subsystem. It delegates client requests to the appropriate subsystem classes.
public class Facade
{
    private readonly SubsystemA _subsystemA = new();
    private readonly SubsystemB _subsystemB = new();
    private readonly SubsystemC _subsystemC = new();

    public void Operation1()
    {
        Console.WriteLine("Facade: Operation1");
        _subsystemA.OperationA();
        _subsystemB.OperationB();
    }

    public void Operation2()
    {
        Console.WriteLine("Facade: Operation2");
        _subsystemB.OperationB();
        _subsystemC.OperationC();
    }
}