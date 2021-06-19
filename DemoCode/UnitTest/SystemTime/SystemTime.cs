using System;
namespace DemoCode.UnitTest.SystemTime
{
    public class SystemTime
    {
        private DateTime _date;

        public SystemTime()
        {
        }

        /// <summary>
        /// 設定時間
        /// </summary>
        /// <param name="custom"></param>
        public void Set(DateTime custom)
        {
            this._date = custom;
        }

        /// <summary>
        /// 重置時間
        /// </summary>
        public void Reset()
        {
            this._date = DateTime.MinValue;
        }

        /// <summary>
        /// 取得現在時間
        /// </summary>
        public DateTime Now
        {
            get
            {
                if(this._date != DateTime.MinValue)
                {
                    return this._date;
                }

                return DateTime.Now;
            }
        }
    }
}
