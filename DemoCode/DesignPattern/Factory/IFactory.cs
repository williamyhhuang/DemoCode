namespace DemoCode.DesignPattern.Factory
{
    public interface IFactory
    {
        IToy Make(string toyName);
    }
}
