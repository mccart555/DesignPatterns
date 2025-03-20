using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral;

// Handler interface
abstract class Handler
{
    //The Chain of Responsibility design pattern allows an object to pass a request along a chain of potential handlers until the
    //request is handled. This pattern decouples the sender of a request from its receivers by giving more than one object a chance
    //to handle the request.

    //Explanation
    //    Handler Interface: The Handler abstract class defines an interface for handling requests.It includes a method to set the
    //    successor (SetSuccessor) and an abstract method for handling requests(HandleRequest).
    //    Concrete Handlers: The ConcreteHandler1, ConcreteHandler2, and ConcreteHandler3 classes are concrete implementations of
    //    the Handler class. Each one handles a specific range of requests.If a handler cannot process the request, it passes the
    //    request to its successor.
    //    Client: The Program class demonstrates how to use the Chain of Responsibility pattern.It creates instances of the concrete
    //    handlers and sets up the chain by setting the successor for each handler. It then processes a series of requests by passing
    //    them to the first handler in the chain (h1).
    //When you run this code, the output will show which handler processes each request.
    //Benefits - promotes 1st and 2nd SOLID Single repository and Open Closed and principles and allows for flexibility in assigning
    //responsibilities

    protected Handler? _successor;

    public void SetSuccessor(Handler successor)
    {
        _successor = successor;
    }

    public abstract void HandleRequest(int request);
}

// ConcreteHandler1
class ConcreteHandler1 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 0 && request < 10)
        {
            Console.WriteLine($"{this.GetType().Name} handled request {request}");
        }
        else if (_successor != null)
        {
            _successor.HandleRequest(request);
        }
    }
}

// ConcreteHandler2
class ConcreteHandler2 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 10 && request < 20)
        {
            Console.WriteLine($"{this.GetType().Name} handled request {request}");
        }
        else if (_successor != null)
        {
            _successor.HandleRequest(request);
        }
    }
}

// ConcreteHandler3
class ConcreteHandler3 : Handler
{
    public override void HandleRequest(int request)
    {
        if (request >= 20 && request < 30)
        {
            Console.WriteLine($"{this.GetType().Name} handled request {request}");
        }
        else if (_successor != null)
        {
            _successor.HandleRequest(request);
        }
    }
}
