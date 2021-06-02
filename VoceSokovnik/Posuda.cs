using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace VoceSokovnik
{
    public class Posuda
    {
        private readonly float Kapacitet = 30;
        public bool ImaVoca { get; set; } = false;
        public List<Voce> Voce { get; set; } = new List<Voce>();

        public Posuda()
        {
        }
        public void DodajVocku(Vrsta vocka)
        {
            //Console.WriteLine("Naziv: {0} , tezina: {1}g , da li je trula: {2} , sorta: {3}", vocka.Naziv, vocka.Tezina, vocka.JeTrula, vocka.Sorta);

            Voce.Add(vocka);

            if (Kapacitet == Voce.Sum(x => x.Tezina))
            {
                Console.WriteLine("Kapacitet pun: " + Voce.Sum(x => x.Tezina));
            }


            if (Kapacitet < Voce.Sum(x => x.Tezina))
            {
                Console.WriteLine("Premacen kapacitet: " + Voce.Sum(x => x.Tezina));
                throw new OverflowException("PremasenKapacitetException");
            }
        }

        public float PreostaloKapaciteta()
        {
            return Kapacitet - Voce.Sum(x=>x.Tezina);
        }

        public float KolicinaVocaUPosudi()
        {
            return Voce.Sum(x=>x.Tezina);
        }
    }
}