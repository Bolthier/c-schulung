using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Console.Business
{
    public class Overview
    {
        public int SpieleAnzahl { get; set; } = 1;
        public int Siege { get; set; } = 0;
        public int Niederlagen { get; set; } = 0;
    }
    public class Hangman
    {
        public string SecretWord { get; set; }
        public string TheView { get; set; }
        public int ErrorCount { get; set; }
        public bool IsDead => ErrorCount >= 10; //Read only prop
        public bool IsWon => SecretWord == TheView;

        public Hangman() //Constructor
        {
            var alle = File.ReadAllLines(@"C:\LABS\ListenSample\deutsch.txt");
            SecretWord = alle[new Random().Next(alle.Length)];
            TheView = new string('-',SecretWord.Length);
        }
        public void Input(string c)
        {
            bool isFound = false;
            var temp = "";
            for (int i = 0; i < SecretWord.Length; i++)
            {
                if (SecretWord.ToLower()[i] == c.ToLower()[0])
                {
                    temp += SecretWord[i];
                    isFound = true;
                }
                else
                {
                    temp += TheView[i];
                }

            }
            TheView = temp;
            if (!isFound) ErrorCount++;
        }
    }
}
