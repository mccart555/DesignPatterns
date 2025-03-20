using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural;

// Component
public abstract class FileSystemComponent(string name)
{
    //The Composite design pattern is used to treat individual objects and compositions of objects uniformly. It is especially useful
    //when you want to represent a part-whole hierarchy.

    //Explanation
    //    Component: This abstract class (FileSystemComponent) declares the common interface for both File and Directory classes.It includes
    //    a method for displaying the component(Display) and a property for the name(Name).
    //    Leaf: The File class is a leaf in the hierarchy.It extends FileSystemComponent and provides an implementation for the Display method.
    //    Composite: The Directory class is a composite that contains child components.It extends FileSystemComponent, maintains a list of
    //    child components (_children), and provides methods to add and remove child components.It also overrides the Display method to iterate
    //    over and display each child component.
    //    Client: The Program class demonstrates how to create and interact with the composite structure.It creates instances of File and Directory, adds files to directories, and displays the entire structure starting from the root directory.
    //When you run this code, the output will show a hierarchical structure of files and directories.This pattern allows you to treat both individual objects (files) and compositions of objects (directories) uniformly, making it easier to work with complex hierarchies.

    public string Name { get; set; } = name;

    public abstract void Display(int depth);
}

// Leaf
public class FileX(string name) : FileSystemComponent(name)
{
    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);
    }
}

// Composite
public class DirectoryX(string name) : FileSystemComponent(name)
{
    private List<FileSystemComponent> _children = new List<FileSystemComponent>();

    public void Add(FileSystemComponent component)
    {
        _children.Add(component);
    }

    public void Remove(FileSystemComponent component)
    {
        _children.Remove(component);
    }

    public override void Display(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);
        foreach (var component in _children)
        {
            component.Display(depth + 2);
        }
    }
}
