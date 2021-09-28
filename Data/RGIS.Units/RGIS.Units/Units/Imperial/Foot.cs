using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Foot : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 3.2808399m; } }
        public Foot(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Foot(IDistance value)
        {
            Distance = value.ToFoot().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Foot()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToFoot().Distance;
        }
    }
}