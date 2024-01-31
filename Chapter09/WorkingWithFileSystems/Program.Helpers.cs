using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// null namespace to merge with auto-generated Program
partial class Program
{
    private static void SectionTitle(string title)
    {
        WriteLine();
        ConsoleColor previousColor = ForegroundColor;
        // Use a color that stands out on your system.
        ForegroundColor = ConsoleColor.DarkYellow;
        WriteLine($"*** {title}***");
        ForegroundColor = previousColor;
    }
}
