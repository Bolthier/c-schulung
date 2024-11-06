Console.WriteLine("Bmi!");

var andi=new Trainer();  //instanziieren
andi.SetGroesse(1.86);
andi.Gewicht = 95;
andi.Name = "Andi";

Console.WriteLine($"{andi.Name}: Geicht: {andi.Gewicht} Größe: {andi.GetGroesse()}  BMI: {andi.Bmi:0.00}" +
    $" Status: {(andi.IsOk?"GUT":"BÖSE")}");

var stunde = 0;
while (!andi.IsOk)
{
    andi.EineHSport();
    stunde++;
}
Console.WriteLine($"Nach {stunde} Stunden Sport:");
Console.WriteLine($"{andi.Name}: Geicht: {andi.Gewicht} Größe: {andi.GetGroesse()}  BMI: {andi.Bmi:0.00}" +
    $" Status: {(andi.IsOk ? "GUT" : "BÖSE")}");

class Trainer : Person   //Inheritance - Vererbung
{
    public new double Bmi
    {
        get { return base.Bmi * .8; }
    }
}

class Person
{
    private double groesse;  //Feld
    private double gewicht;  //Feld

    public string Name { get; set; }  //Property

    public void SetGroesse(double val)  //Methode
    {
        if (val > 4) throw new Exception("ZU gross");
        groesse = val;
    }
    public double GetGroesse()
    {
        return groesse;
    }

    public double Gewicht  //Property
    {
        get { return gewicht; }
        set { gewicht = value; }
    }

    public double Bmi  //readonly Property   virtual --> übersdchreibar
    {
        get { return gewicht / (groesse * groesse); }
    }
    public bool IsOk //readonly Property
    {
        get { return Bmi>19 && Bmi<24; }
    }

    public void EineHSport()
    {
        gewicht -= .1;
    }

}
