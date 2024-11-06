Console.WriteLine("Felder!");

int[] feld = new int[3];

feld[0] = 22;
feld[1] = 33;
feld[2] = 52;

int summe = 0;
foreach (var item in feld)
{
    summe += item;
}
Console.WriteLine(summe / feld.Length);