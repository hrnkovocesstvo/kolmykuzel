using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kolmykuzel
{
    internal class kolmykuzel
    {
        private double polomer1;
        private double polomer2;
        private double vyslka;
        private string jednokaa;

        public kolmykuzel(double pol1, double pol2, double vysk, string jednoka)
        {
            jednokaa = jednoka;
            polomer1 = pol1;
            polomer2 = pol2;
            vyslka = vysk;
        }

        public double obem()
        {
            return Math.PI * vyslka / 3.0 * (Math.Pow(polomer1, 2) + polomer2 * polomer2 + polomer1 * polomer2);
        }

        public string getjednotka()
        {
            return jednokaa;
        }
    }
}
