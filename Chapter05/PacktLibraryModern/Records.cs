using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;
/*
 * Working with record types
 * 
 * init-only properties
 * Page - 283
 */
public class ImmutablePerson
{
    public string? FirstName { get; init; }
    public string? LastName { get; init; }
}

public record ImmutableVehicle
{
    public int Wheels { get; init; }
    public string? Color { get; init; }
    public string? Brand { get; init; }
}

// Simpler syntax to define a record that auto-generate the properties
// constructor and deconstructor
public record ImmutableAnimal(string Name, string Species);

