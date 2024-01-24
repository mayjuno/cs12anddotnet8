namespace BitwiseAndBinaryShiftOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            int y = 6;
            Console.WriteLine($"Expression | Decimal | Binary");
            Console.WriteLine($"-------------------------------");
            Console.WriteLine($"x          | {x,7} | {x:B8}");
            Console.WriteLine($"y          | {y,7} | {y:B8}");
            Console.WriteLine($"x & y      | {x & y,7} | {x & y:B8}");
            Console.WriteLine($"x | y      | {x | y,7} | {x | y:B8}");
            Console.WriteLine($"x ^ y      | {x ^ y,7} | {x ^ y:B8}");
            // Left-shift x by three bit columns.
            Console.WriteLine($"x << 3     | {x << 3,7} | {x << 3:B8}");
            // Multiply x by 8.
            Console.WriteLine($"x * 8      | {x * 8,7} | {x * 8:B8}");
            // Right-shift y by one bit column.
            Console.WriteLine($"y >> 1     | {y >> 1,7} | {y >> 1:B8}");
            
        }
    }
}
