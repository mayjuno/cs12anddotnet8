using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Packt.Shared; // To use Person.

// No namespace declaration so this externds the Program class in the null namespace
partial class Program
{
    // A method to handle the Shout even received by the harry object.
    private static void Harry_Shout(object? sender, EventArgs e)
    {
        // If no sender, then do nothing.
        if(sender is null) return;
        // If sender is not a Person, the do nothing.
        if (sender is not Person p) return;
        Console.WriteLine($"{p.Name} is this angry : {p.AngerLevel}.");
    }

    // Another method to handle the event received by the harry object.
    private static void Harry_Shout_2(object? sender, EventArgs e)
    {
        Console.WriteLine("Stop it!");
    }
}