namespace TargetType_new
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person kyaw = new();
            kyaw.DateOfBirth =  new(1979, 11, 26); // i.e. new DateTime(1967, 12, 26)
            Console.WriteLine($"Kyaw Date of Birth is :{kyaw.DateOfBirth}");

            List<Person> people = new() // Instead of new List<Person()
            {
                new() { FirstName = "Raymond" }, // Instead of: new Person() { ... }
                new() { FirstName = "William" },
                new() { FirstName = "Scarlat" },

            };
            foreach (Person person in people)
            {
                Console.WriteLine(person.FirstName);
            }
            Console.WriteLine("******************************");
            Console.WriteLine($"default(int) = {default(int)}");
            Console.WriteLine($"default(bool) = {default(bool)}");
            Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            Console.WriteLine($"default(string) = {default(string)}");

            /* assign a value, and then reset it to its default value */
            Console.WriteLine("assign a value, and then reset it to its default value");
            int number = 13;
            Console.WriteLine($"number set to: {number}");
            number = default;
            Console.WriteLine($"number reset to its default: {number}");

        }
    }
}
