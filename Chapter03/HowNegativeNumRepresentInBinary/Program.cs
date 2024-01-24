namespace HowNegativeNumRepresentInBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0,12} {1,34}","Decimal","Binary");
            Console.WriteLine("{0,12} {0,34:B32}",int.MinValue);
            for(int i = 8; i >= -8; i--)
            {
                Console.WriteLine("{0,12} {0,34:B32}",i);
            }
            Console.WriteLine("{0,12} {0,34:B32}", int.MaxValue);
        }
    }
}
