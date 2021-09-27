using Microsoft.VisualStudio.TestTools.UnitTesting;
using RGIS.Logging;

namespace RGIS.Logging.Test;
[TestClass]
public class LoggerTest
{
    [TestMethod]
    public void LogDefault()
    {
        Logger.Log("TEST", "Test", "Test");
        Logger.Debug("TEST", "Test", "Test");
        Logger.Warn("TEST", "Test", "Test");
        Logger.Error("TEST", "Test", "Test");
    }
}