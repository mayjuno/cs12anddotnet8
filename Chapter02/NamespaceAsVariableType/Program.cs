using System.Xml;  // To use the Xml Document
namespace NamespaceAsVariableType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Good use of var because it avoids the repeated type
            // as shown in the more verbose second statement.
            var xml1 = new XmlDocument();  // works with all C# 3 and later
            XmlDocument xml2 = new XmlDocument();  // Works with all C# versions.
            // Bad use of var because we cannot tell the type, so we
            // should use a specific type declaration as shown in
            // the second statement.
            var file1 = File.CreateText("something1.txt");
            StreamWriter file2 = File.CreateText("something2.txt");

        }
    }
}
