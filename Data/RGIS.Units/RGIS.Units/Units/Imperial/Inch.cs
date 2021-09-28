using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Inch : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 39.3700787m; } }
        public Inch(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Inch(IDistance value)
        {
            Distance = value.ToInch().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Inch()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToInch().Distance;
        }
    }
}