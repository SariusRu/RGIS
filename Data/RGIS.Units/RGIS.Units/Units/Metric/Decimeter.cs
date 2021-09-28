using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Decimeter : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 10m; } }
        public Decimeter(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Decimeter(IDistance value)
        {
            Distance = value.ToDecimeter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Decimeter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToDecimeter().Distance;
        }
    }
}