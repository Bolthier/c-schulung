// See https://aka.ms/new-console-template for more information
using De.Wortmann.Bank.Implementation;

Console.WriteLine("Banken!");
var alle = new DateiSystemBankHelper().AlleBanken;
foreach (var bank in alle
    .GroupBy(x=>x.Ort)
    .Select(x => new {Ort = x.Key, Anzahl = x.Count()})
    .OrderByDescending(x => x.Anzahl)
    .Take(10)
    )
{
    Console.WriteLine($"{bank.Ort, -40}\t{bank.Anzahl}");
}

Console.WriteLine($"");