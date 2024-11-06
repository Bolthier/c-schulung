// See https://aka.ms/new-console-template for more information
Console.WriteLine("Events!");

var watcher = new FileSystemWatcher("c:/") {IncludeSubdirectories=true, EnableRaisingEvents=true };
watcher.Filter = "*.txt";

watcher.Created += Watcher_Created;

void Watcher_Created(object sender, FileSystemEventArgs e)
{
    Console.WriteLine($"NEU: {e.FullPath}");
}

Console.ReadLine();