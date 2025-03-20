using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural;

// Subject interface
interface ISubjectX
{
    //The Proxy design pattern provides a surrogate or placeholder for another object to control access to it. It can be used for various purposes,
    //such as lazy initialization, access control, logging, and more.
    //Explanation
    //Subject Interface: The ISubject interface declares the common interface for both the RealSubject and the Proxy.It includes the Request method.
    //    RealSubject Class: The RealSubject class is the actual object that performs the real work.It implements the ISubject interface and provides
    // the specific implementation for the Request method.
    //    Proxy Class: The Proxy class also implements the ISubject interface. It holds a reference to the RealSubject object and controls access to it.
    // In this example, the Proxy class performs logging before delegating the request to the RealSubject.
    //    Client: The Program class demonstrates how to use the Proxy pattern.It creates an instance of the Proxy and calls the Request method.The Proxy
    // handles the request by first logging it and then delegating it to the RealSubject.
    //
    //When you run this code, the output will show the Proxy logging the request and then delegating it to the RealSubject
    //Benefits of the Proxy Pattern
    //    Lazy Initialization: The Proxy can defer the creation of the RealSubject until it is actually needed.
    //    Access Control: The Proxy can control access to the RealSubject, such as checking permissions.
    //    Logging: The Proxy can add logging or other cross-cutting concerns before delegating the request to the RealSubject.
    //    Remote Proxy: The Proxy can represent a remote object, handling the communication between the client and the remote object.
    //The Proxy pattern is versatile and can be used in various scenarios where controlling access to an object or adding additional behavior is required.

    void Request();
}

// RealSubject class
class RealSubject : ISubjectX
{
    public void Request()
    {
        Console.WriteLine("RealSubject: Handling request.");
    }
}

// Proxy class
class Proxy : ISubjectX
{
    private RealSubject? _realSubject;

    public void Request()
    {
        if (_realSubject == null)
        {
            _realSubject = new RealSubject();
        }
        Console.WriteLine("Proxy: Logging request.");
        _realSubject.Request();
    }
}