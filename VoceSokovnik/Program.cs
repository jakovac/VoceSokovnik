using System;

namespace VoceSokovnik
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int brojAkcija = 100;
            var sokovnik = new Sokovnik();
            var dodavanja = 0;
            var cedjenja = 0;
            var trule = 0;
            var iscedjenoSoka = 0f;
            int i = 0;
            while (i < brojAkcija)
            {
                var jabuka = new Vrsta("Jabuka", random.Next(1, 4), random.Next(100) <= 20 ? true : false, "Greni smit");
                if (random.Next(1, 101) <= 70) //70% da ubaci
                {
                    if (!jabuka.JeTrula)
                    {
                        //Console.WriteLine("Naziv: {0} , tezina: {1}g , da li je trula: {2} , sorta: {3}", jabuka.Naziv, jabuka.Tezina, jabuka.JeTrula, jabuka.Sorta);
                        Console.WriteLine("Dodavanje");
                        sokovnik.DodajVocku(jabuka);
                        dodavanja++;
                        sokovnik.ImaVoca = true;
                        i++;
                    }

                    else
                    {
                        trule++;
                        Console.WriteLine("TRULA !");
                        i++;
                    }

                }
                else if(random.Next(1, 31) <= 30 && sokovnik.ImaVoca) //30% da cedi
                {
                    Console.WriteLine("Cedjenje");
                    iscedjenoSoka += sokovnik.Cediljka(sokovnik.Voce);
                    Console.WriteLine("Od {0}kg jabuka {1}l soka, preostalo mesta za jos {2}kg", sokovnik.KolicinaVocaUPosudi(),sokovnik.Cediljka(sokovnik.Voce), sokovnik.PreostaloKapaciteta());
                    sokovnik = new Sokovnik();
                    cedjenja++;
                    i++;
                }
            }

            Console.WriteLine("Dodavanja: " + dodavanja + " ,Cedjenja: " + cedjenja + " ,Trulih:" + trule);

            Console.WriteLine("Ukupno soka: " + iscedjenoSoka);

        }
    }
}
