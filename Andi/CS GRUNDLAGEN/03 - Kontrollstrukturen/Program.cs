// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine(DateTime.Now.Second);
if (DateTime.Now.Second % 2 == 0)
{
    Console.WriteLine("Gerade");
}

SIMPSONS wer=SIMPSONS.LISA;

switch (wer)
{
    case SIMPSONS.BART:
        break;
    case SIMPSONS.HOMER:
        break;
    case SIMPSONS.LISA:
        break;
    case SIMPSONS.MAGGY:
        break;
    case SIMPSONS.MARGE:
        break;
    default:
        break;
}


//Schleifen
int i = 0;
for (; i < 10; i++)
{
    Console.WriteLine(i);
}

while (i>0)
{
    i--;
    Console.WriteLine(i);
}

foreach (var datei in new DirectoryInfo("c:/windows/system32").GetFiles())
{
    Console.WriteLine(datei);
}
enum SIMPSONS
{
    BART, HOMER, LISA, MAGGY, MARGE
}

