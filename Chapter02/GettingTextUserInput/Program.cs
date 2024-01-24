namespace GettingTextUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type your first name and press Enter: ");
            string? firstName = Console.ReadLine();
            Console.WriteLine("Type your last name and press Enter: ");
            string? lastName = Console.ReadLine();
            string fullName = firstName + " " + lastName;
            Console.WriteLine("Type your age and press Enter : ");
            string age = Console.ReadLine()!;  // ! for null-forgiving operator

            Console.WriteLine($"Hello {fullName}, you look good for {age}.");
        }
    }
}
