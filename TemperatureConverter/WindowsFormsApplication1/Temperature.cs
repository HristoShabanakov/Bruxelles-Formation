using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Temperature
    {
        private double temperature; //represente des degres celcius

        //propriété
        public double Kelvin
        {
            get { return temperature + 273.5; }
            set { temperature = value - 273.5; }
        }
        public double Celcius
        {
            get { return temperature; }
            set { temperature = value; }
        }
        public double Fahrenheit
        {
            get { return temperature * 1.8 + 32; }
            set { temperature = (value - 32) / 1.8; }
        }

    }
}
