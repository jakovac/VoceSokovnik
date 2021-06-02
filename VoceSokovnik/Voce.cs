using System;

namespace VoceSokovnik
{
    public class Voce
    {
        public string Naziv { get; set; }
        public float Tezina { get; set; }
        public bool JeTrula { get; set; }

        //public Voce()
        //{
        //}
        public Voce(string naziv, float tezina, bool jeTrula)
        {
            this.Naziv = naziv;
            this.Tezina = tezina;
            this.JeTrula = jeTrula;

        }

    }
}