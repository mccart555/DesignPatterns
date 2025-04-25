using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational;

public abstract class ShapeX
{
    //The Prototype design pattern is a creational design pattern that allows you to create new objects by copying an existing object, known as the
    //prototype. This pattern is useful when the cost of creating a new object is prohibitive or when you want to avoid the complex initialization
    //process.
    //Explanation
    //    Prototype Design Pattern involves the following components:
    //    Prototype Interface: Defines a method for cloning itself.
    //    Concrete Prototype: Implements the cloning method to create a copy of itself.
    //    Client: Uses the prototype to create new objects.
    //
    //Explanation of the Code
    //    Shape Class: This is the abstract prototype class that defines the Clone method.  It also has common properties like Id and Type.
    //    Circle and Rectangle Classes: These are concrete prototypes that implement the Clone method using the MemberwiseClone method, which
    //    creates a shallow copy of the object. They also override the ToString method to provide a string representation of the objects.


    public string? Id { get; set; }
    public string? TypeX { get; set; }

    public abstract ShapeX Clone();
}

public class CircleX : ShapeX
{
    public double Radius { get; set; }

    public CircleX()
    {
        TypeX = "Circle";
    }

    public override ShapeX Clone()
    {
        return (ShapeX)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Shape: {TypeX}, Id: {Id}, Radius: {Radius}";
    }
}

public class RectangleX : ShapeX
{
    public double Width { get; set; }
    public double Height { get; set; }

    public RectangleX()
    {
        TypeX = "Rectangle";
    }

    public override ShapeX Clone()
    {
        return (ShapeX)MemberwiseClone();
    }

    public override string ToString()
    {
        return $"Shape: {TypeX}, Id: {Id}, Width: {Width}, Height: {Height}";
    }
}
