using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Behavioral;

// Abstract Expression
public interface IExpression
{
    //The Interpreter design pattern is a behavioral design pattern used to define a grammar and interpret sentences in that grammar.
    //It's commonly used in scenarios like parsing expressions, programming languages, or defining business rules.

    //How It Works:
    //    Context: Maintains information that is global to the interpreter.
    //    Abstract Expression: Declares an abstract Interpret method that all concrete expressions will implement.
    //    Terminal Expression: Represents leaf nodes in the grammar and implements the Interpret method.
    //    Non-Terminal Expression: Combines terminal and non-terminal expressions to handle complex grammar rules.
    //When to Use It:
    //    When you have a language or grammar to interpret.
    //    When you need a simple and extensible solution for parsing.
    //Explanation:
    //    NumberExpression: Represents numbers like 3, 5, or 2.
    //    AddExpression: Adds two expressions.
    //    SubtractExpression: Subtracts one expression from another.
    //The Client combines these expressions to represent the grammar "3 + 5 - 2" and interprets it.
    //This example demonstrates how you can build and evaluate simple expressions using the Interpreter pattern.You could easily extend
    //this by adding more operators like multiplication or division.
    //Simple Arithmetic Interpreter: Let’s create a simple interpreter for arithmetic expressions like "3 + 5 - 2".


    int Interpret();
}

// Terminal Expression (for numbers)
public class NumberExpression : IExpression
{
    private int _number;

    public NumberExpression(int number)
    {
        _number = number;
    }

    public int Interpret()
    {
        return _number;
    }
}

// Non-Terminal Expression (for addition)
public class AddExpression : IExpression
{
    private IExpression _leftExpression;
    private IExpression _rightExpression;

    public AddExpression(IExpression leftExpression, IExpression rightExpression)
    {
        _leftExpression = leftExpression;
        _rightExpression = rightExpression;
    }

    public int Interpret()
    {
        return _leftExpression.Interpret() + _rightExpression.Interpret();
    }
}

// Non-Terminal Expression (for subtraction)
public class SubtractExpression : IExpression
{
    private IExpression _leftExpression;
    private IExpression _rightExpression;

    public SubtractExpression(IExpression leftExpression, IExpression rightExpression)
    {
        _leftExpression = leftExpression;
        _rightExpression = rightExpression;
    }

    public int Interpret()
    {
        return _leftExpression.Interpret() - _rightExpression.Interpret();
    }
}