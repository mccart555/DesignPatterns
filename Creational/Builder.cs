using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational;

public class Computer
{
    //The Builder design pattern is an Object-Oriented design pattern that is used to construct complex objects step by step. It separates the
    //construction of an object from its representation, allowing the same construction process to create different representations.
    //
    //Explanation
    //    Builder Design Pattern involves the following components:
    //    Builder Interface: Defines the methods needed to build the parts of the product.
    //    Concrete Builder: Implements the Builder interface and provides specific implementations to build the parts of the product.
    //    Product: The complex object that is being constructed.
    //    Director: Responsible for managing the construction process and using the Builder interface to construct the product.
    //
    //Explanation of the Code
    //    Computer Class: This is the product class that represents the complex object being constructed.
    //    IComputerBuilder Interface: This interface defines the methods needed to build the parts of the Computer object.
    //    GamingComputerBuilder Class: This class implements the IComputerBuilder interface and provides specific implementations to set the CPU, RAM, Storage, and GPU.
    //    ComputerDirector Class: This class manages the construction process and uses the IComputerBuilder to construct the Computer object.
    //    Main Method: Here, we create a GamingComputerBuilder instance, pass it to the ComputerDirector, and construct the Computer object. Finally, we print the constructed Computer.
    //
    //The Builder pattern allows for constructing complex objects in a step-by-step manner, making the construction process more flexible and modular.

    // Product class
    public string? Cpu { get; set; }
    public string? Ram { get; set; }
    public string? Storage { get; set; }
    public string? Gpu { get; set; }

    public override string ToString()
    {
        return $"Computer [CPU={Cpu}, RAM={Ram}, Storage={Storage}, GPU={Gpu}]";
    }
}

// Builder interface
public interface IComputerBuilder
{
    void SetCPU();
    void SetRAM();
    void SetStorage();
    void SetGPU();
    Computer GetComputer();
}

// Concrete Builder
public class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void SetCPU()
    {
        _computer.Cpu = "Intel Core i9";
    }

    public void SetRAM()
    {
        _computer.Ram = "32GB DDR4";
    }

    public void SetStorage()
    {
        _computer.Storage = "1TB SSD";
    }

    public void SetGPU()
    {
        _computer.Gpu = "NVIDIA GeForce RTX 3080";
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}

// Director
public class ComputerDirector(IComputerBuilder computerBuilder)
{
    public void ConstructComputer()
    {
        computerBuilder.SetCPU();
        computerBuilder.SetRAM();
        computerBuilder.SetStorage();
        computerBuilder.SetGPU();
    }

    public Computer GetComputer()
    {
        return computerBuilder.GetComputer();
    }
}
