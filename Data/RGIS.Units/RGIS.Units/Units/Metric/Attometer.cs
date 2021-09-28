using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Attometer : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 1.0000E+18m; } }
        public Attometer(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Attometer(IDistance value)
        {
            Distance = value.ToAttometer().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Attometer()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToAttometer().Distance;
        }
    }
}