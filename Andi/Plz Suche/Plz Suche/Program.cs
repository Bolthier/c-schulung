// See https://aka.ms/new-console-template for more information
Console.WriteLine("Plzsuche");

Console.Write("Suche nach Ort: ");
var suche=Console.ReadLine();

var allePlzs = File.ReadAllLines(@"t:\installs\plz.csv")
    .Select(zeile =>
    {
        string[] f = zeile.Split(",");
        return new
        {
            Plz = f[3],
            Ort = f[2],
            Landkreis= f[4],
            Bundesland= f[5]
        };
    });

foreach (var p in allePlzs.Where(x=>x.Ort.Contains(suche,StringComparison.InvariantCultureIgnoreCase)))
{
    Console.WriteLine($"{p.Plz}\t{p.Ort,-40}\t{p.Landkreis,-40}\t{p.Bundesland}");
}

