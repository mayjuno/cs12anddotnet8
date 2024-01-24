namespace Base64Encoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Allocate an array of 128 bytes.
            byte[] binaryObject = new byte[128];

            // populate the array with random bytes.
            Random.Shared.NextBytes(binaryObject);

            Console.WriteLine("Binary Object as a random bytes: ");
            for (int index = 0; index < binaryObject.Length; index++)
            {
                Console.Write($"{binaryObject[index]:X2} "); //:X2  Xexandecimal Values
            }
            Console.WriteLine();
            //Console.WriteLine($"{sizeof(binaryObject)}");
            Console.WriteLine("--------------------------------------------------");
            // Convert the array to Base64 string.
            string base64String = Convert.ToBase64String(binaryObject);
            Console.WriteLine("Binary Object as Base64 string: \n" + base64String);

            Console.WriteLine($"Size of Base64String :{System.Text.ASCIIEncoding.ASCII.GetByteCount(base64String)} Bytes");
        }
    }
}
