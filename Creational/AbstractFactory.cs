using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational;

//The Abstract Factory pattern is a creational design pattern that provides an interface for creating families of related or dependent objects without
//specifying their concrete classes. It's useful when your system needs to be independent of how its objects are created and represented, and when you
//want to provide a library of products without revealing their implementations.
// Explanation
//    Abstract Products: Declare interfaces for a set of distinct but related products that make up a product family.
//    Concrete Products: Define products to be created by the corresponding concrete factories.
//    Abstract Factory:  Declares a set of methods for creating abstract products.
//    Concrete Factories: Implement creation methods of the abstract factory to create concrete product instances.
//    Client: Uses only interfaces declared by the abstract factory and abstract products.

// When to Use the Abstract Factory Pattern
//    Independence from Concrete Classes: When your code needs to work with families of related products and you want to abstract away from concrete
//    implementations.
//    Consistency Among Products: When you want to ensure that products in a family are used together and are compatible with each other.
//    Configurable Systems: When your system should be configured with one of multiple families of products.

// Advantages
//    Isolation of Concrete Classes: Clients use interfaces, so they remain independent of the concrete implementations.
//    Ease of Exchange: Changing the product family requires changing the concrete factory, making it easy to introduce new product variants.
//    Consistency: Ensures that products of a family are compatible and used together.

// Disadvantages
//    Complexity: Adding new products to the existing structure can be challenging because it requires extending the abstract factory interface and all
//    concrete factory classes.

// Key Takeaways
//    Abstract Factory allows you to produce families of related objects without specifying their concrete classes.
//    Clients remain independent of the concrete products they use, promoting loose coupling.
//    Extensibility: New product families can be introduced without changing existing code, adhering to the Open/Closed Principle.

// Conclusion
//    The Abstract Factory pattern is powerful when you need to provide a high level of flexibility and scalability in your application design.By
//    following the principles laid out in this pattern, you can write code that's easier to maintain, extend, and adapt to new requirements.


public interface IProd
{
    string GetName();
}

public interface IService
{
    string GetService();
}

public class ProductA : IProd
{
    public string GetName()
    {
        return "ProductA";
    }
}

public class ProductB : IProd
{
    public string GetName()
    {
        return "ProductB";
    }
}

public class ServiceA : IService
{
    public string GetService()
    {
        return "ServiceA";
    }
}

public class ServiceB : IService
{
    public string GetService()
    {
        return "ServiceB";
    }
}

public interface IAbstractFactory
{
    IProd CreateProduct();
    IService CreateService();
}

public class FactoryA : IAbstractFactory
{
    public IProd CreateProduct()
    {
        return new ProductA();
    }

    public IService CreateService()
    {
        return new ServiceA();
    }
}

public class FactoryB : IAbstractFactory
{
    public IProd CreateProduct()
    {
        return new ProductB();
    }

    public IService CreateService()
    {
        return new ServiceB();
    }
}
