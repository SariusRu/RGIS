using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Gigameter : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 1.0000E-9m; } }
        public Gigameter(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Gigameter(IDistance value)
        {
            Distance = value.ToGigameter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Gigameter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToGigameter().Distance;
        }
    }
}