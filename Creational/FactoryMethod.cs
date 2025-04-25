using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational;
/// The Factory Method pattern is used to define an interface for creating an object, but allows subclasses to alter the 
/// type of objects that will be created. It promotes loose coupling by eliminating the need to specify the exact class of 
/// object that will be created.
///
/// Summary
//    Factory Method:    Defines an interface for creating an object but lets subclasses alter the type of object that will be created.
//    Product Interface: Common interface for the objects created by the factory method.
//    Concrete Products: Implementations of the product interface.
//    Creator Class:     Declares the factory method.
//    Concrete Creators: Override the factory method to return specific products.
//This implementation provides a flexible way to instantiate objects, promoting loose coupling and making your code more scalable and maintainable.

// Start by defining a common interface or abstract class for the objects that will be created by the factory method.
public interface IProduct
{
    void DoWork();
}


// Implement the interface with concrete classes.
public class ConcreteProductA : IProduct
{
    public void DoWork()
    {
        Console.WriteLine("Factory ConcreteProductA is doing work.");
    }
}

public class ConcreteProductB : IProduct
{
    public void DoWork()
    {
        Console.WriteLine("Factory ConcreteProductB is doing work.");
    }
}


// The creator class declares the factory method, which returns an object of type IProduct. The subclasses override this method 
// to create different types of products.
public abstract class Creator
{
    // Factory method
    public abstract IProduct FactoryMethod();

    public void DoWork()
    {
        // Call the factory method to create a product
        var product = FactoryMethod();
        // Use the product
        product.DoWork();
    }
}


// Concrete creators override the factory method to return an instance of a specific product.
public class ConcreteCreatorA : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductA();
    }
}

public class ConcreteCreatorB : Creator
{
    public override IProduct FactoryMethod()
    {
        return new ConcreteProductB();
    }
}
