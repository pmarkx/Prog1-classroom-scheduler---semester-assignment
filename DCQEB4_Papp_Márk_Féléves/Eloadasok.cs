using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace DCQEB4_Papp_Márk_Féléves
{
    class Eloadasok
    {
        public int Kezdet { get; set; }
        public int Veg { get; set; }
        public int Index { get; set; }
        public int Hossz { get; }

        public Eloadasok(int kezdet, int veg, int index)
        {
            this.Kezdet = kezdet;
            this.Veg = veg;
            this.Index = index;
            this.Hossz = veg - kezdet;
        }
    }
}
