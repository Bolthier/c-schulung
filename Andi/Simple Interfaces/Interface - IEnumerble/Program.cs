using System.Collections;

Console.WriteLine("IEnumerable");

var cs = new Kurs();

foreach (var t in cs)
{
    Console.WriteLine(t);
}



class Kurs : IEnumerable
{
    private string[] teilnehmers = { "Patrick", "Fabuis", "Ben", "Julian", "Viktoiia", "Stefan","Jan","Mirco","Tobias" };

    public IEnumerator GetEnumerator()
    {
        return teilnehmers.GetEnumerator();
    }

}
