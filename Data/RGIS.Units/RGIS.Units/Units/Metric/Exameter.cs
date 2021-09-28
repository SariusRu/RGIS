using RGIS.Units.Helper;

namespace RGIS.Units
{
    public class Exameter : BaseDistance, IDistance
    {
        internal static decimal FromMeter { get { return 1.0000E-18m; } }
        public Exameter(decimal distance)
        {
            Distance = distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Exameter(IDistance value)
        {
            Distance = value.ToExameter().Distance;
            toMeterConversion = 1 / FromMeter;
        }

        public Exameter()
        {
            Distance = 0;
            toMeterConversion = 1 / FromMeter;
        }

        public void Set(IDistance value)
        {
            Distance = value.ToExameter().Distance;
        }
    }
}