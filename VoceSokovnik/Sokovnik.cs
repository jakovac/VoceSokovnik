using System.Collections.Generic;
using System.Linq;

namespace VoceSokovnik
{
    public class Sokovnik : Posuda
    {
        //public Posuda Posuda { get; set; }

        //public Sokovnik(Posuda posuda)
        //{
        //    this.Posuda = posuda;
        //}

        public float Cediljka(List<Voce> voce)
        {
            return voce.Sum(x => x.Tezina) * 0.4f;
        }

    }

}