using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoQuizDavidJaniak
{
    class Spieler
    {
        public string Name;
        public int Punkte;
        public string Datum;

        public Spieler() { }
        public Spieler(string name, int punkte, string datum)
        {
            Name = name;
            Punkte = punkte;
            Datum = datum;
        }
    }
}
