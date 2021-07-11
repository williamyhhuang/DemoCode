namespace DemoCode.DesignPattern.Observer
{
    public interface IObserver
    {
        /// <summary>
        /// 更新訊息
        /// </summary>
        /// <param name="category">新聞類型</param>
        void Update(CategoryEnum category);
    }
}
