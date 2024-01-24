namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names; // This can reference any size array of string.
            // Alocate memory for four strings in array.
            names = new string[4];
            names[0] = "William";
            names[1] = "Raymond";
            names[2] = "Agga";
            names[3] = "Scarlat";
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            for(int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"index[{i}] name is {names[i]}.");
            }

            // Alternative syntax for creating and initializing array.
            string[] names2 = { "William", "Raymond", "Agga", "Scarlat" };
            foreach (string name in names2)
            {
                Console.WriteLine(name);
            }

            // What we want to store data
            // -as a grid of values?
            // - as a cube?
            // - as heigher dimensions?
            Console.WriteLine("--------------- like as a Cube ----------------------");
            string[,] names3 =
            {
                {"alpha","Beta", "Ganmar", "Thada" },
                {"William", "Raymond", "Agga", "Scarlat" },
                {"A", "B", "C", "D"  }
            };
            for(int i = names3.GetLowerBound(0); i <= names3.GetUpperBound(0); i++)
            {
                for (int j = names3.GetLowerBound(1); j <= names3.GetUpperBound(1); j++)
                {
                    Console.Write($"\t{names3[i, j]}");
                }
                Console.WriteLine();
            }
        }
    }
}
