string name = "Samantha Jones";

// Getting the length of the first and last names.
int lengthOfFirst = name.IndexOf(' ');
int lengthOfLast = name.Length - lengthOfFirst - 1;

// using Substring.
string firstName = name.Substring(0, lengthOfFirst);
string lastName = name.Substring(name.Length - lengthOfLast, lengthOfLast);
Console.WriteLine($"First: {firstName}, Last: {lastName}");

// Using spans
ReadOnlySpan<char> nameAsSpan = name.AsSpan();
ReadOnlySpan<char> firstNameSpan = name.AsSpan(0.. lengthOfFirst);
ReadOnlySpan<char> lastNameSpan = name.AsSpan(^lengthOfLast..);
Console.WriteLine($"First: {firstNameSpan}, Last: {lastNameSpan}");