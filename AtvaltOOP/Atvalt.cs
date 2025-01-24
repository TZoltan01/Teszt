using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Az osztaly feladata: 
 * A megadott binaris szamot atvaltja tizes alapu szamma es vissza.
 * Metodusok: 
 * - Konstruktor
 * - Szam input stringkent. Megjegyzes Mivel lehet olyan decimalis szam, amely csak nullabol es egyesbol all, ezert kikotjuk, hogy a binaris szam elso karaktere pl. 0 legyen!
 * - Atlvaltas
 * Eredmeny lekerese stringkent
 */

namespace AtvaltOOP
{
    internal class Atvalt
    {
        // Osztalyvaltozok
        string eredmeny = string.Empty; // Az eredmenyt ebbe kepezzuk
        int decSzam = 0; // Az atalakitando decimalis szam valtozoja

        public Atvalt() { }
        public Atvalt(string szam)
        {
            // Ellenorzom az inputot
            if (isBinaris(szam)) binarisToDecimalis(szam); // Ha binaris atalakitom decimalissa, egyebkent...
            else if (isDecimal(szam)) decimalToBinaris(szam); // ... ha decimalis, akkor atalakitom binarissa, egyebkent...
            else throw new FormatException("A megadott adat nem szam!"); // ... hibas az adat
        }

        private void decimalToBinaris(string szam)
        {
            // Az eljaras a 2-es maradekos osztas elve
            while (decSzam > 0)
            {
                eredmeny = decSzam % 2 + eredmeny;
                decSzam /= 2;
            }
        }

        private bool isDecimal(string szam)
        {
            // A decimalist ugy vizsgaljuk, hogy konvertalhato-e
            bool eredm = true;
            try
            {
                decSzam = Math.Abs(Convert.ToInt32(szam)); // Egyuttal el is taroljuk az eredmenyt
            }
            catch (Exception)
            {
                eredm = false;
            }
            return eredm;
        }

        private void binarisToDecimalis(string szam)
        {
            // Az eljaras a helyi es alaki ertek szorzata
            int j = 1;
            for (int i = szam.Length - 1; i > 0; i--)
            {
                decSzam += Convert.ToInt32(szam[i]) * j;
                j *= 2;
            }
        }

        private bool isBinaris(string szam)
        {
            bool eredm = true;
            if (szam[0] == '0') // Mivel az elvaras szerint a binaris szam elso karaktere 0!
                for (int i = 1; i < szam.Length; i++)
                    if (szam[i] != '0' && szam[i] != '1') // Ha nem egyenlo 0-val es nem egyenlo 1-gyel, akkor mar nem lehet binaris ...
                    {
                        eredm = false;
                        break; // ... ezert befejezodik a cilus
                    }
            return eredm;
        }
    }
}