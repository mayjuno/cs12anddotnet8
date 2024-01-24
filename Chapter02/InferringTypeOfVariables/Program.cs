namespace InferringTypeOfVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int population = 67_000_000; // 67 million in UK.
            double weight = 1.88; // in kilograms.
            decimal price = 4.99M; // in pounds sterling.
            string fruit = "Apples"; // string values use double-quotes.
            char letter = 'Z'; // char values use single-quotes.
            bool happy = true; // Booleans can only be true or false.
            Console.WriteLine(population);
            Console.WriteLine(weight);
            Console.WriteLine(price);
            Console.WriteLine(fruit);
            Console.WriteLine(letter);
            Console.WriteLine(happy);
        }
    }
}
