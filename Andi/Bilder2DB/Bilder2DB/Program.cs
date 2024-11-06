// See https://aka.ms/new-console-template for more information
using Bilder2DB;

Console.WriteLine("Bilder in DB");

var alleBilderDateien = new DirectoryInfo(@"t:\").GetFiles("*.*", SearchOption.AllDirectories)
                            .Where(x => x.Extension == ".jpg" || x.Extension == ".gif" || x.Extension == ".png")
                            .Select(x => new BildModel()
                            {
                                VollerName = x.FullName,
                                Name = x.Name.Split('.')[0],
                                Typ = x.Extension.Replace(".", ""),
                                Groesse = (int)x.Length,
                                Datum = x.LastAccessTime
                            });

var ctx = new MyDbContext();
int counter = 0;
foreach (var b in alleBilderDateien)
{
    Console.WriteLine(b.VollerName);
    b.Daten = File.ReadAllBytes(b.VollerName);
    ctx.Bilders.Add(b);
    if (counter++ % 100 == 0)
    {
        ctx.SaveChanges();
    }
}
ctx.SaveChanges();
