


Console.WriteLine("Berechne Deinen BMI!");

double gr,gew;

gr = LeseZahlVonTastatur("Größe: ");
gew = LeseZahlVonTastatur("Gewicht: ");

double bmi = BerechneBmi(gr, gew);
bool isOk = BmiOk(bmi);

Console.WriteLine($"Dein Bmi ist {bmi:0.00} ({(isOk?"Gut":"BÖSE")})");

//ENDE VOM HAUPTPROGRAMM


bool BmiOk(double bmi)
{
    return bmi > 19 && bmi < 24;
}

double BerechneBmi(double gr, double gew)
{
    return gew / (gr * gr);
}

double LeseZahlVonTastatur(string v)
{
    Console.Write(v);
	try
	{
        return double.Parse(Console.ReadLine());
    }
    catch (Exception)
	{
        Console.WriteLine("FEHLER!");
        return LeseZahlVonTastatur(v);    //REKURSION
	}
}