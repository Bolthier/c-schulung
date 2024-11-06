using De.Wortmann.Interfaces;

namespace De.Wortmann.Andi.Rechner
{
    public class MeinRechner : IRechner
    {
        public double Summe { get; private set; } = 0;

        public IRechner Cos()
        {
            Summe=Math.Cos(Summe);
            return this;
        }

        public IRechner Durch(double val)
        {
            Summe/=val;
            return this;
        }

        public IRechner Mal(double val)
        {
            Summe *= val;
            return this;
        }

        public IRechner Minus(double val)
        {
            Summe -= val;
            return this;
        }

        public IRechner Plus(double val)
        {
            Summe += val;
            return this;
        }
    }
}
