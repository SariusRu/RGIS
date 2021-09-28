using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class NauticalMile : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 0.00053996m; } }
        public NauticalMile(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public NauticalMile(IDistance value)
        {
            Distance = value.ToNauticMiles().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public NauticalMile()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToNauticMiles().Distance;
        }
    }
}