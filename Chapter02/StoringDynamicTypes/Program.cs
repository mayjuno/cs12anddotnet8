namespace StoringDynamicTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dynamic something;
            // Storing an array of int values in dynamic object
            // an array of any type  has a length property
            something = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Storing an int  in a dynamic object.
            // int does not have a length property.
            //something = 12;

            // Storing a string in a dynamic object.
            // string has a length property.
           // something = "Ahmead";

            // This compiles but might throw an exception at runtime.
            Console.WriteLine($"The length of something is {something.Length}");

            // Output the type of something variable.
            Console.WriteLine($"something is a {something.GetType()}");
        }
    }
}
