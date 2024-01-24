namespace GettingKeyInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press any key Combination : ");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Key: {0} , Char: {1}, Modifiers: {2}",
                arg0:keyInfo.Key, arg1:keyInfo.KeyChar, arg2:keyInfo.Modifiers);
        }
    }
}
