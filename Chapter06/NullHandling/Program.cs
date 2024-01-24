using Packt.Shared; // TO use Addressusing Packt.Shared; // TO use Address

int thisCannotBeNull = 4;
//thisCannotBeNull = null; // CS0037 compiler error!
Console.WriteLine(thisCannotBeNull);


int? thisCouldBeNull = null;
Console.WriteLine(thisCouldBeNull);

thisCouldBeNull = 7;
Console.WriteLine(thisCouldBeNull);
Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

// The actual type of int? is Nullable<int>.
Nullable<int> thisCouldAlsoBeNull = null;
thisCouldAlsoBeNull = 9;
Console.WriteLine(thisCouldAlsoBeNull);

Console.WriteLine( "------------------------------------------------------");

Address address = new("London")
{
    Building = null,
    Street = null!, // null- forgiving operator
    Region = "UK"
};

Console.WriteLine(address.Building?.Length);
if (address.Street != null) { Console.WriteLine(address.Street.Length); }
