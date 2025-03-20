using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesignPatterns.Behavioral;

// Command Interface
public interface ICommand
{
    //The Command design pattern is a behavioral pattern that encapsulates a request as an object, thereby allowing you to parameterize objects with requests, queue or log requests, and support undoable operations.
    //Key Components of the Command Pattern
    //  Command Interface Declares the Execute method for all commands.
    //  Concrete Command Implements the Execute method and binds a receiver object.
    //  Receiver The actual object that performs the action when the command is executed.
    //  Invoker Stores and executes the command.
    //  Client Creates the command and assigns it to the invoker.
    //Explanation
    //  Command Interface (ICommand) Defines the Execute and Undo methods that all commands will implement.
    //  Concrete Commands (TurnOnCommand and TurnOffCommand) These encapsulate the actions for turning the light on and off.They interact with the receiver (the Light object).
    //  Receiver(Light) Performs the actual action(turning on or off).
    //  Invoker(RemoteControl) Stores a command and triggers its execution through the PressButton method.It also supports undo functionality with PressUndo.
    //  Client(Program) Creates the receiver, commands, and assigns commands to the invoker.
    //Benefits
    //  Encapsulation: The command pattern encapsulates requests, making it easy to extend and reuse.
    //  Decoupling: The invoker does not need to know the details of how the actions are performed.
    //  Undo/Redo: Enables easy implementation of undo/redo functionality.
    //This example is just a starting point. You can extend it to handle more complex scenarios, like queuing commands or executing multiple commands at once!

    //Example in C#: Smart Home Automation
    //Let’s implement a smart home system where you can turn the light on and off using the Command pattern.


    void Execute();
    void Undo();
}

// Receiver
public class Light
{
    public void TurnOn()
    {
        Console.WriteLine("The light is ON");
    }

    public void TurnOff()
    {
        Console.WriteLine("The light is OFF");
    }
}

// Concrete Command: TurnOnCommand
public class TurnOnCommand : ICommand
{
    private Light _light;

    public TurnOnCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOn();
    }

    public void Undo()
    {
        _light.TurnOff();
    }
}

// Concrete Command: TurnOffCommand
public class TurnOffCommand : ICommand
{
    private Light _light;

    public TurnOffCommand(Light light)
    {
        _light = light;
    }

    public void Execute()
    {
        _light.TurnOff();
    }

    public void Undo()
    {
        _light.TurnOn();
    }
}

// Invoker
public class RemoteControl
{
    private ICommand _command;

    public void SetCommand(ICommand command)
    {
        _command = command;
    }

    public void PressButton()
    {
        _command.Execute();
    }

    public void PressUndo()
    {
        _command.Undo();
    }
}
