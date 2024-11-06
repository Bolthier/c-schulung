// See https://aka.ms/new-console-template for more information
var m = new Mensch();
Console.WriteLine($"Mensch: {m.Alter}");
m.Geburtstag();
m.Geburtstag();
Console.WriteLine($"Mensch: {m.Alter}");
var h = new Hund();
Console.WriteLine($"Hund: {h.Alter}");
h.Geburtstag();
h.Geburtstag();
Console.WriteLine($"Hund: {h.Alter}");

class Mensch
{
    public string Name { get; set; }
    public int Alter { get; set; } = 0;

    public virtual void  Geburtstag()
    {
        Alter++;
    }
}
class Hund : Mensch
{
    public override void Geburtstag()
    {
        Alter += 7;
    }
}
