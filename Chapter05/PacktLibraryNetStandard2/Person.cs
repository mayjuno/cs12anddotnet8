using System;
using System.Collections.Generic;
using System.Text;

// All types in this file will be defined in this file-scoped namespace.
namespace Packt.Shared;
public partial class Person : Object
{
    #region Fields: Data or state for this person.

    public string? Name; // ? means it can be null.
    public DateTimeOffset Born;

    // This have been moved to PersonAutoGen.cs as property.
  //  public WondersOfTheAncientWorld FavoriteAncientWonder;
    public WondersOfTheAncientWorld BucketList;
    public List<Person> Children = new();

    // Constant fields: Values that are fixed at compilation.
    public const string Species = "Homo Sapiens";

    // Read-only fields: Values that can be set at runtime.
    public readonly string HomePlanet = "Earth";
    public readonly DateTime Instantiated;
    #endregion
    //--------------------------------------------------------
    #region Constructors: Initialize state for this person.
    public Person()
    {
        // Constructors can set default values for fields.
        // including any read-only fields like Instantiated.
        Name = "Unknown";
        Instantiated = DateTime.Now;
    }

    public Person(string initialName, string homePlanet)
    {
        Name = initialName;
        HomePlanet = homePlanet;
        Instantiated = DateTime.Now;
    }
    #endregion

    //--------------------------------------------------------
    #region Methods: Behavior for this person. Action the type can perform.
    public void WriteToConsole()
    {
        WriteLine($"{Name} was born on {Born:dddd}");
    }

    public string GetOrigin()
    {
        return $"{Name} was born on {HomePlanet}";
    }

    // Defining and passing parameters to a method.
    public string SayHello() => $"{Name} says 'Hello!'";
    public string SayHello(string name) => $"{Name} says 'Hello, {name}!'";

    // Passing optional parameters.
    public string OptionalParameters(
        int count,
        string command = "Run!", 
        double number = 0.0, 
        bool active = true)
    {
        return string.Format(format: "command is {0}, number is {1}, active is {2}",
            arg0: command, arg1: number, arg2: active);
    }

    // Controlling how parameters are passed.
    public void PassingParameters(int w, in int x, ref int y, out int z)
    {
        // out parameters cannot have a default and
        // they must be initialized inside the method.
        z = 100;
        // Increment each parameter except the read-only parameter x.
        w++;
        //x++;  // Gives a compile-time error.
        y++;
        z++;
        WriteLine($"In the method: w={w}, x={x}, y={y}, z={z}");
    }

    // Method that returns a tuple: (string, number).
    public (string, int) GetFruit()
    {
        return ("Apples", 5);
    }

    // Method that returns a tuple with named fields.
    public (string Name, int Number) GetNamedFruit()
    {
        return (Name:"Apples",Number: 5);
    }



    /* Implementating functionality using local functions
     */
    // method with a local function.
    public static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException($"{nameof(number)} cannot be less than zero.");
        }
        return localFactorial(number);

        int localFactorial(int loaclNumber) // local function
        {
            if (loaclNumber == 1) return 1;
            return loaclNumber * Factorial(loaclNumber - 1);
        }
    }

    #endregion
}


