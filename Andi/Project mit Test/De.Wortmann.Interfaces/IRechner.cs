namespace De.Wortmann.Interfaces
{
    public interface IRechner
    {
        public double Summe { get; }
        public IRechner Plus(double val);
        public IRechner Minus(double val);
        public IRechner Mal(double val);
        public IRechner Durch(double val);
        public IRechner Cos();
    }
}
