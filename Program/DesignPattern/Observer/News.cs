namespace DemoCode.DesignPattern.Observer
{
    /// <summary>
    /// 新聞
    /// </summary>
    public class News
    {
        /// <summary>
        /// 分類
        /// </summary>
        public CategoryEnum Category { get; set; }

        /// <summary>
        /// 作者
        /// </summary>
        public string Author { get; set; }

        /// <summary>
        /// 標題
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 內容
        /// </summary>
        public string Content { get; set; }
    }
}
