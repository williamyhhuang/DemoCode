using System;
using Xunit;

namespace DemoCode.UnitTest.SystemTime
{
    public class TimeLoggerUsingSystemTimeTest
    {
        public TimeLoggerUsingSystemTimeTest()
        {
        }

        [Fact]
        public void 印出現在時間_使用SystemTime()
        {
            //// Arrange
            SystemTime systemTime = new SystemTime();
            DateTime customDateTime = new DateTime(2021, 6, 6, 13, 13, 13);
            systemTime.Set(customDateTime);

            TimeLoggerUsingSystemTime timeLogger = new TimeLoggerUsingSystemTime(systemTime);

            //// Act
            var actual = timeLogger.CreateMessage_SystemTime();
            var expected = "Time Now is 2021/6/6 13:13:13";

            //// Assert
            Assert.Equal(actual, expected);
        }
    }
}
