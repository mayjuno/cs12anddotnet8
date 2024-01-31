﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Packt.Shared;


public static class StringExtensions
{
    public static bool IsValidEmail(this string input)
    {
        // use a simple regular expression to check
        // that the input string is a valid email.
        return Regex.IsMatch(input, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
    }
}