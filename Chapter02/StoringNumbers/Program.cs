namespace StoringNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // An unsing integer is a positive whoe number or 0.
            uint a = 10;
            // An integer is a negative or positive whole number or 0.
            int integerNumber = -10;
            // A float is a single-precision floating point number.
            // The F or f suffix indicates that the number is a float.
            // The suffix is required to compile in C#.
            float f = 3.14F;
            // A double is a double-precision floating point number.
            // The suffix is required to compile in C#.
            double d = 3.14;
            Console.WriteLine($"unsign a is {a}");
            Console.WriteLine($"integer number is {integerNumber}");
            Console.WriteLine($"f is the float number {f}");
            Console.WriteLine($"d is the another real number {d}");
        }
    }
}
