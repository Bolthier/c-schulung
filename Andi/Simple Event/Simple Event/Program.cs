// See https://aka.ms/new-console-template for more information
Console.WriteLine("Events");

var klaus = new Mensch() { Name = "Klaus", Alter = 42 };
klaus.HatGeburtstag += (m) =>
{
    Console.WriteLine(m);
};
Action<Mensch> x = (m) => Console.WriteLine($"{m.Name} ist tot...");
klaus.IstGestorben += x;
klaus.IstGestorben += x;
klaus.IstGestorben += x;
klaus.IstGestorben += x;
klaus.IstGestorben += x;



Console.WriteLine(klaus);




class Mensch
{
    public string Name { get; set; }
    public int Alter { get; set; }

    public event Action<Mensch> HatGeburtstag;
    public event Action<Mensch> IstGestorben;

    public Mensch() {
        new Thread(() =>
        {
            while (Alter < 80)
            {
                Geburtstag();
                HatGeburtstag?.Invoke(this);
                Thread.Sleep(100);
            }
            IstGestorben?.Invoke(this);
        }).Start();
    }

    public override string ToString()
    {
        return $"{Name} ist nun {Alter} Jahre alt...";
    }
    public void Geburtstag()
    {
        Alter++;
    }
}