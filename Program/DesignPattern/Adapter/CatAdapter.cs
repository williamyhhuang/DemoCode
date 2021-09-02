namespace DemoCode.DesignPattern.Adapter
{
    /// <summary>
    /// CatAdapter
    /// </summary>
    public class CatAdapter : IMeow
    {
        /// <summary>
        /// Dog
        /// </summary>
        private Dog _dog;

        /// <summary>
        /// CatAdapter
        /// </summary>
        /// <param name="dog"></param>
        public CatAdapter(Dog dog)
        {
            this._dog = dog;
        }

        /// <summary>
        /// 貓叫
        /// </summary>
        public void Meow()
        {
            this._dog.Bark();
        }
    }
}
