using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural;

// Component
abstract class Beverage
{
    //The Decorator design pattern allows behavior to be added to individual objects, dynamically, without affecting the behavior of other
    //objects from the same class. This pattern is useful for adding functionalities to objects in a flexible and extensible way.

    //Explanation
    //    Component: The Beverage abstract class defines the interface for both concrete components and decorators.It includes methods for
    //    getting the description(GetDescription) and cost(Cost) of a beverage.
    //    ConcreteComponent: The Espresso class is a concrete implementation of the Beverage class. It provides specific implementations for
    //    the GetDescription and Cost methods.
    //    Decorator: The CondimentDecorator abstract class extends the Beverage class. It contains a reference to a Beverage object (the
    //    component it decorates) and delegates the GetDescription and Cost methods to this component.
    //    ConcreteDecorators: The Milk and Sugar classes are concrete decorators that extend the CondimentDecorator class. They add their
    //    own behavior to the GetDescription and Cost methods by appending their descriptions and adding their costs to the component they
    //    are decorating.
    //    Client: The Program class demonstrates how to use the Decorator pattern.It creates an Espresso object and dynamically adds Milk
    //    and Sugar decorators to it. Each addition modifies the description and cost of the beverage.
    //
    //This pattern allows you to add functionalities to objects dynamically and flexibly, making it easier to modify behavior without
    //altering the original class definitions.

    public abstract string GetDescription();
    public abstract double Cost();
}

// ConcreteComponent
class Espresso : Beverage
{
    public override string GetDescription()
    {
        return "Espresso";
    }

    public override double Cost()
    {
        return 1.99;
    }
}

// Decorator
abstract class CondimentDecorator : Beverage
{
    protected Beverage beverage;

    public CondimentDecorator(Beverage beverage)
    {
        this.beverage = beverage;
    }

    public override string GetDescription()
    {
        return beverage.GetDescription();
    }

    public override double Cost()
    {
        return beverage.Cost();
    }
}

// ConcreteDecorator
class Milk : CondimentDecorator
{
    public Milk(Beverage beverage) : base(beverage) { }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Milk";
    }

    public override double Cost()
    {
        return beverage.Cost() + 0.30;
    }
}

class Sugar : CondimentDecorator
{
    public Sugar(Beverage beverage) : base(beverage)
    {
    }

    public override string GetDescription()
    {
        return beverage.GetDescription() + ", Sugar";
    }

    public override double Cost()
    {
        return beverage.Cost() + 0.20;
    }
}