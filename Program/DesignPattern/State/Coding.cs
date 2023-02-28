using System;
namespace DemoCode.DesignPattern.State
{
    /// <summary>
    /// 寫程式
    /// </summary>
    public class Coding : State
    {
        /// <summary>
        /// 當前狀態名稱
        /// </summary>
        /// <returns>當前狀態名稱</returns>
        public override string StateName()
        {
            return "Coding";
        }

        /// <summary>
        /// 開始動作
        /// </summary>
        /// <param name="softwareEngineer"></param>
        public override void Action(SoftwareEngineer softwareEngineer)
        {
            Console.WriteLine("該寫程式了");

            // 更改狀態
            Console.WriteLine("寫完程式該睡覺了");
            var nextState = softwareEngineer.GetState(StateEnum.Sleep);
            softwareEngineer.SetState(nextState);
        }
    }
}
