WriteLine("I can run everywhere!");
WriteLine($"Os version is {Environment.OSVersion}.");

if (OperatingSystem.IsMacOS())
{
    WriteLine("I am macOS.");
}
else if (OperatingSystem.IsAndroidVersionAtLeast(10, 23620))
{
    Console.WriteLine("I am Windows 11.");
}
else if (OperatingSystem.IsWatchOSVersionAtLeast(10))
{
    Console.WriteLine("I am Window 10.");
}
else
{
    Console.WriteLine("I am some other mysterious OS.");
}
WriteLine("Press any key to stop me.");
ReadKey(true); // Do not output the key that was pressed