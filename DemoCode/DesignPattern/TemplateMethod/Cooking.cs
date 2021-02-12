using System;

namespace DemoCode.DesignPattern.TemplateMethod
{
    /// <summary>
    /// 烹飪
    /// </summary>
    public abstract class Cooking
    {
        /// <summary>
        /// 料理名稱
        /// </summary>
        public string _dishName;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="dishName"></param>
        public Cooking(string dishName)
        {
            this._dishName = dishName;
        }

        /// <summary>
        /// 準備材料
        /// </summary>
        public abstract void Prepare();

        /// <summary>
        /// 烹飪
        /// </summary>
        public abstract void Cook();

        /// <summary>
        /// 裝盤
        /// </summary>
        public void SetDish()
        {
            Console.WriteLine($"{this._dishName}好了，可以上菜囉");
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
