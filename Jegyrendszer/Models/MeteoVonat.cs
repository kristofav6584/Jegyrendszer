using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer.Models
{
    public class MeteoVonat : Utazas
    {
        public MeteoVonat(int alapdij, double tavolsag) : base(alapdij, tavolsag){ }

        public override int ArSzamitas()
        {
            return (Alapdij * 2) + (int)(Tavolsag * 50);
        }
    }
}
