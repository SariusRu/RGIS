using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Hectometer : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 0.01m; } }
        public Hectometer(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Hectometer(IDistance value)
        {
            Distance = value.ToHectometer().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Hectometer()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToHectometer().Distance;
        }
    }
}