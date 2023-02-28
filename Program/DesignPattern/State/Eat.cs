using System;
namespace DemoCode.DesignPattern.State
{
    /// <summary>
    /// 吃飯
    /// </summary>
    public class Eat : State
    {
        /// <summary>
        /// 當前狀態名稱
        /// </summary>
        /// <returns>當前狀態名稱</returns>
        public override string StateName()
        {
            return "Eat";
        }

        /// <summary>
        /// 開始動作
        /// </summary>
        /// <param name="softwareEngineer"></param>
        public override void Action(SoftwareEngineer softwareEngineer)
        {
            Console.WriteLine("該吃飯了");

            // 更改狀態
            Console.WriteLine("吃完飯該寫程式了");
            var nextState = softwareEngineer.GetState(StateEnum.Coding);
            softwareEngineer.SetState(nextState);
        }
    }
}
