using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    internal class Jatekosok
{
        string nev;
        DateTime elso;
        DateTime utolso;
        int suly;
        int magassag;

        public string Nev { get => nev; set => nev = value; }
        public DateTime Elso { get => elso; set => elso = value; }
        public DateTime Utolso { get => utolso; set => utolso = value; }
        public int Suly { get => suly; set => suly = value; }
        public int Magassag { get => magassag; set => magassag = value; }

        public Jatekosok(string sor)
        {
            string[] adatok = sor.Trim().Split(';');
            Nev = adatok[0];
            Elso = DateTime.Parse(adatok[1]);
            Utolso = DateTime.Parse(adatok[2]);
            Suly = int.Parse(adatok[3]);
            Magassag = int.Parse(adatok[4]);
        }
    }

}
