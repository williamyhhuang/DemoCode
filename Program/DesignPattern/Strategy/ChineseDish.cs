using System;
using System.Collections.Generic;

namespace DemoCode.DesignPattern.Strategy
{
    public class ChineseDish : ICooking
    {
        /// <summary>
        /// 料理名稱
        /// </summary>
        public string DishName { get; set; }

        /// <summary>
        /// 食材
        /// </summary>
        private List<string> _ingredients;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="dishName"></param>
        public ChineseDish(string dishName)
        {
            this.DishName = dishName;
        }

        /// <summary>
        /// 準備材料
        /// </summary>
        public void Prepare()
        {
            Console.WriteLine($"今天要來做{this.DishName}");

            switch (this.DishName)
            {
                case "辣炒牛肉空心菜":
                    this._ingredients = new List<string>
                    {
                        "辣椒",
                        "空心菜",
                        "牛肉"
                    };
                    break;
            }

            //// 洗菜
            this.Clean();

            //// 切菜
            this.Cut();

            Console.WriteLine("材料準備好了");
        }

        /// <summary>
        /// 烹飪
        /// </summary>
        public void Cook()
        {
            Console.WriteLine("中式料理當然要用鍋炒，材料有:{0}", string.Join("，", this._ingredients));
            Console.WriteLine("菜煮好了");
        }

        /// <summary>
        /// 洗菜
        /// </summary>
        private void Clean()
        {
            Console.WriteLine("菜洗好了");
        }

        /// <summary>
        /// 切菜
        /// </summary>
        private void Cut()
        {
            Console.WriteLine("菜切好了");
        }

    }
}
