using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DCQEB4_Papp_Márk_Féléves
{
    static class IO
    {
        public static Eloadasok[] Beolvasas(string filenev)
        {
            StreamReader streamReader = new StreamReader(filenev);
            int eloadasokszama = int.Parse(streamReader.ReadLine());
            Eloadasok[] eloadasok = new Eloadasok[eloadasokszama];
            string temp = "";
            while (!streamReader.EndOfStream)
            {
                for (int i = 0; i < eloadasokszama; i++)
                {
                    temp = streamReader.ReadLine();
                    string[] temp2 = temp.Split(' ');
                    eloadasok[i] = new Eloadasok(int.Parse(temp2[0]), int.Parse(temp2[1]), i + 1);
                }
            }
            streamReader.Close();
            return eloadasok;
        }
        public static void Kiir(string filenev,Eloadasok[]aterem,Eloadasok[]bterem,int ateremszalalo,int bteremszalalo)
        {
            StreamWriter streamWriter = new StreamWriter(filenev,false);
            streamWriter.WriteLine(ateremszalalo + " " + bteremszalalo);
            for (int i = 0; i < ateremszalalo; i++)
            {
                streamWriter.Write(aterem[i].Index + " ");
            }
            streamWriter.WriteLine();
            for (int i = 0; i < bteremszalalo; i++)
            {
                streamWriter.Write(bterem[i].Index + " ");
            }
            streamWriter.Close();
        }
    }
}
