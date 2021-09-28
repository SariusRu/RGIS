using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Parsec : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 3.2408E-17m; } }

        public Parsec(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Parsec(IDistance value)
        {
            Distance = value.ToParsec().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Parsec()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToParsec().Distance;
        }
    }
}