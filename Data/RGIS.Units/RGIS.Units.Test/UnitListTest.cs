using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RGIS.Units.Test
{
    [TestClass]
    public class UnitListTest
    {
        [TestMethod]
        public void UnitList()
        {
            List<string> soll = new() { "Centimeter", "Decimeter", "Foot", "Inch", "Kilometer", "Meter", "Mile", "Milimeter", "NauticalMile", "Parsec", "Yard" };
            List<string> result = UnitListings.GetDistanceTypes();

            for (int i = 0; i < result.Count; i++)
            {
                Assert.AreEqual(soll[i], result[i]);
            }
        }

        [TestMethod]
        public void UnitsStringList()
        {
            string soll = "Centimeter\nDecimeter\nFoot\nInch\nKilometer\nMeter\nMile\nMilimeter\nNauticalMile\nParsec\nYard\n";
            string result = UnitListings.GetDistanceTypesString();


            Assert.AreEqual(soll, result);

        }

        [TestMethod]
        public void EnumeratedUnitsStringList()
        {
            string soll = "1. Centimeter\n2. Decimeter\n3. Foot\n4. Inch\n5. Kilometer\n6. Meter\n7. Mile\n8. Milimeter\n9. NauticalMile\n10. Parsec\n11. Yard\n";
            string result = UnitListings.GetDistanceTypesString(true);


            Assert.AreEqual(soll, result);

        }
    }
}
