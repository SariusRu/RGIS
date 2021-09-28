using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class LightYear : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 1.05772481E-16m; } }
        public LightYear(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public LightYear(IDistance value)
        {
            Distance = value.ToLightYear().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public LightYear()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToLightYear().Distance;
        }
    }
}