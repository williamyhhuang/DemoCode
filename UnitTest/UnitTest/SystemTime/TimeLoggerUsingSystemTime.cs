using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace Test.UnitTest.SystemTime
{
    public class TimeLoggerUsingSystemTime
    {
        /// <summary>
        /// SystemTime
        /// </summary>
        private SystemTime _systemTime;

        /// <summary>
        /// TimeLogger
        /// </summary>
        /// <param name="systemTime"></param>
        public TimeLoggerUsingSystemTime(SystemTime systemTime)
        {
            this._systemTime = systemTime;
        }

        /// <summary>
        /// 取得現在時間字串，使用 SystemTime
        /// </summary>
        /// <returns></returns>
        public string CreateMessage_SystemTime()
        {
            DateTime timeNow = this._systemTime.Now;
            string result = $"Time now is {timeNow:yyyy/MM/dd H:mm:ss}";

            return result;
        }
    }
}
