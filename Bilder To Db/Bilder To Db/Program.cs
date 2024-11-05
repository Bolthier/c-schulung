// See https://aka.ms/new-console-template for more information
using Bilder_To_Db;
using System.Diagnostics.Metrics;

Console.WriteLine("Bilder in DB!");

var alleBilderDateien = new DirectoryInfo(@"z:\").GetFiles("*.*", SearchOption.AllDirectories)
    .Where(x => x.Extension == ".jpg" || x.Extension == ".png" || x.Extension == ".gif")
    .Select(x=> new BildModel()
    {
        VollerName = x.FullName,
        Name = x.Name.Split(".")[0],
        Type = x.Extension.Replace(".",""),
        Groesse = (int)x.Length,
        Datum = x.LastAccessTime
    });

var ctx = new MyImagesContext();
int counter = 0;
foreach (var b in alleBilderDateien)
{
    Console.WriteLine(b.VollerName);
    b.Daten = File.ReadAllBytes(b.VollerName);
    ctx.Bilds.Add(b);
    if (counter++ % 100 == 0)
    {
        ctx.SaveChanges();
    }
}
ctx.SaveChanges();

