Console.WriteLine("Größten 10 Programme!");


var dateiens = new DirectoryInfo(@"c:\windows\system32").GetFiles().Where(x => x.Name.EndsWith(".exe"));
dateiens = dateiens.OrderByDescending(x => x.Length);
dateiens = dateiens.Take(10);

foreach (var f in dateiens)
{
    Console.WriteLine($"{f.Name,-40}\t{f.Length,20} Bytes ");
}