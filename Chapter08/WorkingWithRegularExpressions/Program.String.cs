using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;  // TO use [StringSyntax]
partial class Program
{
    [StringSyntax(StringSyntaxAttribute.Regex)]
    private const string DigitsOnlyText = @"^\d+$";
    [StringSyntax(StringSyntaxAttribute.Regex)]
    private const string CommaSeparatorText =
        "(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)";
    [StringSyntax(StringSyntaxAttribute.DateTimeFormat)]
    private const string FulluDateTime = "dddd, d MMMM yyyy.";

}
