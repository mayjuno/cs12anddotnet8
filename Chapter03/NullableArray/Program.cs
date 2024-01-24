namespace jaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Alternative syntex for declaring and allocating memory for a multidimensional array.
            string[,] jaggedArray = new string[3, 4];  // Allocate  memory.
            jaggedArray[0,0] = "Alpha";
            jaggedArray[0, 1] = "Beta";
            jaggedArray[0, 2] = "Gamma";

            jaggedArray[1, 0] = "William";
            jaggedArray[1, 1] = "Raymond";
            jaggedArray[1, 3] = "Scarlat";

            jaggedArray[2, 2] = "Cat";
            jaggedArray[2, 3] = "Dog";
            Console.WriteLine($"|{"Colum1",10}|{"Colum2",10}|{"Colum3",10}|{"Colum4",10}|");
            Console.WriteLine("----------------------------------------------");
            for (int i = jaggedArray.GetLowerBound(0); i <= jaggedArray.GetUpperBound(0); i++)
            {
                for (int j = jaggedArray.GetLowerBound(1); j <= jaggedArray.GetUpperBound(1); j++)
                {
                    if (jaggedArray[i, j] != null)
                        Console.Write($"|{jaggedArray[i,j],10}");
                    else Console.Write($"|{" ",10}");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }
    }
}
