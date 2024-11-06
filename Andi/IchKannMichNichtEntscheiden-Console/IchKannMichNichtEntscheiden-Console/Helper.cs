using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IchKannMichNichtEntscheiden_Console
{
    public  class Helper
    {
        public string Titel { get; set; }
        public List<string> Options { get; set; } = new List<string>();

        public void AddOption(string option) {
            foreach (string value in Options)
            {   
                if (value.Equals(option))
                {
                    throw new Exception("DOPPELT"); //ENDE
                }
            }
            Options.Add(option);
        }

        public int Entscheide()=>new Random().Next(Options.Count);

    }
}
