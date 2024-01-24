namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[][] jaggedArray = // An array of string arrays
            {
                new[]{"William", "Raymond", "Agga", "Scarlat" },
                new[] {"Alpha", "Bravo", "Charlie", "Delta", "Eagle","Finger" },
                new[] {"Dog", "Cat"}
            };
            for(int i = 0; i < jaggedArray.Length; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write($"{jaggedArray[i][j],10}");
                }
                Console.WriteLine();
            }
            
        }
    }
}
