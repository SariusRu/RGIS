using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Kilometer : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 0.001m; } }
        public Kilometer(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Kilometer(IDistance value)
        {
            Distance = value.ToKilometer().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Kilometer()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToKilometer().Distance;
        }
    }
}