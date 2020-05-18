using System;

namespace OhmsLawCalculator.OhmsLawEngine
{
    public class Volt
    {
        private double _voltage;
        private Resistance _resistance;
        public Volt(double voltage)
        {
            _voltage = voltage;
        }

        public Volt(double voltage, Resistance resistance) : this(voltage)
        {
            _resistance = resistance;
        }

        public double GetVoltage()
        {
            return _voltage;
        }
    }
}
