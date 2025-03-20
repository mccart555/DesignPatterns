using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioral;

// The Mediator pattern is used to reduce coupling between classes that communicate with each other.Instead of classes referencing each
// other directly, they communicate through a central mediator.This promotes loose coupling and makes the system easier to maintain and extend.
// Summary
//    Mediator Pattern: Reduces coupling between classes by making them communicate through a central mediator.
//    Mediator Interface: Defines the communication methods for the mediator.
//    Colleague Class: Represents participants that interact with the mediator.
//    Concrete Colleagues: Implement specific actions and notify the mediator of events.
//    Concrete Mediator: Manages communication between colleagues and directs actions based on events.
// The Mediator pattern is useful for managing complex interactions between objects, making the system more modular and easier to maintain.

// Create an interface that defines the communication methods for the mediator.
public interface IMediator
{
    void Notify(object sender, string eventCode);
}

// Create an abstract class for colleagues that interact with the mediator.
public abstract class Colleague
{
    protected IMediator _mediator;

    public Colleague(IMediator mediator)
    {
        _mediator = mediator;
    }
}

// Concrete colleagues will interact with the mediator and notify it of events.
public class ConcreteColleague1 : Colleague
{
    public ConcreteColleague1(IMediator mediator) : base(mediator)
    {
    }

    public void DoAction()
    {
        Console.WriteLine("Colleague 1 is doing an action.");
        _mediator.Notify(this, "Action1");
    }

    public void RespondToAction()
    {
        Console.WriteLine("Colleague 1 is responding to an action.");
    }
}

public class ConcreteColleague2 : Colleague
{
    public ConcreteColleague2(IMediator mediator) : base(mediator)
    {
    }

    public void DoAnotherAction()
    {
        Console.WriteLine("Colleague 2 is doing another action.");
        _mediator.Notify(this, "Action2");
    }

    public void RespondToAnotherAction()
    {
        Console.WriteLine("Colleague 2 is responding to another action.");
    }
}

// The concrete mediator will manage the communication between the colleagues.
public class ConcreteMediator : IMediator
{
    private ConcreteColleague1? _colleague1;
    private ConcreteColleague2? _colleague2;

    public void SetColleague1(ConcreteColleague1 colleague1)
    {
        _colleague1 = colleague1;
    }

    public void SetColleague2(ConcreteColleague2 colleague2)
    {
        _colleague2 = colleague2;
    }

    public void Notify(object sender, string eventCode)
    {
        if (eventCode == "Action1")
        {
            Console.WriteLine("Mediator responds to Action1 and triggers Action2.");
            _colleague2?.RespondToAnotherAction();
        }
        else if (eventCode == "Action2")
        {
            Console.WriteLine("Mediator responds to Action2 and triggers Action1.");
            _colleague1?.RespondToAction();
        }
    }
}



