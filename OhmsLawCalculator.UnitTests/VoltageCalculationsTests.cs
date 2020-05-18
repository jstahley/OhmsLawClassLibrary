using Xunit;
using OhmsLawCalculator.OhmsLawEngine;

namespace OhmsLawCalculator.UnitTests
{

    public class VoltageCalculationsTests
    {
        [Fact]
        public void AmperageMultipliedByResistance()
        {    
            Resistance resistance = new Resistance(1000);
            Ampere amperage = new Ampere(120, resistance);
            double answer = OhmsLaw.CalculateVoltage(amperage, resistance); 

            Assert.Equal(120000, answer);
        }
    }
}
     