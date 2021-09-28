using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Yard : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 1.0936133m; } }
        public Yard(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Yard(IDistance value)
        {
            Distance = value.ToYard().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Yard()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToYard().Distance;
        }
    }
}