using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Functional;
public class Person(string name, int age)
{
    //Immutability ensures that once a data structure is created, its state cannot be changed. If
    //you need a different value, you create a new instance with the updated values.This approach
    //reduces bugs related to state changes and makes concurrent programming easier.
    //Explanation of the Code
    //    Person Class: The Person class has two immutable properties: Name and Age.Once these properties are set via the constructor, they cannot be changed.
    //    WithUpdatedAge Method: This method creates a new Person instance with an updated age while keeping the original instance unchanged.
    //    Main Method: Here, we create an immutable Person instance, then create a new instance with an updated age, and print both to demonstrate that the original instance remains unchanged.
    //    This example demonstrates how immutability can help in creating predictable and maintainable code.

    public string Name { get; } = name;
    public int Age { get; } = age;

    // Constructor to initialize immutable properties

    // Method to create a new Person instance with an updated age
    public Person WithUpdatedAge(int newAge)
    {
        return new Person(Name, newAge);
    }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}

