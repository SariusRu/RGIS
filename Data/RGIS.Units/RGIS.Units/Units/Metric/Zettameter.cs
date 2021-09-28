using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Zettameter : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 1.0000E-21m; } }
        public Zettameter(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Zettameter(IDistance value)
        {
            Distance = value.ToZettameter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Zettameter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToZettameter().Distance;
        }
    }
}