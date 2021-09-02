using System;
namespace Test.UnitTest.SystemTime
{
    public class TimeLogger
    {
        public TimeLogger()
        {
        }

        /// <summary>
        /// 取得現在時間字串
        /// </summary>
        /// <returns></returns>
        public string CreateMessage()
        {
            DateTime timeNow = this.GetTimeNow();
            string result = $"Time now is {timeNow:yyyy/MM/dd H:mm:ss}";

            return result;
        }

        /// <summary>
        /// 取得現在時間
        /// </summary>
        /// <returns></returns>
        public virtual DateTime GetTimeNow()
        {
            return DateTime.Now;
        }
    }
}
