using Djurhundar_saker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Djur_saker
{
    internal class Djur
    {
        public string namn = "";
        public string färg = "";
        public int ålder = 0;
        public int pris = 0;
        public string favoritmat = "";
        public bool kastrerad = true;
        public bool vaccinerad = true;
        public string djurtyp = "";
        public virtual string Geinfo()
        {
            return $" Namn: {namn}, Färg: {färg}, Ålder: {ålder}, Pris: {pris}, Favoritmat: {favoritmat}, Kastrerad: {kastrerad}, Vaccinerad: {vaccinerad}";

        }
    }
}

