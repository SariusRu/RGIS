using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace RGIS.Units.Test
{
    [TestClass]
    public class MeterTest
    {
        [TestMethod]
        public void MeterList()
        {
            Meter meter = new(2.50);
            List<double> soll = new() { 250, 25, 8.20209975, 98.42519675, 0.0025, 2.5, 0.001553425, 2500, 0.0013499, 8.102000000000001E-17, 2.7340332499999995 };
            List<IDistance> list = UnitListings.GetDistanceList(meter);

            for (int i = 0; i < list.Count; i++)
            {
                Assert.AreEqual(soll[i], list[i].Get());
            }
        }


        [TestMethod]
        public void MeterToCentimer()
        {
            Meter meter = new(2.50);
            Centimeter result = meter.ToCentimeter();
            Assert.AreEqual(250, result.Get());
        }

        [TestMethod]
        public void MeterToCentimer2()
        {
            Meter meter = new(2.50);
            Centimeter result = new();
            result.Set(meter);
            Assert.AreEqual(250, result.Get());
        }

        [TestMethod]
        public void MeterToDecimeter()
        {
            Meter meter = new(2.50);
            Decimeter result = meter.ToDecimeter();
            Assert.AreEqual(25, result.Get());
        }

        [TestMethod]
        public void MeterToDecimeter2()
        {
            Meter meter = new(2.50);
            Decimeter result = new(meter);
            Assert.AreEqual(25, result.Get());
        }

        [TestMethod]
        public void MeterToMilimeter()
        {
            Meter meter = new(2.50);
            Milimeter result = meter.ToMilimeter();
            Assert.AreEqual(2500, result.Get());
        }

        [TestMethod]
        public void MeterToMilimeter2()
        {
            Meter meter = new(2.50);
            Milimeter result = new();
            result.Set(meter);
            Assert.AreEqual(2500, result.Get());
        }
    }
}
