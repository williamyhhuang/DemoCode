﻿namespace DemoCode.DesignPattern.Visitor.OriginVisitor
{
    /// <summary>
    /// 巴士
    /// </summary>
    public class Bus : ITransportation
    {
        /// <summary>
        /// 馬力
        /// </summary>
        public decimal Power { get; set; }

        /// <summary>
        /// 限乘人數
        /// </summary>
        public int NumberOfPassenger { get; set; }
        
        /// <summary>
        /// 是否有冷氣
        /// </summary>
        public bool HasAirConditioner { get; set; }

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="power"></param>
        /// <param name="numberOfPassenger"></param>
        /// <param name="hasAirConditioner"></param>
        public Bus(decimal power, int numberOfPassenger, bool hasAirConditioner)
        {
            this.Power = power;
            this.NumberOfPassenger = numberOfPassenger;
            this.HasAirConditioner = hasAirConditioner;
        }

        /// <summary>
        /// Accept
        /// </summary>
        /// <param name="visitor"></param>
        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
