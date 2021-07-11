using System;
namespace DemoCode.DesignPattern.Observer
{
    public class Reader : IObserver
    {
        /// <summary>
        /// 訂閱者
        /// </summary>
        private string _readerName;

        /// <summary>
        /// 訂閱類型
        /// </summary>
        private CategoryEnum _registeredCategory;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="readerName">訂閱者</param>
        /// <param name="category">訂閱類型</param>
        public Reader(string readerName, CategoryEnum category)
        {
            this._readerName = readerName;
            this._registeredCategory = category;

            this.RegisterMessage(readerName, category);
        }

        /// <summary>
        /// 更新訊息
        /// </summary>
        /// <param name="news">新聞</param>
        public void Update(CategoryEnum category)
        {
            if(category == this._registeredCategory)
            {
                Console.WriteLine($"{this._readerName} 訂閱的新聞類型:{this._registeredCategory}有新的新聞");
            }
        }

        /// <summary>
        /// 訂閱訊息
        /// </summary>
        /// <param name="readerName">訂閱者</param>
        /// <param name="category">訂閱類型</param>
        private void RegisterMessage(string readerName, CategoryEnum category)
        {
            Console.WriteLine($"{readerName} 訂閱了新聞類型：{category}");
        }
    }
}
