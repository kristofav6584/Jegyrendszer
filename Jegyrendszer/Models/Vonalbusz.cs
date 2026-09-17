using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    public class Vonalbusz : Utazas
    {
        public Vonalbusz(int alapdij, double tavolsag) : base(alapdij, tavolsag)
        { }
            public override int ArSzamitas()
        { return Alapdij + (int)(Tavolsag * 30); }
    }
}

