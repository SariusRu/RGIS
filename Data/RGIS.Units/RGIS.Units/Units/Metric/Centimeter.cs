using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Centimeter : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 100m; } }

        public Centimeter(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Centimeter(IDistance value)
        {
            Distance = value.ToCentimeter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Centimeter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToCentimeter().Distance;
        }
    }
}