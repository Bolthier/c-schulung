using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Console.Business
{
    public class Hangman
    {
        public string SecretWord { get; set; }
        public string TheView { get; set; }
        public int ErrorCount { get; set; } = 0;
        public bool IsDead => ErrorCount >=10;  //Readonly-Property
        public bool IsWon => SecretWord==TheView;

        public Hangman()  //Konstruktor
        {
            NeuesSpiel();
        }
        public void NeuesSpiel()
        {
            var all = File.ReadAllLines(@"z:\installs\deutsch.txt");
            SecretWord = all[new Random().Next(all.Length)];
            TheView = new string('-', SecretWord.Length);
        }
        public void Input(string c)
        {
            bool isFound=false;
            var temp = "";
            for (int i = 0; i < SecretWord.Length; i++)
            {
                if (SecretWord.ToLower()[i] == c.ToLower()[0])
                {
                    temp += SecretWord[i];
                    isFound= true;
                }
                else
                {
                    temp += TheView[i];
                }
            } //ende von for
            TheView = temp;
            if (!isFound) 
                ErrorCount++;
        }
    }
}
