using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Packt.Shared;
// This file simulates an auto-generated class.
public partial class Person
{
    #region Properties: Methods to get  and/or set data or state.
    // A readonly property defiend using C# to 5 syntax
    public string Origin
    {
        get
        {
            return string.Format("{0} was born {1}", Name, HomePlanet);
        }
    }
    // Two readonly properties defined using c# 6 or later
    // lambda expression body syntax.
    public string Greeting => $"{Name} says 'Hello!'";
    public int Age => DateTime.Now.Year - Born.Year;

    // Defining settable properties
    // A read-write property  using C# 3 auto-syntax.
    public string? FavoriteIceCream { get; set; }

    // A provate backing field to store the property value.
    private string? _favoritePrimaryColor;

    // A public property to read and write to the field.
    public string? FavoritePrimaryColor
    {
        get
        {
            return _favoritePrimaryColor;
        }
        set
        {
            switch (value?.ToLower())
            {
                case "red":
                case "blue":
                case "green":
                    _favoritePrimaryColor = value;
                    break;
                default:
                    throw new ArgumentException(
                        $"{value} is not a primary color. " +
                        "Choose from: red, blue, green.");

            }
            
        }
    }

    private WondersOfTheAncientWorld _favoriteAncientWonder;
    public WondersOfTheAncientWorld FavoriteAncientWonder
    { get
        {
            return _favoriteAncientWonder;
        }
        set
        {
            string wounderName = value.ToString();
            if (wounderName.Contains(','))
            {
                throw new ArgumentException(
                    message: "Favorite ancient wonder can only have a single enum value",
                    paramName: nameof(FavoriteAncientWonder));
            }
            if (!Enum.IsDefined(typeof(WondersOfTheAncientWorld), value))
            {
                throw new ArgumentException(
                    $"{value} is not a member of the WoundersOfTheAncientWorld enum.",
                    paramName: nameof(FavoriteAncientWonder));
            }
            _favoriteAncientWonder = value;
        }
    }


    #endregion

    /*
     * Definging Indexers
     */
    #region Indexers: Properties that use array syntax to access data or state.
    public Person this[int index]
    {
        get
        {
            return Children[index];  // Pass on to the List<T> indexer.
        }
        set
        {
            Children[index] = value;
        }
    }

    #endregion

    // A read-only string indexer.
    public Person this[string name]
    {
        get
        {
            return Children.Find(p => p.Name == name);
        }
    }
}