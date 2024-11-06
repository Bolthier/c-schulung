// See https://aka.ms/new-console-template for more information
Console.WriteLine("Tobias!");

var jk = new JuliansKlasse();


Console.WriteLine($"Summe: {jk.GetSumme()}");
Console.WriteLine($"MW: {jk.GetMW()}");
Console.WriteLine($"Produkt: {jk.MachMal(Mal)}");
Console.WriteLine($"Diff: {jk.MachMal((a,s) => Math.Abs(a-s))}");  //annonymous function

int Mal(int q, int w)
{
    return q*w;
}

//Backend

//Typ einer Funktion
delegate int MyFuncTyp(int x, int y);

class JuliansKlasse
{
    private int a=111, b=555;

    public int MachMal(MyFuncTyp func)
    {
        return func(a, b);
    }
    public int GetSumme() { return a + b; }
    public int GetMW() { return (a + b)/2; }
}