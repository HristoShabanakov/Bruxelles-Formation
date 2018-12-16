using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Currency
    {
        private double valeur; //represente la valeur en euros

        public double getEuros()
        {
            return valeur;
        }
        public void setEuros(double eur)
        {
            valeur = eur;
        }
        public double getPounds()
        {
            return valeur/1.3;
        }
        public void setPoubds(double pnd)
        {
            valeur = pnd*1.3;
        }
    }
}
