using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;   // TO use [GeneratedRegex] attribute.

partial class Program
{
    [GeneratedRegex(DigitsOnlyText,RegexOptions.IgnoreCase)]
    private static partial Regex DigitsOnly();

    [GeneratedRegex(CommaSeparatorText,RegexOptions.IgnoreCase)]
    private static partial Regex CommaSeparator();
}
