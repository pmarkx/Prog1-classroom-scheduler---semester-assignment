using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCQEB4_Papp_Márk_Féléves
{
    static class Beosztas
    {
        public static Eloadasok[] Minimumkivalasztasosrendezes(Eloadasok[] tomb)
        {
            for (int i = 0; i < tomb.Length - 1; i++)
            {
                int minimum = i;
                for (int j = i + 1; j < tomb.Length; j++)
                {
                    if (tomb[minimum].Kezdet > tomb[j].Kezdet || (tomb[minimum].Kezdet == tomb[j].Kezdet && tomb[minimum].Hossz > tomb[j].Hossz))
                    {
                        minimum = j;
                    }
                }
                //csere
                Eloadasok tmp = tomb[i];
                tomb[i] = tomb[minimum];
                tomb[minimum] = tmp;
            }
            return tomb;
        }

        public static void Matrixok(Eloadasok[] tomb,string filenev)
        {
            Eloadasok[] aterem = new Eloadasok[tomb.Length];
            Eloadasok[] bterem = new Eloadasok[tomb.Length];
            string teremvalto = "a";
            int ateremszalalo = 0;
            int bteremszamlalo = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (i == 0)
                {
                    aterem[ateremszalalo++] = tomb[i];
                }
                else
                {
                    if (bteremszamlalo == 0)
                    {
                        bterem[bteremszamlalo++] = tomb[i];
                        teremvalto = "b";
                    }
                    else
                    {
                        if (teremvalto == "a")
                        {
                            if (bterem[bteremszamlalo - 1].Veg < tomb[i].Kezdet)
                            {
                                bterem[bteremszamlalo++] = tomb[i];
                                teremvalto = "b";
                            }
                            else if (aterem[ateremszalalo - 1].Veg < tomb[i].Kezdet)
                            {
                                aterem[ateremszalalo++] = tomb[i];
                                teremvalto = "a";
                            }
                        }
                        else if (teremvalto == "b")
                        {
                            if (aterem[ateremszalalo - 1].Veg < tomb[i].Kezdet)
                            {
                                aterem[ateremszalalo++] = tomb[i];
                                teremvalto = "a";
                            }
                            else if (bterem[bteremszamlalo - 1].Veg < tomb[i].Kezdet)
                            {
                                bterem[bteremszamlalo++] = tomb[i];
                                teremvalto = "b";
                            }
                        }
                    }
                }
            }
            Console.WriteLine("\nA terem");
            for (int i = 0; i < ateremszalalo; i++)
            {
                Console.WriteLine(aterem[i].Kezdet +"\t"+ aterem[i].Veg +"\t"+ aterem[i].Index);
            }
            Console.WriteLine("\nB terem");
            for (int i = 0; i < bteremszamlalo; i++)
            {
                Console.WriteLine(bterem[i].Kezdet + "\t" + bterem[i].Veg + "\t" + bterem[i].Index);
            }
            IO.Kiir(filenev, aterem, bterem, ateremszalalo, bteremszamlalo);
        }
    }
}
