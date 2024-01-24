namespace HandlingExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before Parseing!");
            Console.WriteLine("What is your age? ");
            string? input = Console.ReadLine();
            //if (input is null)
            //{
            //    Console.WriteLine("You did not enter a value so the app has ended.");
            //    return;  // exit the application.
            //}
            try
            {
                int age = int.Parse(input!);  // ! null-forgiving operator
                Console.WriteLine($"You are {age} years old.");
            }
            catch (FormatException)
            {
                Console.WriteLine("The age you entered is not a valid number format.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Your age is a valid number format but it is either too big or small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} say {ex.Message}");
            }
            Console.WriteLine("After parseing..");
        }
    }
}
