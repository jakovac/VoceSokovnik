using System;

namespace VoceSokovnik
{
    public class Vrsta : Voce
    {
        public string Sorta { get; set; }

        public Vrsta(string naziv, float tezina, bool jeTrula, string sorta) 
           : base(naziv, tezina, jeTrula)

        {
            this.Sorta = sorta;
            //Console.WriteLine("Naziv: {0} , tezina: {1}g , da li je trula: {2} , sorta: {3}", naziv, tezina, jeTrula, sorta);
        }
    }
}