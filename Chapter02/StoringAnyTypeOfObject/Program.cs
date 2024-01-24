namespace StoringAnyTypeOfObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object height = 1.88; // Storing a double in an object.
            object name = "Amir"; // Storing a string in an object.
            Console.WriteLine($"{name} is {height} meters tall.");

            //int length1 = name.Length; // This gives a complie error!
            int length2 = ((string)name).Length; // Cast name to a string.
            Console.WriteLine($"{name} has {length2} characters.");

        }

    }
}
