using System;

namespace OhmsLawCalculator.OhmsLawEngine
{
    public class Resistance
    {
        private double _resistance;
        public Resistance(double resistance)
        {
            _resistance = resistance;
        }

        public double GetResistance()
        {
            return _resistance;
        }
    }
}
