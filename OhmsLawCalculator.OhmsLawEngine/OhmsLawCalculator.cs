using System;

namespace OhmsLawCalculator.OhmsLawEngine
{
    public static class OhmsLaw
    {
        public static double CalculateVoltage(Ampere amperage, Resistance resistance)
        {
            return resistance.GetResistance() * amperage.GetAmperage();
        }
    }
}
