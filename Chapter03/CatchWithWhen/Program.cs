namespace CatchWithWhen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an amount : ");
            string amount = Console.ReadLine()!;   // ! null-forget operator
            if (string.IsNullOrEmpty(amount)) { Console.WriteLine("Bye..."); return; }
            try
            {
                decimal amountValue = decimal.Parse(amount);
                Console.WriteLine($"Amount entered : {amountValue:C}");
            }
            catch (FormatException) when (amount.Contains("$"))
            {
                Console.WriteLine("Amounts cannot use the dollar sign!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Amounts must only digits!");
            }
        }
    }
}
