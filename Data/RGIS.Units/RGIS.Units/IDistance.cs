namespace RGIS.Units.Helper
{
    public interface IDistance
    {
        public void Set(IDistance value);
        public void Set(decimal value);
        public decimal Get();
        public Meter ToMeter();
        public Decimeter ToDecimeter();
        public Centimeter ToCentimeter();
        public Milimeter ToMilimeter();
        public Kilometer ToKilometer();
        public Mile ToMiles();
        public NauticalMile ToNauticMiles();
        public Yard ToYard();
        public Foot ToFoot();
        public Inch ToInch();
        public Parsec ToParsec();
        public LightYear ToLightYear();
        public Dekameter ToDekameter();
        public Hectometer ToHectometer();
        public Mikrometer ToMikrometer();
        public Nanometer ToNanometer();
        public AstronomicalUnit ToAstronomicalUnit();
        public Picometer ToPicometer();
        public Femtometer ToFemtometer();
        public Attometer ToAttometer();
        public Zeptometer ToZeptometer();
        public Yoctometer ToYoctometer();
        public Megameter ToMegameter();
        public Gigameter ToGigameter();
        public Terameter ToTerameter();
        public Petameter ToPetameter();
        public Exameter ToExameter();
        public Zettameter ToZettameter();
        public Yottameter ToYottameter();
    }
}
