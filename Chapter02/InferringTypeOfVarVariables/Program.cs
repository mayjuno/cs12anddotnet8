namespace InferringTypeOfVarVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var population = 67_000_000; // 67 million in UK.
            var weight = 1.88; // in kilograms.
            var price = 4.99M; // in pounds sterling.
            var fruit = "Apples"; // string values use double-quotes.
            var letter = 'Z'; // char values use single-quotes.
            var happy = true; // Booleans can only be true or false.
            Console.WriteLine(population);
            Console.WriteLine(weight);
            Console.WriteLine(price);
            Console.WriteLine(fruit);
            Console.WriteLine(letter);
            Console.WriteLine(happy);
            /* 
             Hover your mouse over each of the var keywords and 
             note that your code editor shows a tooltip
             with information about the type that has been inferred.
             */

        }
    }
}
