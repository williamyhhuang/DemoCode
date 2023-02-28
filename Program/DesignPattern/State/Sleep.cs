using System;
namespace DemoCode.DesignPattern.State
{
    /// <summary>
    /// 睡覺
    /// </summary>
    public class Sleep : State
    {
        /// <summary>
        /// 當前狀態名稱
        /// </summary>
        /// <returns>當前狀態名稱</returns>
        public override string StateName()
        {
            return "Sleep";
        }

        /// <summary>
        /// 開始動作
        /// </summary>
        /// <param name="softwareEngineer"></param>
        public override void Action(SoftwareEngineer softwareEngineer)
        {
            Console.WriteLine("該睡覺了");

            // 更改狀態
            Console.WriteLine("睡完覺該吃飯了");
            var nextState = softwareEngineer.GetState(StateEnum.Eat);
            softwareEngineer.SetState(nextState);
        }
    }
}
