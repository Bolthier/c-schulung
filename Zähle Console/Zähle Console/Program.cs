// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("Hello, World!");

var sw = new Stopwatch();
sw.Start();

var anz = new DirectoryInfo("C:/LABS").GetFiles("*.cs", SearchOption.AllDirectories)
    .AsParallel()
    .Select(f =>
    {
        var t = File.ReadAllText(f.FullName);
        return t.Split(' ', '.').Where(x => x.Equals("Console")).Count();
    })
    .Sum();

sw.Stop();

Console.WriteLine($"Anzahl: {anz} Dauer: {sw.ElapsedMilliseconds} ms");