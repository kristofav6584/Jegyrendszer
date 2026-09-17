using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    public abstract class Utazas
    {
        public int Alapdij {  get; set; }
        public double Tavolsag { get; set; }

        protected Utazas(int alapdij, double tavolsag)
        {
            Alapdij = alapdij;
            Tavolsag = tavolsag;
        }

        public abstract int ArSzamitas();
    }
}
