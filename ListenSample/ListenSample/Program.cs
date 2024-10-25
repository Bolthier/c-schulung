// See https://aka.ms/new-console-template for more information
Console.WriteLine("Listen!");

var alle = File.ReadAllLines(@"C:\LABS\ListenSample\deutsch.txt");
Console.WriteLine($"Anzahl Wörter: {alle.Length}");
foreach (var wort in alle)
{
    if (wort[0]=='x' || wort[0] == 'X')
    {
        Console.WriteLine(wort);
    }
}