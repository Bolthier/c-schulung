// See https://aka.ms/new-console-template for more information
Console.WriteLine("Events!");

var watcher = new FileSystemWatcher("c:/","*.txt") { IncludeSubdirectories = true,EnableRaisingEvents = true };
watcher.Created += Watcher_Created;



void Watcher_Created(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"Neu: {e.FullPath}");
}

Console.ReadLine();
