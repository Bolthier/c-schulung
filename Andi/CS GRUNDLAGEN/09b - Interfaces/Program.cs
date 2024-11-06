Console.WriteLine("Interfaces!");


IArtikel maus=new CloudService() { Einkaufspreis=4.99};



Console.WriteLine($"{maus.Verkaufspreis:0.00}");

class CloudService : IArtikel
{
    public double Einkaufspreis { get; set; }

    public double Verkaufspreis => Einkaufspreis * 10;
}

class Zubehoer : IArtikel
{
    public double Einkaufspreis { get; set; }

    public double Verkaufspreis => Einkaufspreis * 3;
}

interface IArtikel
{
    double Einkaufspreis { get; set; }
    double Verkaufspreis { get; }  //readonly
}
