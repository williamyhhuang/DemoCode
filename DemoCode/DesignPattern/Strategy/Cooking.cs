using System;
namespace DemoCode.DesignPattern.Strategy
{
    public class Cooking
    {
        /// <summary>
        /// ICooking
        /// </summary>
        private ICooking _cooking;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="cooking"></param>
        public Cooking(ICooking cooking)
        {
            this._cooking = cooking;
        }

        /// <summary>
        /// 準備材料
        /// </summary>
        public void Prepare()
        {
            this._cooking.Prepare();
        }

        /// <summary>
        /// 烹飪
        /// </summary>
        public void Cook()
        {
            this._cooking.Cook();
        }

        /// <summary>
        /// 裝盤
        /// </summary>
        public void SetDish()
        {
            Console.WriteLine($"{this._cooking.DishName}好了，可以上菜囉");
        }

        /// <summary>
        /// 完成
        /// </summary>
        public void Done()
        {
            Console.WriteLine("完成上菜，來整理廚房");
            this.CleanUp();
        }

        /// <summary>
        /// 整理廚房
        /// </summary>
        private void CleanUp()
        {
            Console.WriteLine("廚房整理好了");
        }
    }
}
