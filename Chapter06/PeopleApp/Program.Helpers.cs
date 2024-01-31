﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Packt.Shared; 

partial class Program
{
    private static void OutputPeopleNames(IEnumerable<Person?> people, string title)
    {
        Console.WriteLine(title);
        foreach(Person? p in people)
        {
            Console.WriteLine("     {0}", 
                p is null ? "<null> Person" : p.Name ?? "<null> Name");
            /* 
              if p is null  then output: <null> Person
              else output: p.Name
              unless p.Name is null then output: <null> Name
             */
        }
    }
}
