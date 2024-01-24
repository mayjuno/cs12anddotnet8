using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packt.Shared;

// Extending classes to add functionlity
public class Employee : Person
{
    public string? EmployeeCode { get; set; }
    public DateOnly HireDate { get; set; }

    // Hiding members
    public new void WriteToConsole()
    {
        WriteLine(format:"{0} was born on {1:dd/MM/yy} and hired on {2:dd/MM/yy}.",Name, Born, HireDate);
    }
    public override string ToString()
    {
        //return base.ToString();
        return $"{Name}'s code is {EmployeeCode}.";
    }
}