using System.Globalization;  // To use CultureInfo
OutputEncoding = System.Text.Encoding.UTF8;  // Enable Euro symbol.
CultureInfo.CurrentCulture = new CultureInfo("en-US");

string city = "London";
WriteLine($"{city} is {city.Length} characters long.");
WriteLine($"First char is {city[0]} and fourth is {city[3]}.");
WriteLine(new string('-',50));
/* Splitting a string*/
string cities = "Paris,Tehran,Chennai,Sydney,New York,Medillina";
string[] citiesArray = cities.Split(',');
WriteLine($"There are {citiesArray.Length} cities in the list.");
for (int i = 0; i < citiesArray.Length; i++)
{
    WriteLine($"{i + 1} - {citiesArray[i]}");
}
WriteLine(new string('-',50));

/* Getting part of a string */
string fullName = "Hassan Rezaei";
string firstName = fullName.Substring(0, fullName.IndexOf(' '));
string lastName = fullName.Substring(fullName.IndexOf(' ') + 1);
WriteLine($"Original Name:{fullName}");
WriteLine($"Swapped Name:{lastName} {firstName}");

WriteLine(new string('-',50));
/* Checking a string for content */
string content = "I love C#";
WriteLine(content);
if (content.Contains("C#"))
{
    WriteLine("I love C#");
}
content = content.Replace("C#", "C Sharp");
WriteLine(content);

WriteLine(new string('-',50));

/* Comparing string values */
string name = "Hassan";
string name2 = "Hassan";
WriteLine(name == name2);
WriteLine(name.Equals(name2));

string text1 = "Mark";
string text2 = "MARK";
WriteLine($"text1:{text1} , text2: {text2}");
WriteLine("Compare: {0}.",String.Compare(text1,text2));

WriteLine("Compare(ignoreCase):{0}.",string.Compare(text1,text2,true));
WriteLine("Compare(InvariantClusterIgnoreCase): {0}", 
    string.Compare(text1,text2,StringComparison.InvariantCultureIgnoreCase));
WriteLine(new string('-',50));

/* Joining strings */
foreach (string i in citiesArray)
    WriteLine(i);
WriteLine();

string recombined = string.Join("|", citiesArray);
WriteLine(recombined);

WriteLine(new string('-',50));
/* Positional parameters  Interpolated and string formating */
string fruit = "Apples";
int count = 5;
decimal price = 0.95m;
DateTime when = DateTime.Now;
WriteLine("String.Format: {0} are {1} pieces, each costs {2:C} on {3:dddd}.",fruit, count, price,when);
WriteLine($"Interpolated : {fruit} are {count} pieces, each costs {price:C} on {when:dddd}.");
