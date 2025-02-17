using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IrodalomProject.Models
{
    internal class Kerdes
    {
        public Kerdes(string kerdesszovege, string valaszA,string valaszB,string valaszC,string helyesValasz,string felhValasz)
        {
           KerdesSzovege = kerdesszovege;
            ValaszA = valaszA;
            ValaszB = valaszB;
            ValaszC = valaszC;
            HelyesValasz = helyesValasz;
            FelhValasz = felhValasz;
        }
        public string KerdesSzovege { get; set; }
        public string ValaszA { get; set; }
        public string ValaszB { get; set; }
        public string ValaszC { get; set; }
        public string HelyesValasz { get; set; }
        public string? FelhValasz { get; set; }
    }
}
