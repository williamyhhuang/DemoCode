using System;

namespace DemoCode.DesignPattern.Visitor.OriginVisitor
{
    /// <summary>
    /// Visitor
    /// </summary>
    public class Visitor : IVisitor
    {
        /// <summary>
        /// Visit for Motor
        /// </summary>
        /// <param name="motor"></param>
        public void Visit(Motor motor)
        {
            Console.WriteLine($"這是台機車，我只在意馬力:{motor.Power}");
        }

        /// <summary>
        /// Visit for Bus
        /// </summary>
        /// <param name="bus"></param>
        public void Visit(Bus bus)
        {
            var ifHasAirConditioner = bus.HasAirConditioner == true ? "有冷氣" : "沒有冷氣";

            Console.WriteLine($"這是台公車，我只在意限乘人數:{bus.NumberOfPassenger}," +
                              $"以及有沒有冷氣:{ifHasAirConditioner}");
        }
    }
}
