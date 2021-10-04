using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCQEB4_Papp_Márk_Féléves
{
    class Program
    {
        static void Main(string[] args)
        {
            Eloadasok[] ea = IO.Beolvasas("RENDEZ.BE.txt");
            for (int i = 0; i < ea.Length; i++)
            {
                Console.WriteLine(ea[i].Kezdet + "\t" + ea[i].Veg + "\t" + ea[i].Index + "\t" + ea[i].Hossz);
            }
            ea = Beosztas.Minimumkivalasztasosrendezes(ea);
            Console.WriteLine();
            for (int i = 0; i < ea.Length; i++)
            {
                Console.WriteLine(ea[i].Kezdet + "\t" + ea[i].Veg + "\t" + ea[i].Index + "\t" + ea[i].Hossz);
            }
            Beosztas.Matrixok(ea,"RENDEZ.KI.txt");
            Console.ReadLine();
        }
    }
}
