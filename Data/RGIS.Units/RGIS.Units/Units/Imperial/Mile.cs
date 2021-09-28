using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Mile : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 0.00062137m; } }
        public Mile(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Mile(IDistance value)
        {
            Distance = value.ToMiles().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Mile()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToMiles().Distance;
        }
    }
}