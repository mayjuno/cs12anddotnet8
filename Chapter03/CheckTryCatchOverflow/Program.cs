namespace CheckTryCatchOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                checked
                {
                    int x = int.MaxValue - 1;
                    Console.WriteLine($"Initial value of x : {x}");
                    x++;
                    Console.WriteLine($"After incrementing value of x : {x}");
                    x++;
                    Console.WriteLine($"After incrementing value of x : {x}");
                    x++;
                    Console.WriteLine($"After incrementing value of x : {x}");
                }
            }
            catch(OverflowException)
            {
                Console.WriteLine("The code overflow but I catch the exception.");
            }

        }
    }
}
