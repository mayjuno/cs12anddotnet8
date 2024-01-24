namespace SelectionStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add and remove the "" to change between string and integer
            object o  = "3";
            int j = 4;
            if (o is int i)
            {
                Console.WriteLine($"{i} x {j} = {i * j} ");
            }
            else
            {
                Console.WriteLine("o is not an int so it cannot multiply!");
            }
            
        }
    }
}
