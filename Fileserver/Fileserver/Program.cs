// See https://aka.ms/new-console-template for more information
Console.WriteLine("Fileserver!");

var alleFiles = new DirectoryInfo("c:/windows/system32").GetFiles()
    .Where(x => x.Name.EndsWith(".exe"))
    .OrderByDescending(x => x.Length)
    .Take(10);
   

foreach (var item in alleFiles)
{
    Console.WriteLine($"{item.Name,-30}\t{item.Length} B");
}

