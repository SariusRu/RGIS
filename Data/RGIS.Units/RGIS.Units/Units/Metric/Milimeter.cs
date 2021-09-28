using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Milimeter : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 1000m; } }
        public Milimeter(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Milimeter(IDistance value)
        {
            Distance = value.ToMilimeter().Distance;
            toMeterConversion = 1 /FromMeter;
        }

        public Milimeter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToMilimeter().Distance;
        }
    }
}