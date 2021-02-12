namespace DemoCode.DesignPattern.Strategy
{
    /// <summary>
    /// 烹飪步驟
    /// </summary>
    public interface ICooking
    {
        /// <summary>
        /// 料理名稱
        /// </summary>
        string DishName { get; set; }

        /// <summary>
        /// 準備材料
        /// </summary>
        void Prepare();

        /// <summary>
        /// 烹飪
        /// </summary>
        void Cook();
    }
}
