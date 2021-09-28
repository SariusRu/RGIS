using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Meter : BaseDistance, IDistance
    {
        public Meter(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1;
        }

        public Meter(IDistance value)
        {
            Distance = value.ToMeter().Distance;
            toMeterConversion = 1;
        }

        public Meter()
        {
            Distance = 0;
            toMeterConversion = 1;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToMeter().Distance;
        }
    }
}