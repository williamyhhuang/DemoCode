using System;
namespace DemoCode.UnitTest.SystemTime
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
            string result = "Time now is " + timeNow.ToString("yyyy/MM/dd hh:MM:ss");

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
