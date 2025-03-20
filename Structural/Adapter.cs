using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural;

// The Adapter pattern is a structural design pattern that allows objects with incompatible interfaces to work together. It acts as a bridge
// between two incompatible interfaces.

// Summary
//    Adapter Pattern: Allows objects with incompatible interfaces to work together by creating an adapter that acts as a bridge.
//    Target Interface: Defines the domain-specific interface that the client expects.
//    Adaptee: Existing class with an incompatible interface.
//    Adapter: Makes the adaptee's interface compatible with the target interface.

//The Adapter pattern is particularly useful when you need to integrate a new component into an existing system without modifying the existing
//code.It promotes flexibility and reusability by allowing you to use existing classes that don't match the required interface.

//Create an interface that the client expects to work with.
public interface ITarget
{
    string GetRequest();
}


// The adaptee is the existing class that has an incompatible interface.
public class Adaptee
{
    public string GetSpecificRequest()
    {
        return "Specific request";
    }
}

// The adapter makes the adaptee's interface compatible with the target interface.
public class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        _adaptee = adaptee;
    }

    public string GetRequest()
    {
        // Translate the method of the adaptee to the target interface method
        return $"This is '{_adaptee.GetSpecificRequest()}'";
    }
}
