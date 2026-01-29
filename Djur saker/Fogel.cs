using Djur_saker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

internal  class Fogel : Djur
{


    private bool rovfågel = true;

    public override string Geinfo()

    {

        return base.Geinfo() + $" Rovfågel: {rovfågel}";
    }

    


}