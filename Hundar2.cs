using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Djurhundar_saker
{

    internal class Hundar2 : Djur
    {

        public Hundar2()
        {


        public string namn = "Bosse";
        public string färg = "Brun";
        public int ålder = 3;
        public int pris = 1500;
        }

    public override string ToString()
    {
        return $"Namn: {namn}, Färg: {färg}, Ålder: {ålder}, Pris: {pris} kr";

    }


}
