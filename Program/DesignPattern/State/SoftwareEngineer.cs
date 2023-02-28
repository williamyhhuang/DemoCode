using System;
namespace DemoCode.DesignPattern.State
{
    /// <summary>
    /// 工程師
    /// </summary>
    public class SoftwareEngineer
    {
        private State _itsState;
        private Eat _eatState;
        private Sleep _sleepState;
        private Coding _codeingState;

        /// <summary>
        /// 工程師
        /// </summary>
        public SoftwareEngineer()
        {
            this._eatState = new Eat();
            this._sleepState = new Sleep();
            this._codeingState = new Coding();

            // 預設狀態從吃飯開始
            this._itsState = this._eatState;
        }

        /// <summary>
        /// 取得當前狀態
        /// </summary>
        /// <returns></returns>
        public string GetCurrentStateName()
        {
            Console.WriteLine($"現在狀態：{this._itsState.StateName()}");

            return this._itsState.StateName();
        }

        /// <summary>
        /// 取得狀態
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public State GetState(StateEnum state)
        {
            switch (state)
            {
                case StateEnum.Eat:
                    return this._eatState;

                case StateEnum.Sleep:
                    return this._sleepState;

                case StateEnum.Coding:
                    return this._codeingState;

                default:
                    throw new ArgumentException();
            }
        }

        /// <summary>
        /// 設定狀態
        /// </summary>
        /// <param name="state"></param>
        public void SetState(State state)
        {
            this._itsState = state;
        }

        /// <summary>
        /// 行為
        /// </summary>
        public void Action()
        {
            this._itsState.Action(this);
        }
    }
}
