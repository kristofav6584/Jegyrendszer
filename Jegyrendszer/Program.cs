using Jegyrendszer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jegyrendszer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Utazas> napiUtazasok = new List<Utazas>
            {
                new Vonalbusz(50, 10),
                new MeteoVonat(450, 25),
                new ElektromosRoller(5.5),
                new Vonalbusz(450, 3)
            };

            int bevetel = 0;

            foreach (Utazas utazas in napiUtazasok)
            {
                bevetel += utazas.ArSzamitas();
            }
            Console.WriteLine($"A napi bevétel: {bevetel}Ft");
        }
    }
}
