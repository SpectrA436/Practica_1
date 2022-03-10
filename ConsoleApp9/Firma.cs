using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica
{
    class Firma
    {
        public string FName { set; get; }

        public string FAdres { set; get; }

        public int FGod { set; get; }

        public Firma() { }

        public Firma(string FName, string FAdres, int FGod)
        {
            FName = this.FName;
            FAdres = this.FAdres;
            FGod = this.FGod;
        }
    }
}

