using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RGIS.Units.Test
{
    [TestClass]
    public class ParsecTest
    {
        [TestMethod]
        public void ParsecToMeter()
        {
            Parsec parsec = new(1);
            Meter result = parsec.ToMeter();
            Assert.AreEqual(30856578622562330, result.Get());
        }
    }
}
