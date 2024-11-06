Console.WriteLine("Listen!");

var alle = File.ReadAllLines(@"t:\installs\deutsch.txt");

Console.WriteLine($"Anzahl Wörter: {alle.Length}");

foreach (var wort in alle)
{
    if (wort.Length>3 && (wort[3]=='x' || wort[3] == 'X'))
    {
        Console.WriteLine(wort);
    }
}
