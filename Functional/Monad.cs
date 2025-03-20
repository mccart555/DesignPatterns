using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Functional;

//A monad can be thought of as a "container" that holds a value and provides two primary operations:
//    Unit(or Return) : Wraps a value into a monad.
//    Bind(or FlatMap): Applies a function to the value inside the monad and returns a new monad.
//In C#, monads can be implemented using the Maybe or Option pattern, which helps in dealing with nullable values without using nulls directly.
//Explanation of the Code
//    Maybe Class: This class represents a monad that can hold a value or be empty(None).
//    Some Method: Wraps a value into a Maybe instance.
//    None Method: Creates an empty Maybe instance.
//    Bind Method: Applies a function to the value inside the Maybe if it has a value, otherwise returns None.
//    GetValueOrDefault Method: Returns the value if it exists, otherwise returns a default value.
//    Main Method: Here, we create a Maybe<int> instance with a value and use the Bind method to apply a function that multiplies the value by 2.
//    We also demonstrate the use of Bind on an empty Maybe instance.
//This example demonstrates how monads can be used to handle nullable values and chain computations in a consistent and predictable manner.

public class Maybe<T>
{
    private readonly T _value;
    public bool HasValue { get; }

    private Maybe(T value, bool hasValue)
    {
        _value = value;
        HasValue = hasValue;
    }

    public static Maybe<T> Some(T value) => new Maybe<T>(value, true);
    public static Maybe<T?> None() => new Maybe<T?>(default, false);

    public Maybe<U> Bind<U>(Func<T, Maybe<U>> func)
    {
        return HasValue ? func(_value) : Maybe<U?>.None()!;
    }

    public T GetValueOrDefault(T defaultValue) => HasValue ? _value : defaultValue;

    public override string ToString() => HasValue ? $"Some({_value})" : "None";
}
