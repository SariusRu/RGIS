using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Yoctometer : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 1.0000E+24m; } }
        public Yoctometer(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Yoctometer(IDistance value)
        {
            Distance = value.ToYoctometer().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Yoctometer()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToYoctometer().Distance;
        }
    }
}