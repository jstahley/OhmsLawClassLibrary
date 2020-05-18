namespace OhmsLawCalculator.OhmsLawEngine
{
    internal class voltageCalculator
    {
        private Resistance _resistance;
        private Ampere _amperage;
        public voltageCalculator(Resistance resistance, Ampere amperage)
        {
            _resistance = resistance;
            _amperage = amperage;
        }
    }
}