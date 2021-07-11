namespace DemoCode.DesignPattern.Observer
{
    public interface ISubject
    {
        /// <summary>
        /// 訂閱者註冊
        /// </summary>
        /// <param name="observer">訂閱者</param>
        void RegisterObserver(IObserver observer);


        /// <summary>
        /// 通知訂閱者
        /// </summary>
        /// <param name="category">新聞類型</param>
        void NotifyObservers(CategoryEnum category);

        /// <summary>
        /// 增加新聞
        /// </summary>
        /// <param name="news"></param>
        void AddNews(News news);
    }
}
