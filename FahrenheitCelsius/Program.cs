using System;
using static System.Console;

namespace FahrenheitCelsius
{
    class Program
    {
        static void Main(string[] args)
        {
            FahrenheitTemperature fhrTemp = new FahrenheitTemperature { FahrenheitTemp = 45};
            CelsiusTemperature celsiusTemp = new CelsiusTemperature { CelsiusTemp = 0 };

            CelsiusTemperature fahnToCelsius = new CelsiusTemperature { CelsiusTemp = fhrTemp };
            FahrenheitTemperature celsiusToFahn = new FahrenheitTemperature { FahrenheitTemp = celsiusTemp };

            WriteLine($"FahnToCelsius = {fahnToCelsius.CelsiusTemp}");
            WriteLine($"CelsiusToFahn = {celsiusToFahn.FahrenheitTemp}");
        }
    }
}
