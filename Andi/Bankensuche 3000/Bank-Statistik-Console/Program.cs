using De.Wortmann.Bank.Implementations;

Console.WriteLine("BANKEN!");

var alle=new DateisystemBankHelper().AlleBanken;

foreach (var b in alle
    .GroupBy(x=>x.Ort)
    .Select(x => new {Ort=x.Key, Anzahl=x.Count() })
    .OrderByDescending(x => x.Anzahl)
    .Take(10)
    )
{
    Console.WriteLine($"{b.Ort,40}\t{b.Anzahl}");
}
