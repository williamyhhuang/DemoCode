namespace DemoCode.DesignPattern.State
{
    public abstract class State
    {
        /// <summary>
        /// 狀態名稱
        /// </summary>
        /// <returns></returns>
        public abstract string StateName();

        /// <summary>
        /// 行為
        /// </summary>
        public virtual void Action(SoftwareEngineer softwareEngineer)
        {

        }
    }
}
