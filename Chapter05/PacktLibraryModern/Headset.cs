﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Defining a primary constructor for a class
 */
namespace Packt.Shared;
public class Headset(string manufacturer, string productName)
{
    public string Manufacturer { get; set; } = manufacturer;
    public string ProductName { get; set; } = productName;

    // Default parameterless constructor calls the primary constructor.
    public Headset(): this("Microsoft", "HoloLens") { } // This("Unknown", "Unknown") { }
}

