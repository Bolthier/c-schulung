namespace First
{
    public class Person
    {
        public double Groesse { get; set; }
        public double Gewicht { get; set; }
        public double Bmi => Gewicht / (Groesse * Groesse);
        public bool IsOk => Bmi > 19 && Bmi < 24;
    }
}
