using System;
using Xunit;

namespace DemoCode.UnitTest.SystemTime
{
    public class TimeLoggerTest
    {
        public TimeLoggerTest()
        {
        }

        [Fact]
        public void 印出現在時間_使用StubTimeLogger()
        {
            //// Arrange
            DateTime dateTime = new DateTime(2021, 6, 6, 13, 13, 13);
            StubTimeLogger timeLogger = new StubTimeLogger(dateTime);

            //// Act
            var actual = timeLogger.CreateMessage();
            var expected = "Time Now is 2021/6/6 13:13:13";

            //// Assert
            Assert.Equal(actual, expected);
        }

        /// <summary>
        /// StubTimeLogger
        /// </summary>
        public class StubTimeLogger : TimeLogger
        {
            private DateTime _dateTime;

            public StubTimeLogger(DateTime dateTime)
            {
                this._dateTime = dateTime;
            }

            public override DateTime GetTimeNow()
            {
                return this._dateTime;
            }
        }
    }
}
