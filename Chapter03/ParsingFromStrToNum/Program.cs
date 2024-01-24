using System.Globalization;  // To use CultureInfo.
using static System.Convert;
namespace ParsingFromStrToNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Set the current cluster to make sure date persing works.
            CultureInfo.CurrentCulture = new CultureInfo("en-US");
            int friends = int.Parse("27");
            DateTime birthday = DateTime.Parse("9/18/1995");
            Console.WriteLine($"I have {friends} friends to invite to my party.");
            Console.WriteLine($"My birthday is on {birthday:d}.");
            Console.WriteLine($"My birthday is on {birthday}.");



        }
    }
}
