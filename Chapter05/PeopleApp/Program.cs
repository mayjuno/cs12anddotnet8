using Packt.Shared; // To use Person.
using Fruit = (string Name, int Number); // Aliasing a tuple type.
ConfigureConsole(); // Sets current culture to US English.
// Alternatives:
// ConfigureConsole(useComputerCulture: true); // Use your culture.
// ConfigureConsole(culture: "fr-FR");         // Use French culture.


// Person bob = new Person(); // C# 1 or later.
// var bob = new Person();    // C# 3 or later.
Person bob = new();           // C# 9 or later.
WriteLine(bob);
// Implicit call to ToString().

// WriteLine(bob.ToString()); // Does the same thing.
WriteLine("--------------------------------------------------------");
bob.Name = "Bob Smith";
bob.Born = new DateTimeOffset(year: 1965, month: 12, day: 22, hour: 16, minute: 28, second: 0, offset: TimeSpan.FromHours(-5)); // US Eastern Standard Time.
WriteLine(format: "{0} was born on {1:D}.", /* Long date.*/arg0: bob.Name, arg1: bob.Born);

WriteLine("--------------------------------------------------------");
Person alice = new()
{
    Name = "Alice Jones",
    Born = new(1998, 3, 7, 16, 28, 0,
// This is an optional offset from UTC time zone.
TimeSpan.Zero)
};
WriteLine(format: "{0} was born on {1:d}.", /* Short date.*/arg0: alice.Name, arg1: alice.Born);
WriteLine("---------------------------------------------------------");

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine(format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
    arg0: bob.Name, arg1: bob.FavoriteAncientWonder, arg2: (int)bob.FavoriteAncientWonder);


bob.BucketList = WondersOfTheAncientWorld.HangingGardensOfBabylon | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
// bob.BucketList = (WondersOfTheAncientWorld)18;
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}.");

WriteLine("------------------------------------------------------");
// Works with all versions of C#.
Person alfred = new Person();
alfred.Name = "Alfred";
bob.Children.Add(alfred);
// Works with C# 3 and later.
bob.Children.Add(new Person { Name = "Bella" });
// Works with C# 9 and later.
bob.Children.Add(new() { Name = "Zoe" });
WriteLine($"{bob.Name} has {bob.Children.Count} children:");

for (int childIndex = 0; childIndex < bob.Children.Count; childIndex++)
{
    WriteLine($"> {bob.Children[childIndex].Name}");
}
WriteLine("-----------------------------------------------------");

// BankAccount
BankAccount.InterestRate = 0.012M; // Store a shared value in static field.

BankAccount jonesAccount = new();
jonesAccount.AccountName = "Mrs. Jones";
jonesAccount.Balance = 2400.00M;

WriteLine(format: "{0} earned {1:C} interest.",
    arg0: jonesAccount.AccountName,
    arg1: jonesAccount.Balance * BankAccount.InterestRate);

BankAccount gerrierAccount = new();
gerrierAccount.AccountName = "Ms. Gerrier";
gerrierAccount.Balance = 98.0M;

WriteLine(format: "{0} earned {1:C} interest.",
    arg0: gerrierAccount.AccountName, gerrierAccount.Balance * BankAccount.InterestRate);
WriteLine("---------------------------------------------------------");

// Constan fields are accessible via the type.
WriteLine($"{bob.Name} is a {Person.Species}.");
WriteLine("---------------------------------------------------------");

// Read-only fields are accessible via the variable.
WriteLine($"{bob.Name} was born on {bob.HomePlanet}.");
WriteLine("---------------------------------------------------------");

/*
Book book = new()
{
    Isbn = "978-1803237800",
    Title = "C# 12 and .NET 8 - Modern Cross-Platform Development Fundamentals",
    PageCount = 829
};
*/

Book book = new("978-1803237800",
    "C# 12 and .NET 8 - Modern Cross-Platform DevelopmentFundamentals")
{
    Author = "Mark J. Price",
    PageCount = 821
};
WriteLine("{0}: {1} written by {2} has {3:N0} pages.",
    book.Isbn, book.Title, book.Author,book.PageCount);
WriteLine("---------------------------------------------------------");

Person blankPerson = new();
WriteLine(format: "{0} of {1} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: blankPerson.Name,
    arg1: blankPerson.HomePlanet,
    arg2: blankPerson.Instantiated);
WriteLine("---------------------------------------------------------");

Person gunny = new("Gunny", "Mars");
WriteLine(format: "{0} was created at {2:hh:mm:ss} on a {2:dddd}.",
    arg0: gunny.Name,
    arg1: gunny.HomePlanet,
    arg2: gunny.Instantiated);

WriteLine("---------------------------------------------------------");
bob.WriteToConsole();
WriteLine(bob.GetOrigin());

WriteLine("---------------------------------------------------------");
#region Defining and passing parameters to a method.
WriteLine(bob.SayHello());
WriteLine(bob.SayHello("Emily"));
#endregion  
WriteLine("---------------------------------------------------------");
WriteLine(bob.OptionalParameters(3));
WriteLine(bob.OptionalParameters(3,"Jump!", 98.5));
// Naming parameters values when calling methods
WriteLine(bob.OptionalParameters(3,number:52.7, command:"Hide!"));
// Positional parameters
WriteLine(bob.OptionalParameters(3, "Poke!", active:false));

WriteLine("---------------------------------------------------------");
// Controlling how parameters are passed
int a = 10;
int b = 20;
int c = 30;
int d = 40;
WriteLine($"Before: a={a}, b={b}, c={c}, d={d}");
bob.PassingParameters(a, b, ref c, out d);
WriteLine($"After: a={a}, b={b}, c={c}, d={d}");
WriteLine( "--------------------------------------------------------");

int e = 50;
int f = 60;
int g = 70;
WriteLine($"Before: e={e} , f={f} , g= {g}, h doesn't exit yet!");
bob.PassingParameters(e, f, ref g, out int h);
// Simplified C# 7 or later syntax for the out parameter.
WriteLine($"After: e ={e}, f={f}, g={g}, h={h}");

WriteLine("--------------------------------------------------");
(string, int) fruit = bob.GetFruit();
WriteLine($"{fruit.Item1}, {fruit.Item2} there are.");

// Tuple with the naned fields.
//------------------------------
// Without an aliased tuple type.
//var fruitNamed = bob.GetNamedFruit();

// With an aliasing tuple type.
Fruit fruitNamed = bob.GetNamedFruit(); 
WriteLine($"There are {fruitNamed.Number} are {fruitNamed.Name} .");

var thing1 = ("Neville", 4);
WriteLine($"{thing1.Item1} has {thing1.Item2} children.");
var thing2 = (bob.Name, bob.Children.Count);
WriteLine($"{thing2.Name} has {thing2.Count} children.");
WriteLine("--------------------------------------------------");
// Deconstructuring a tuple
(string fruitName, int fruitNumber) = bob.GetFruit();
WriteLine($"{fruitName} are {fruitNumber} in the basket.");



/*
 * Implemeenting functionality using local functions
 * 
 */
// Change to 5 to -1 to make the exception handling code excute.
int number = 5;
try
{
    Console.WriteLine($"{number}! is {Person.Factorial(number)}");
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType()} says:{ex.Message} number was {number}.");
}
WriteLine("-----------------------------------------------------");
/*
 * Controlling access with properties and indexers
 * 
 */
Person sam = new()
{
    Name = "Sam",
    Born = new(1969, 6, 25, 0, 0, 0, TimeSpan.Zero)
};

WriteLine(sam.Origin);
WriteLine(sam.Greeting);
WriteLine(sam.Age);

sam.FavoriteIceCream = "Chocolate Fudge";
WriteLine($"Sam's favouriate ice-cream flavor is {sam.FavoriteIceCream}");
string color = "White"; // Try to set the color to any value other than red, green, or blue.
try
{
    sam.FavoritePrimaryColor = color;
    Console.WriteLine($"Sam's favority primary color is {sam.FavoritePrimaryColor}.");
}
catch(Exception ex)
{
    Console.WriteLine("Tried to set {0} to '{1}': {2}", nameof(sam.FavoritePrimaryColor), color, ex.Message);
   
}

sam.Children.Add(new () { Name = "Charlie" , 
    Born = new(2010,3,18,0,0,0,TimeSpan.Zero)});

sam.Children.Add(new() { Name = "Ella" , 
    Born = new(2020,12,24,0,0,0,TimeSpan.Zero)});

// Get using Children list.
WriteLine($"Sam's first child is {sam.Children[0].Name}.");
WriteLine($"Sam's second child is {sam.Children[1].Name}.");
// Get using the int indexer.
WriteLine($"Sam's first child is {sam[0].Name}.");
WriteLine($"Sam's second child is {sam[1].Name}.");
// Get using the string indexer.
WriteLine($"Sam's child named Ella is {sam["Ella"].Age} years old.");
WriteLine("------------------------------------------------------------");

// Pattern-matching flight passengers

// An array containing a mix of passenger types.
Passenger[] passengers = {
    new FirstClassPassenger { AirMiles = 1_419, Name = "Sumanth" },
    new FirstClassPassenger { AirMiles = 16_562, Name = "Lucy" },
    new BusinessClassPassenger { Name = "Janice" },
    new CoachClassPassenger { CarryOnKG = 45.7, Name = "Dave" },
    new CoachClassPassenger { CarryOnKG = 0, Name = "Amit" },
};

foreach(Passenger passenger in passengers)
{
    decimal flightCost = passenger switch
    {
        /* C# 8 syntax
        FirstClassPassenger p when p.AirMiles > 35_000 => 1_500m,
        FirstClassPassenger p when p.AirMiles > 15_000 => 1_700m,
        FirstClassPassenger _ => 2_000m, */
        FirstClassPassenger p => p.AirMiles switch
        {
            > 35_000 => 1_500m,
            > 15_000 => 1_750m,
            _ => 2_000m
        },
        BusinessClassPassenger _ => 1_000m,
        CoachClassPassenger p when p.CarryOnKG < 10.0 => 500m,
        CoachClassPassenger _ => 850m,
        _ => 800m
    };
    Console.WriteLine($"Flight costs {flightCost:C} for {passenger}");
}

WriteLine("--------------------------------------------------------");

/*
 * Working with record types
 * 
 * init-only properties
 * pages  - 284
 */
ImmutablePerson jeff = new()
{
    FirstName = "Jeff",
    LastName = "Winger"

};
//jeff.FirstName = "Geoff";

ImmutableVehicle car = new()
{
    Brand = "Mazda MX-5 RF",
    Color = "Soul Red Crystal Metalic",
    Wheels = 4
};

ImmutableVehicle repaintedCar = car with {
    Color = "Polymetal Gray Metalic",
};

WriteLine($"Orginal car color was {car.Color}.");
WriteLine($"New car color is {repaintedCar.Color}.");
WriteLine("-----------------------------------------------------");
/*
 * Equality of record types and classes
 * 
 */
AnimalClass ac1 = new()
{
    Name = "Rex"
};
AnimalClass ac2 = new()
{
    Name = "Rex"
};

WriteLine($"ac1 == ac2: {ac1 == ac2}");

AnimalRecord ar1 = new() { Name = "Rex" };
AnimalRecord ar2 = new() { Name = "Rex" };
WriteLine($"ar1 == ar2 : {ar1 == ar2}");
WriteLine("----------------------------------------------------------");
/*
 * Positional data members in record types
 */
ImmutableAnimal oscar = new("Oscar", "Labrador");

var (who, what) = oscar; // Calls the Doconstructor method.
WriteLine($"{who} is a {what}");
Console.WriteLine("--------------------------------------------------");


/*
 * Defining a primary constructor for a class
 */

Headset vp = new("Apple", "Vision Pro");
WriteLine($"{vp.ProductName} is made by {vp.Manufacturer}.");


// Default parameterless constructor
Headset holo = new();
WriteLine($"{holo.ProductName} is made by {holo.Manufacturer}.");
Headset mq = new() { Manufacturer = "Meta", ProductName = "Quest 3" };
WriteLine($"{mq.ProductName} is made by {mq.Manufacturer}.");

WriteLine("Press ENTER to exit...");
ReadLine();