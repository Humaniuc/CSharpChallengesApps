using System;
using System.Collections.Generic;
using System.Text;

namespace FahrenheitCelsius
{
    class FahrenheitTemperature
    {
        public double FahrenheitTemp { get; set; }

        public static implicit operator double (FahrenheitTemperature fhTmp)
        {
            return (fhTmp.FahrenheitTemp - 32) * 5.0 / 9.0;
        }
    }
}
