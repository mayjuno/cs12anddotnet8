﻿using Spectre.Console;  // TO use Table.

#region Handling cross-platform environments and filesystems

SectionTitle("Handling cross-platform environments and filesystems");

// Create a Spectre Console table.
Table table = new();

// Add two columns with markup for colors.
table.AddColumn("[blue]MEMBER[/]");
table.AddColumn("[blue]VALUE[/]");
// Add rows
table.AddRow("Path.PathSeparator", Path.PathSeparator.ToString());
table.AddRow("Path.DirectorySeparatorChar", Path.DirectorySeparatorChar.ToString());
table.AddRow("Directory.GetCurrentDirectory()", Directory.GetCurrentDirectory());
table.AddRow("Environment.CurrentDirectory", Environment.CurrentDirectory);
table.AddRow("Environment.SystemDirectory", Environment.SystemDirectory);
table.AddRow("Path.GetTempPath()", Path.GetTempPath());
table.AddRow("");
table.AddRow("GetFolderPath(SpecialFolder", "");
table.AddRow("   .System)",GetFolderPath(SpecialFolder.System));
table.AddRow("GetFolderPath(SpecialFolder", "");
table.AddRow("   .ApplicationData)", GetFolderPath(SpecialFolder.ApplicationData));
table.AddRow("    .MyDocuments)", GetFolderPath(SpecialFolder.MyDocuments));
table.AddRow("GetFolderPath(SpecialFolder", "");
table.AddRow("   .Personal)", GetFolderPath(SpecialFolder.Personal));

// Render the table to the console.
AnsiConsole.Write(table);

SectionTitle("Managing drives");
Table drives = new();
drives.AddColumn("[blue]NAME[/]");
drives.AddColumn("[blue]TYPE[/]");
drives.AddColumn("[blue]FORMAT[/]");
drives.AddColumn(new TableColumn("[blue]SIZE (BYTES)[/]").RightAligned());
drives.AddColumn(new TableColumn("[blue]FREE SPACE[/]").RightAligned());

foreach (DriveInfo drive in DriveInfo.GetDrives())
{
    if (drive.IsReady)
    {
        drives.AddRow(
            drive.Name, 
            drive.DriveType.ToString(), 
            drive.DriveFormat, 
            drive.TotalSize.ToString("N0"), 
            drive.AvailableFreeSpace.ToString("N0"));
    }
    else
    {
        drives.AddRow(
            drive.Name, 
            drive.DriveType.ToString(),
            string.Empty,
            string.Empty,
            string.Empty);
    }
    
}
AnsiConsole.Write(drives);

SectionTitle("Managing directories");
string newFolder = Combine(GetFolderPath(SpecialFolder.Personal), "NewFolder");
WriteLine($"Working with:{newFolder}");

// We must explicitly say which Exists method to use
// because we statically import both Path and Directory.
WriteLine($"Does it exit? {Path.Exists(newFolder)}");
WriteLine("Creating it...");
CreateDirectory(newFolder);

// Let's use the Directory.Exists method this time.
WriteLine($"Does it exist? {Directory.Exists(newFolder)}");
Write("Confirm the directory exists, and then press any key.");
ReadKey(true);
WriteLine("Deleting it...");
Delete(newFolder, true);
WriteLine($"Does it exist? {Path.Exists(newFolder)}");

/* File Managing */
SectionTitle("Managing files");
// Define a directory path to output files string in the user's folder.
string dir = Combine(GetFolderPath(SpecialFolder.Personal), "OutputFiles");

CreateDirectory(dir);

// Define file paths.
string textFile = Combine(dir, "Dummy.txt");
string backupFile = Combine(dir, "Dummy.bak");
WriteLine($"Working with: {textFile}");

WriteLine($"Does it exist? {File.Exists(textFile)}");


// Create a new text file and write a line to it.
StreamWriter textWriter = File.CreateText(textFile);
textWriter.WriteLine("Hello, C#!");
textWriter.Close();  // Close file and release resources.
WriteLine($"Does it exist? {File.Exists(textFile)}");


// Copy the file , and overwrite if it already exists.
File.Copy(textFile, backupFile, true);
WriteLine($"Does {backupFile} exist? {File.Exists(backupFile)}");

Write("Confirm the files exist, and then press any key.");
ReadKey(true);

// Delete the  file.
File.Delete(textFile);
WriteLine($"Does it exist? {File.Exists(textFile)}");


// Read from the text file backup
WriteLine($"Reading contents of {backupFile}:");
StreamReader textReader = File.OpenText(backupFile);
WriteLine(textReader.ReadToEnd());
textReader.Close();


/* Managing paths */
SectionTitle("Managing paths");

WriteLine($"Folder Name: {GetDirectoryName(textFile)}");
WriteLine($"File Name: {GetFileName(textFile)}");
WriteLine("File Name without Extension:{0}", GetFileNameWithoutExtension(textFile));
WriteLine($"File Extension: {GetExtension(textFile)}");
WriteLine($"Random File Name: {GetRandomFileName()}");
WriteLine($"Temporary File Name: {GetTempFileName()}");

/* Getting file information */
SectionTitle("Getting file information");

FileInfo info = new(backupFile);
WriteLine($"{backupFile}");
WriteLine($"   Contains {info.Length}");
WriteLine($"    Last accessed: {info.LastAccessTime}");
WriteLine($"   Has readonly set to {info.IsReadOnly}");
#endregion