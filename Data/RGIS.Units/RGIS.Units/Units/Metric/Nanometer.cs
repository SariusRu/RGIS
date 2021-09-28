using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Nanometer : BaseDistance, IDistance
    {


        internal static decimal FromMeter { get { return 1.0000E+9m; } }
        public Nanometer(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Nanometer(IDistance value)
        {
            Distance = value.ToNanometer().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Nanometer()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToNanometer().Distance;
        }
    }
}