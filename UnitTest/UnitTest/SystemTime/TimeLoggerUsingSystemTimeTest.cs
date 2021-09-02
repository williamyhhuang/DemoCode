using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Test.UnitTest.SystemTime
{
    [TestClass]
    public class TimeLoggerUsingSystemTimeTest
    {
        public TimeLoggerUsingSystemTimeTest()
        {
        }

        [TestMethod]
        public void 印出現在時間_使用SystemTime()
        {
            //// Arrange
            SystemTime systemTime = new SystemTime();
            DateTime customDateTime = new DateTime(2021, 6, 6, 13, 13, 13);
            systemTime.Set(customDateTime);

            TimeLoggerUsingSystemTime timeLogger = new TimeLoggerUsingSystemTime(systemTime);

            //// Act
            var actual = timeLogger.CreateMessage_SystemTime();
            var expected = "Time now is 2021/06/06 13:13:13";

            //// Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
