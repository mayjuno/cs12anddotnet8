namespace PatternMatchingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sequentialNumbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] oneTwoNumbers = {1,2};
            int[] oneTwoTenNumbers = { 1, 2, 10 };
            int[] oneTwoThreeTenNumbers = { 1, 2, 3, 10 };
            int[] primeNumbers = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 };
            int[] fibonacciNumbers = { 1, 1, 2, 3, 5, 8, 13, 21, 34, 55,89 };
            int[] emptyNumbers = { }; // Or use Array.Empty<int>();
            int[] threeNumbers = { 9, 7, 5 };
            int[] sixNumbers = {9,7,5,4,2,10};

            Console.WriteLine($"{nameof(sequentialNumbers)}:" +
                $"{ CheckSwitch(sequentialNumbers)}");
            Console.WriteLine($"{nameof(oneTwoNumbers)}:" +
                $"{CheckSwitch(oneTwoNumbers)}");
            Console.WriteLine($"{nameof(sixNumbers)}:" +
                $"{CheckSwitch(sixNumbers)}");

            // you can use switch expression any more
        }
        static string CheckSwitch(int[] values) => values switch
        {
            
            [] => "Empty Array",
            [1, 2] => "Contain 1 the 2.",
            [1, 2, _,10] => "Contain 1 the 2 and any single number ,10.",
            [1,2,..,10] => "Contain 1 the 2 any range including empty,10.",
            [int item1, int item2, int item3] => $"Contain {item1} then {item2} then {item3}.",
            [0, _] => "Start with 0 and then any number.",
            [0, ..] => "Start with 0 and then any range of number.",
            [2, .. int[] others] => $"Start with 2 , then {others.Length} more numbers.",
            [..] => "Any items in any order."
        };
    }
}
