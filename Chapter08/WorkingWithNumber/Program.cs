using System.Numerics; // For BigInteger

const int width = 40;
WriteLine("ulong.MaxValue vs a 30-digit BigInteger");
WriteLine(new string('-',width));

ulong big = ulong.MaxValue;
WriteLine($"{big,width:N0}");
BigInteger bigger = BigInteger.Parse("123456789012345678901234567890");
WriteLine($"{bigger,width:N0}");

WriteLine(new string('-', width));

/* Working with complex numbers*/

WriteLine("Working with complex numbers");
Complex c1 = new(4,2);
Complex c2 = new(3,7);
Complex c3 = c1 + c2;
// Output using the default ToString() method
WriteLine($"{c1} added to {c2} is {c3}");
// Output using a custom format.
WriteLine("{0} + {1}i added to {2} + {3}i is {4} + {5}i",
    c1.Real,c1.Imaginary,
    c2.Real,c2.Imaginary,
    c3.Real,c3.Imaginary);
WriteLine(new string('-', width));

/*
 Generating random numbers for games and similar apps
 */
// Generating random numbers

Random r = Random.Shared;
// iminValue is na inclusive lower bound i.e 1 is a possible value.
// maxValue is an exclusive upper bound i.e 7 is not a possible value
int dieRoll = r.Next(1, 7);
WriteLine($"Random die roll: {dieRoll}");

double randomReal = r.NextDouble();// Returns a random number between 0 and 1(less than 1.0)
WriteLine($"Random real number: {randomReal:F4}");

byte[] arrayOfBytes = new byte[256];
r.NextBytes(arrayOfBytes); // Fills array with 256 random bytes.
Write("Random bytes");
for (int i =0; i < arrayOfBytes.Length; i++)
{
    Write($" {arrayOfBytes[i]:X2}");
}
WriteLine();
WriteLine(new string('-', width));


string[] beatles = r.GetItems(choices: new[] 
{ "John", "Paul", "George", "Ringo" },10);
Write("Random ten beatles choice: ");
foreach (string beatle in beatles)
{
    Write($" {beatle}");
}
WriteLine();
r.Shuffle(beatles);
Write("Shuffled betales : ");
foreach (string beatle in beatles)
{ 
    Write($" {beatle}"); 
}
WriteLine();
WriteLine(new string('-', width));


/*
 Generating GUIDs(Gloobally unique Identifiers)
 */

WriteLine($"Empty GUID :{Guid.Empty}.");
Guid g = Guid.NewGuid();
WriteLine($"Random GUID :{g}.");
WriteLine($"GUID in string format :{g.ToString()}.");

byte[] guidAsBytes = g.ToByteArray();
Write("GUID as Bytes Array : ");
for (int i =0; i < guidAsBytes.Length; i++)
{
    Write($" {guidAsBytes[i]:X2}"); // Hexa 2 values
}
WriteLine();
WriteLine(new string('-', width));

/*
 * 
 */
WriteLine();
WriteLine(new string('-', width));