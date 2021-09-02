using System;
namespace DemoCode.DesignPattern.Factory
{
    public class Gozilla : IToy
    {
        public string ToyName { get; set; }

        public Gozilla()
        {
            ToyName = "Gozilla";
        }
    }
}
