using System;

namespace OhmsLawCalculator.OhmsLawEngine
{
    public class Ampere
    {
        private double _amperage;
        private Resistance _resistance;
        public Ampere(double amperage)
        {
            _amperage = amperage;
        }

        public Ampere(double amperage, Resistance resistance) : this(amperage)
        {
            _amperage = amperage;
            _resistance = resistance;
        }

        public double GetAmperage()
        {
            return _amperage;
        }
    }
}
