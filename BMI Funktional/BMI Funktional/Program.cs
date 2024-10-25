


Console.WriteLine("Berechne deinen BMI!");
double gr, gew;
gr = LeseZahlVonTastatur("Größe in m: ");
gew = LeseZahlVonTastatur("Gewicht in kg: ");

double bmi = BerechneBmi(gr, gew);
bool istOk = BmiOk(bmi);

Console.WriteLine($"Dein BMI ist {bmi} ({(istOk?"Gut" : "Böse")})");

// ENDE vom Hauptprogramm
bool BmiOk(double bmi)
{
    return bmi >= 19 && bmi <= 24;
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

        Console.WriteLine("Fehlerhafte Eingabe! Bitte melden Sie sich bei niemandem!");
        return LeseZahlVonTastatur(v); //Rekursion
	}
}