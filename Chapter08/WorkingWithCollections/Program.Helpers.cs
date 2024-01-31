using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Program
{
    private static void OutputCollection<T>(string title, IEnumerable<T> collection)
    {
        Console.WriteLine($"{title}:");
        foreach (T item in collection)
        {
            Console.WriteLine($" {item}");
        }
    }
    private static void OutputPQ<TElement, TPriority>( string title,
        IEnumerable<(TElement Element, TPriority Priority)> collection)
    {
        WriteLine($"{title}");
        foreach ((TElement Element, TPriority Priority) item in collection) 
        {
            Console.WriteLine($"{item.Item1} : {item.Item2}");

        }
    }
//===========================================================
//              Read-only, immutable and frozen collections
//===========================================================

    void ReadCollection<T>(ICollection<T> collection)
    {
        // We can check if the collection is read-only
        if (collection.IsReadOnly)
        {
            // Read the collection.
        }
        else
        {
            Console.WriteLine("You have given me a collection that I could change!");
        }
    }

    private static void UseDictionary(IDictionary<string, string> dictionary)
    {
        WriteLine($"Count before is {dictionary.Count}");
        try
        {
            Console.WriteLine("Adding new item with GUID values.");
            // Add method with return type of void.
            dictionary.Add(
                Guid.NewGuid().ToString(), 
                Guid.NewGuid().ToString());
        }
        catch
        {
            Console.WriteLine("This dictionary does not support the Add method.");
        }
        WriteLine($"Count after is {dictionary.Count}.");
    }
}
