using System.Text.RegularExpressions;

/* Checking for digits entered as text */
WriteLine("Enter your age: ");
string input = ReadLine()!; // Null-forgiving operator.
//Regex ageChecker = new(@"^\d+$");
//Regex ageChecker = new(DigitsOnlyText);
Regex ageChecker = DigitsOnly();
WriteLine(ageChecker.IsMatch(input) ? "You entered a number." : 
    $"You did not enter a number {input}.");

string films = """
    "Mothers, Inc.", "I, Tonya", "Lock, Stock and Two Smoking Pigeons"
    """;
WriteLine($"Films to split:{films}");
string[] filmsDumb = films.Split(",");
WriteLine("Splitting with string.Split method:");
foreach (string film in filmsDumb)
    WriteLine(film);
WriteLine();

//Regex csv = new("(?:^|,)(?=[^\"]|(\")?)\"?((?(1)[^\"]*|[^,\"]*))\"?(?=,|$)");
//Regex csv = new(CommaSeparatorText);
Regex csv = CommaSeparator();
MatchCollection filmsSmart = csv.Matches(films);
WriteLine("Splitting with regular expressions:");
foreach (Match film in filmsSmart)
    WriteLine($"{film.Groups[2].Value}");