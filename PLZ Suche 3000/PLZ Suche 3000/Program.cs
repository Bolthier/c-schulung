// See https://aka.ms/new-console-template for more information
using System.Linq;

Console.WriteLine("PLZ Suche!");
Console.Write("Suche nach Ort: ");
var suche = Console.ReadLine();
var allePlzs = File.ReadAllLines(@"z:\installs\plz.csv")
    .Select(zeile =>
    {
        string[] f = zeile.Split(",");
        return new
        {
            Plz = f[3],
            Ort = f[2],
            Landkreis = f[4],
            Bundesland = f[5]
        };
    });
foreach (var p in allePlzs.Where(x => x.Ort.Contains(suche,StringComparison.InvariantCultureIgnoreCase)))
{
    Console.WriteLine($"{p.Plz,-20}\t{p.Ort,-20}\t{p.Landkreis,-20}\t{p.Bundesland,-20}");
}