using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Petameter : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 1.0000E-15m; } }
        public Petameter(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Petameter(IDistance value)
        {
            Distance = value.ToPetameter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Petameter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToPetameter().Distance;
        }
    }
}