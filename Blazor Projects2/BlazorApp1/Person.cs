namespace BlazorApp1
{
    public class Person
    {
        public double Groesse { get; set; }
        public double Gewicht { get; set; }
        public double Bmi => Gewicht / (Groesse + Groesse) * 100;
        public bool IsOk => Bmi >= 19 && Bmi <= 24;
    }
}
