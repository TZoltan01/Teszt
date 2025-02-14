using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PonHatOOP
{
    public class PontHat
    {
        public int Pontszam { get; private set; }
        public string Osztalyzat { get; private set; }

        // Konstruktor
        public PontHat()
        {
            Pontszam = 0;
            Osztalyzat = "";
        }

        // Pontszám beállítása
        public void PontszamBeallitas(int pontszam)
        {
            if (pontszam < 0 || pontszam > 100)
            {
                throw new ArgumentException("Hibás pontszám! A pontszám 0 és 100 között kell legyen.");
            }

            Pontszam = pontszam;
            OsztalyzatMeghatarozas();
        }

        // Osztályzat meghatározása
        public void OsztalyzatMeghatarozas()
        {
            if (Pontszam >= 90)
            {
                Osztalyzat = "5";
            }
            else if (Pontszam >= 80)
            {
                Osztalyzat = "4";
            }
            else if (Pontszam >= 65)
            {
                Osztalyzat = "3";
            }
            else if (Pontszam >= 50)
            {
                Osztalyzat = "2";
            }
            else
            {
                Osztalyzat = "1";
            }
        }

        // Eredmény lekérése
        public string Eredmeny()
        {
            return $"Pontszám: {Pontszam}, Osztályzat: {Osztalyzat}";
        }
    }
}

