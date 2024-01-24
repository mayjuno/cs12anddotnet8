using System.Xml;

namespace UnderstandingFormatStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* { index[, alignment][ : formatString] } */
            string applesText = "Apples";
            int applesCount = 56789;
            decimal applesPrice = 0.99m;
            string bananasText = "Bananas";
            int bananasCount = 10987654;
            decimal bananasPrice = 0.49m;
            Console.WriteLine();

            Console.WriteLine(format:"{0,-10} {1,14} {2,20}", arg0:"Name", arg1:"Count", arg2:"Cost");
            Console.WriteLine(format: "{0,-10} {1,14:N0} {2,20:C}", arg0: applesText, arg1: applesCount, arg2:applesCount*applesPrice);
            Console.WriteLine(format:"{0,-10} {1,14:N0} {2,20:C}", arg0: bananasText, arg1:bananasCount, arg2:bananasCount*bananasPrice);
        }
    }
}
