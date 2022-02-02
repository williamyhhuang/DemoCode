namespace DemoCode.DesignPattern.Visitor.OriginVisitor
{
    /// <summary>
    /// 交通工具
    /// </summary>
    public interface ITransportation
    {
        /// <summary>
        /// 馬力
        /// </summary>
        decimal Power { get; set; }

        /// <summary>
        /// 限乘人數
        /// </summary>
        int NumberOfPassenger { get; set; }

        /// <summary>
        /// 是否有冷氣
        /// </summary>
        bool HasAirConditioner { get; set; }

        /// <summary>
        /// Accept
        /// </summary>
        /// <param name="visitor"></param>
        void Accept(IVisitor visitor);
    }
}
