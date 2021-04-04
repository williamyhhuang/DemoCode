using System;

namespace DemoCode.DesignPattern.Factory
{
    public class Factory : IFactory
    {
        public Factory()
        {
        }

        public IToy Make(string toyName)
        {
            switch (toyName)
            {
                case "Gozilla":
                    return new Gozilla();
                    
                case "KingKong":
                    return new KingKong();
                    
                default:
                    throw new ApplicationException($"沒有生產該玩具: {toyName}");
            }
        }
    }
}
