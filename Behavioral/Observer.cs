using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.Behavioral;
//The Observer pattern defines a one-to-many dependency between objects, so that when one object (the subject) changes state,
//all its dependents (observers) are notified and updated automatically.

//Summary
//  Observer:           Defines a one-to-many relationship between objects, so that when one object changes state, all its dependents
//                      are notified and updated automatically.
//  Observer Interface: Defines the Update method for observers.
//  Subject Interface:  Defines methods to attach, detach, and notify observers.
//  Concrete Subject:   Maintains a list of observers and notifies them of changes.
//Concrete Observers:   Implement the Update method to define their response to notifications.

//The Observer pattern is particularly useful for implementing distributed event handling systems. By decoupling the subject
//and its observers, the pattern promotes a more flexible and maintainable design.

///Create an interface for the observers that will be notified of changes.
public interface IObserver
{
    void Update(string message);
}

//Create an interface for the subject that will notify observers of changes.
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify(string message);
}

//The concrete subject maintains a list of observers and notifies them of changes.
public class ConcreteSubject : ISubject
{
    private readonly List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify(string message)
    {
        foreach (var observer in _observers)
        {
            observer.Update(message);
        }
    }

    // Example method that triggers notifications
    public void ChangeState(string newState)
    {
        Console.WriteLine("Subject state changed to: " + newState);
        Notify(newState);
    }

    public class ConcreteObserverA : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("ConcreteObserverA received message: " + message);
        }
    }

    public class ConcreteObserverB : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("ConcreteObserverB received message: " + message);
        }
    }

}


