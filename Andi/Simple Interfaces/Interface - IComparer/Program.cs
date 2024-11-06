Console.WriteLine("Hello, World!");

string[] teilnehmers = { "Patrick", "Fabuis", "Ben", "Julian", "Viktoriia", "Stefan", "Jan", "Mirco", "Tobias" };

Array.Sort(teilnehmers,new MeinNachLängeAbsteigentSortierer()); //a-z


foreach (var t in teilnehmers)
{
    Console.WriteLine(t);
}

class MeinNachLängeAbsteigentSortierer : IComparer<string>
{
    public int Compare(string? x, string? y)
    {
        return x.Length > y.Length ? -1 : 1;
    }
}