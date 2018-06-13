using System;
using Apsiyon.App;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Apsiyon.Test
{
    [TestClass]
    public class LogTest
    {
        private ILogger logger = null;
        public LogTest(ILogger _logger)
        {
            logger = _logger;
        }

        [TestMethod]
        public void TestMethod()
        {
            logger.Add("Beklenmedik bir hata oluştu.", new { Name = "Test", Date = DateTime.Now });
        }
    }
}
