namespace De.Wortmann.Andi
{
    public class Mensch
    {
        public Mensch()
        {
            
        }
        public double Groesse { get; set; }
        public double Gewicht { get; set; }
        public double Bmi => Gewicht/(Groesse*Groesse);

        public STATUS Status 
        { 
            get
            {
                if (Bmi < 19) return STATUS.UNTERGEWICHT;
                else if (Bmi > 24) return STATUS.ADIPOSITAS;
                else return STATUS.OK;
            }
        }

    }

    public enum STATUS
    {
        OK, UNTERGEWICHT, ADIPOSITAS
    }
}
