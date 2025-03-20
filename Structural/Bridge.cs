using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural;

// The Bridge pattern is a structural design pattern that decouples an abstraction from its implementation so that the two can vary
// independently. It is useful when you need to avoid a permanent binding between an abstraction and its implementation, or when you
// want to share an implementation among multiple objects.

// Summary
//    Bridge Pattern: Decouples an abstraction from its implementation so that the two can vary independently.
//    Abstraction: Contains a reference to the implementer and defines the high-level operations.
//    Implementer Interface: Defines the operations that can be implemented in different ways.
//    Concrete Implementers: Implement the IImplementer interface.
//    Refined Abstractions: Extend the base abstraction and implement the Operation method.

// The Bridge pattern is useful when you want to avoid a permanent binding between an abstraction and its implementation, or when you
// need to share an implementation among multiple objects.It provides flexibility and promotes code reusability by allowing different
// implementations to be switched at runtime.

// Create an abstraction that contains a reference to the implementer.
public abstract class Abstraction(IImplementer implementer)
{
    protected IImplementer _implementer = implementer;

    public abstract void Operation();
}

// Create an interface for the implementer, which defines the operations that can be implemented in different ways.
public interface IImplementer
{
    void OperationImplementation();
}


// Concrete implementers implement the IImplementer interface.
public class ConcreteImplementerA : IImplementer
{
    public void OperationImplementation()
    {
        Console.WriteLine("ConcreteImplementerA: OperationImplementation");
    }
}

public class ConcreteImplementerB : IImplementer
{
    public void OperationImplementation()
    {
        Console.WriteLine("ConcreteImplementerB: OperationImplementation");
    }
}

// Refined abstractions extend the base abstraction and implement the Operation method.
public class RefinedAbstractionA(IImplementer implementer) : Abstraction(implementer)
{
    public override void Operation()
    {
        Console.WriteLine("RefinedAbstractionA: Operation");
        _implementer.OperationImplementation();
    }
}

public class RefinedAbstractionB(IImplementer implementer) : Abstraction(implementer)
{
    public override void Operation()
    {
        Console.WriteLine("RefinedAbstractionB: Operation");
        _implementer.OperationImplementation();
    }
}




