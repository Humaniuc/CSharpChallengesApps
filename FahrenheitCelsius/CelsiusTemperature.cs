using System;
using System.Collections.Generic;
using System.Text;

namespace FahrenheitCelsius
{
    class CelsiusTemperature
    {
        public double CelsiusTemp { get; set; }

        public static implicit operator double (CelsiusTemperature cTmp)
        {
            return (cTmp.CelsiusTemp * 9.0/5.0) + 32;
        }
    }
}
