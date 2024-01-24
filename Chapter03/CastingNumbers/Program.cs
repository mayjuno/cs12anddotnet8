namespace CastingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double c = 9.8;
            int d = (int)c; // Compiler gives an error if you do not explicitly cast.
            Console.WriteLine($"c is {c} , d is {d}"); // d loses the .8 part.
            Console.WriteLine("d loses the .8 part.");
            Console.WriteLine("------------------------------------------------");
            long e = 10;
            int i = (int)e;
            Console.WriteLine($"e is {e:N0}, i is {i:N0}");

            e = long.MaxValue; // maximun vlaue of long 64 bit integer
            i = (int)e;
            Console.WriteLine($"e is {e:N0}, i is {i:N0}");
            Console.WriteLine("Why i is -1?");
            Console.WriteLine("---------------------  When e is 5000000000 --------------------------");
            e = 5_000_000_000; // 5 billion
            i = (int)e;
            Console.WriteLine($"e is {e:N0}, i is {i:N0}");

        }
    }
}
