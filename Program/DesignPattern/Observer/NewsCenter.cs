using System.Collections.Generic;

namespace DemoCode.DesignPattern.Observer
{
    public class NewsCenter : ISubject
    {
        /// <summary>
        /// 訂閱者清單
        /// </summary>
        private List<IObserver> _itsObservers;

        /// <summary>
        /// 新聞清單
        /// </summary>
        public List<News> _newsList;

        public NewsCenter()
        {
            this._itsObservers = new List<IObserver>();
            this._newsList = new List<News>();
        }

        /// <summary>
        /// 通知訂閱者
        /// </summary>
        /// <param name="category">新聞類型</param>
        public void NotifyObservers(CategoryEnum category)
        {
            foreach(var observer in this._itsObservers)
            {
                observer.Update(category);
            }
        }

        /// <summary>
        /// 訂閱者註冊
        /// </summary>
        /// <param name="observer">訂閱者</param>
        public void RegisterObserver(IObserver observer)
        {
            this._itsObservers.Add(observer);
        }

        /// <summary>
        /// 增加新聞
        /// </summary>
        /// <param name="news"></param>
        public void AddNews(News news)
        {
            this._newsList.Add(news);
            this.NotifyObservers(news.Category);
        }
    }
}
