using System;
namespace DemoCode.DesignPattern.Factory
{
    public class KingKong : IToy
    {
        public string ToyName { get; set; }

        public KingKong()
        {
            ToyName = "King Kong";
        }
    }
}
