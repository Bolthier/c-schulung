Console.WriteLine("Interfaces!");

var m = new Mirko();

Console.WriteLine(m.Berechne(new MeineDaten() { A = 333, B = 2 , Op="*"}));



class MeineDaten : IData, IDisposable
{
    public int A { get; set; }
    public int B { get; set; }
    public string Op { get; set; }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}



class Mirko
{
    public int Berechne(IData data)
    {
        switch (data.Op)
        {
            case "+": return data.A + data.B;
            case "*": return data.A * data.B;
            case "-": return data.A - data.B;
            case "/": return data.A / data.B;
        }
        return 0;
    }

}

interface IData
{
    public int A { get; set; }
    public int B { get; set; }
    public string Op { get; set; }

}
