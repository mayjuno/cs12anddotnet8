namespace RawInterpolatedStringLiterals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new { FirstName = "John", Age = 42 };
            string jason = $$"""
                {
                "first_name": "{{person.FirstName}}",
                "age": {{person.Age}},
                "calculation": {{2 + 2}}
                }
                """;
            Console.WriteLine(jason);

        }
        
    }
}
