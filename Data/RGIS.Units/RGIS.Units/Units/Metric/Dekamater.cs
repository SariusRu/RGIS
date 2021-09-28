using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Dekameter : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 0.1m; } }
        public Dekameter(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Dekameter(IDistance value)
        {
            Distance = value.ToDekameter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Dekameter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToDekameter().Distance;
        }
    }
}