namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many eggs are there? ");
            string? input = Console.ReadLine();
            if (int.TryParse(input,out int count))
            {
                Console.WriteLine($"There are {count} eggs.");
            }
            else
            {
                Console.WriteLine("I coult not parse the input.");
            }
              
        }
    }
}
