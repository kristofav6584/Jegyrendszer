using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    public class ElektromosRoller : Utazas
    {
        public ElektromosRoller(double tavolsag) : base(0, tavolsag) { }

        public override int ArSzamitas()
        {
            return (int)(Tavolsag * 120);
        }
    }
}
