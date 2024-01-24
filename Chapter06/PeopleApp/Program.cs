using Packt.Shared;
Person harry = new()
{
    Name = "Harry",
    Born = new(2001, 3, 25,0,0,0,TimeSpan.Zero)
};
harry.WriteToConsole();

// Implementing functionality using methods.
Person lamech  = new() { Name= "Lamech" };
Person adha = new() { Name = "Adha" };
Person zillah = new() { Name = "Zillah" };

// Call the instance method to marry Lamech and Adha.
lamech.Marry(adha);

// Call the static method to marry Lamech and Zillah.
//Person.Marry(lamech, zillah);  // commented becauseof using + operator
if(lamech + zillah)
{
    Console.WriteLine($"{lamech.Name} and {zillah.Name} successfully got married.");
}

lamech.OutputSpouses();
adha.OutputSpouses();
zillah.OutputSpouses();

// Call the instance method to make a baby.
Person baby1 = lamech.ProcreateWith(adha);
baby1.Name = "Jabal";
Console.WriteLine($"{baby1.Name} was born on {baby1.Born}");

// Call the static method to make a baby.
Person baby2 = Person.Procreate(zillah, lamech);
baby2.Name = "Tubalcain";

// Use the * operator to "multiply".
Person baby3 = lamech * adha;
baby3.Name = "Jubal";

Person baby4 = zillah * lamech;
baby4.Name = "Naamah";

adha.WriteChildrenToConsole();
zillah.WriteChildrenToConsole();
lamech.WriteChildrenToConsole();

for (int i =0; i < lamech.Children.Count; i++)
{
   Console.WriteLine("{0}'s child #{1} is named \"{2}\".", lamech.Name, i, lamech.Children[i].Name);
}

/*==============================================================================
 * Working with non-generic  and generic types
 * =============================================================================*/
Console.WriteLine("-------------------------------------------------------");
// Non-generic lookup collection.
System.Collections.Hashtable lookupObject = new();
lookupObject.Add(1, "Alpha"); 
lookupObject.Add(2, "Beta");
lookupObject.Add(3, "Gamma");
lookupObject.Add(harry, "Delta");  //"harry" is a Person object is also a key

int key = 2; // Look up the value that has 2 as its key.
Console.WriteLine(format:"Key {0} has value: {1}", key, lookupObject[key]);

// Look up the value that has "harry" as its key.
Console.WriteLine(format: "Key {0} has value: {1}", harry, lookupObject[harry]);


// Working with generic types

// Define a Generic lookup collection.
System.Collections.Generic.Dictionary<int, string> lookupIntString = new();
lookupIntString.Add(1, "Alpha");
lookupIntString.Add(2, "Beta");
lookupIntString.Add(3, "Gamma");
lookupIntString.Add(4, "Delta");  //"harry" key change to 4
/*
Error	CS1503	Argument 1: cannot convert from 'Packt.Shared.Person' to 'int'	
PeopleApp	C:\cs12dotnet8\Chapter06\PeopleApp\Program.cs	79	Active	
 */

key = 3;
Console.WriteLine(format: "Key {0} has value: {1}", key, lookupIntString[key]);

/*=======================================================
 * Defining and Handling delegates P-309
 =======================================================*/

// Assign the method to the Shout delegate.
//harry.Shout = Harry_Shout;
// Assign the method to the Shout event delegate.
harry.Shout += Harry_Shout;
harry.Shout += Harry_Shout_2;


// Call the Poke method that eventually raises the Shout event.
harry.Poke();
harry.Poke();
harry.Poke();
harry.Poke();

Console.WriteLine("---------------------------------------------------");
/*
 Commapring objects when sorting
 */

Person?[] people =
{
    null,
    new() { Name = "Simon" },
    new() { Name = "Jenny"},
    new() { Name = "Adam"},
    new() { Name = null},
    new() { Name = "Richard"}
};

OutputPeopleNames(people, "Initial list of people: ");
Array.Sort(people);
OutputPeopleNames(people, "After sorting using Person's IComparable implementation: ");


Array.Sort(people, new PersonComparer());
OutputPeopleNames(people, "After sorting using PersonComparer's IComparer implementation: ");
Console.WriteLine("------------------------------------------------------------------");

/*===============================================================
 Defining Structure types
 ================================================================*/

DisplacementVector dv1 = new(3, 5);
DisplacementVector dv2 = new(-2, 7);
DisplacementVector dv3 = dv1 + dv2;
Console.WriteLine($"({dv1.X}, {dv1.Y}) + ({dv2.X}, {dv2.Y}) = ({dv3.X},{ dv3.Y})");

DisplacementVector dv4 = new();
Console.WriteLine($"({dv4.X}, {dv4.Y})");


DisplacementVector dv5 = new(3, 5);
Console.WriteLine($"dv1.Equals(dv5): {dv1.Equals(dv5)})");
Console.WriteLine($"dv1 == dv5: {dv1 == dv5})");

Console.WriteLine("-------------------------------------------------------");
/*===============================================================
  Inheriting from classes
 ================================================================*/

Employee john = new()
{
    Name = "John Jones",
    Born = new(1990, 7, 28, 0, 0, 0, TimeSpan.Zero),

};
john.WriteToConsole();


// Extending classes to add functionlity
john.EmployeeCode = "JJ001";
john.HireDate = new(2014, 11, 23);
Console.WriteLine($"{john.Name} was hired on {john.HireDate:yyyy-MM-dd}.");
john.WriteToConsole();

// Overriding members
Console.WriteLine(john.ToString());

Employee aliceInEmployee = new()
{
    Name = "Alice",
    EmployeeCode = "AA123"
};

Person aliceInPerson = aliceInEmployee;
aliceInEmployee.WriteToConsole();
aliceInPerson.WriteToConsole();
Console.WriteLine(aliceInEmployee);
Console.WriteLine(aliceInPerson.ToString());

Console.WriteLine("-----------------------------------------------------");
/* Explicit casting */

if (aliceInPerson is Employee explicitAlice)
{
    Console.WriteLine($"{nameof(aliceInPerson)} is an Employee.");
    //Employee explicitAlice = aliceInPerson as Employee;
   // Employee explicitAlice = (Employee)aliceInPerson;
    // Safely do something with explicitAlice.
}

Employee? aliceAsEmployee = aliceInPerson as Employee;
if (aliceAsEmployee != null)
{
    Console.WriteLine($"{nameof(aliceInPerson)} is an Employee.");
}

try
{
    john.TimeTravel(new(1999, 12, 31));
    john.TimeTravel(new(1950, 12, 25));
}
catch(PersonException ex)
{
    Console.WriteLine($"Error: {ex.Message}");
}


/*===============================================================
 * Using Static methods to reuse functionality P-356
 ================================================================*/
string email1 = "pamela@test.com";
string email2 = "ian&test.com";

Console.WriteLine("{0} is a valid e-mail address : {1}", 
    email1,StringExtensions.IsValidEmail(email1));
Console.WriteLine("{0} is a valid e-mail address : {1}",
    email2, StringExtensions.IsValidEmail(email2));
// Using a static method
Console.WriteLine("{0} is a valid e-mail address : {1}",
    email1, email1.IsValidEmail());
Console.WriteLine("{0} is a valid e-mail address : {1}",
    email2, email2.IsValidEmail());


Console.WriteLine("------------------------------------------------------------");

/*===============================================================
 * Mutability and Records P-360
 ================================================================*/
C1 c1 = new() { Name = "Bob" };
c1.Name = "Bill";
//C2 c2 = new("Bob");
//c2.Name = "Bill"; // CS8852: Init-only property.
S1 s1 = new() { Name = "Bob" };
s1.Name = "Bill";
S2 s2 = new("Bob");
s2.Name = "Bill";
//S3 s3 = new( "Bob");
//s3.Name = "Bill"; // CS8852: Init-only property.