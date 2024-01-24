#region Exploring unary operators

int a = 3;
Console.WriteLine($"a before prefix is {a}");
int b = a++;
Console.WriteLine($"a is {a}, b is {b}");
int c = 3;
Console.WriteLine( $"c before prefix is {c}");
int d = ++c;
Console.WriteLine($"c was postfix {c} and d is {d}");

int e = 11;
int f = 3;
Console.WriteLine($"e is {e}, f is {f}");
Console.WriteLine($"e + f = {e + f}");
Console.WriteLine($"e - f = {e - f}");
Console.WriteLine($"e * f = {e * f}");
Console.WriteLine($"e / f = {e / f}");
Console.WriteLine($"e % f = {e % f}");
#endregion
