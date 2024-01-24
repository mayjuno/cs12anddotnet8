using static System.Convert;
namespace ConvertingWithSystem.Convert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 
             *An important difference between casting and 
             *converting is that converting rounds 
             *the double value 9.8 up to 10 instead of 
             *trimming the part after the decimal point. 
             */
            double d = 9.8;
            int i = ToInt32(d);
            Console.WriteLine($"d is {d}, i is {i}");

            double[,] doubles = 
            {
               { 9.49, 9.5, 9.51 },
               { 10.49, 10.5, 10.51 },
               { 11.49, 11.5, 11.51 },
               { 12.49, 12.5, 12.51 } ,
               { -12.49, -12.5, -12.51 },
               { -11.49, -11.5, -11.51 },
               { -10.49, -10.5, -10.51 },
               { -9.49, -9.5, -9.51 }
            };
            Console.WriteLine($"| double | ToInt32 | double | ToInt32 | double | ToInt32 |");
            for(int x = 0; x <= doubles.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= doubles.GetUpperBound(1); y++)
                {
                    Console.Write($"| {doubles[x, y],6} |  {ToInt32(doubles[x,y]),7}");
                }
                Console.WriteLine("|");
            }
        }
    }
}
