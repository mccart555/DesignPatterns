using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural;

// Flyweight
class CharacterX
{
    //The Flyweight design pattern is used to minimize memory usage or computational expenses by sharing as much data as possible with similar objects. It's
    //especially useful when working with a large number of objects that share common data.

    //Explanation
    //    Flyweight: The Character class represents the Flyweight object. It contains intrinsic state(shared data) such as symbol, width, height, font family,
    // and font size.The Display method takes extrinsic state (context-specific data) like row and column as parameters.
    //    FlyweightFactory: The CharacterFactory class manages the Flyweight objects.It maintains a dictionary to store and reuse Character objects.The
    // GetCharacter method returns an existing Character object if it already exists, otherwise, it creates a new one and adds it to the dictionary.
    //    Client: The Program class demonstrates how to use the Flyweight pattern.It creates a CharacterFactory object and uses it to obtain Character objects
    // for each symbol in a string (document). It then displays the characters at specified positions.
    //    When you run this code, the output will show the characters being displayed with their properties
    //Benefits of the Flyweight Pattern
    //    Memory Efficiency: By sharing common data, you can significantly reduce memory usage when dealing with a large number of similar objects.
    //    Performance Improvement: Reducing the number of objects and reusing them can improve the performance of your application.
    //
    //The Flyweight pattern is particularly useful in applications such as text editors, graphics applications, and game development where many objects need
    //to be managed efficiently.

    private char _symbol;
    private int _width;
    private int _height;
    private string _fontFamily;
    private int _fontSize;

    public CharacterX(char symbol, int width, int height, string fontFamily, int fontSize)
    {
        _symbol = symbol;
        _width = width;
        _height = height;
        _fontFamily = fontFamily;
        _fontSize = fontSize;
    }

    public void Display(int row, int column)
    {
        Console.WriteLine($"Displaying character {_symbol} at ({row},{column}) with font {_fontFamily} ({_fontSize}px)");
    }
}

// FlyweightFactory
class CharacterFactory
{
    private Dictionary<char, CharacterX> _characters = new Dictionary<char, CharacterX>();

    public CharacterX GetCharacter(char symbol)
    {
        if (!_characters.ContainsKey(symbol))
        {
            _characters[symbol] = new CharacterX(symbol, 10, 20, "Arial", 12);
        }

        return _characters[symbol];
    }
}
