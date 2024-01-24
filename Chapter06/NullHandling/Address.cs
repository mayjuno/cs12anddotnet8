using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;

public class Address
{
    public string? Building;
    public string Street = string.Empty;
    public string City;
    public string Region;

    public Address()
    {
        City = string.Empty;
        Region = string.Empty;
    }

    // Call the default parameterless constructor to ensure that region is also set.
    public Address(string city) : this()
    {
        City = city;
    }
}