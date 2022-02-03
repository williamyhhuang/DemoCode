namespace DemoCode.DesignPattern.Visitor.AcyclicVisitor
{
    /// <summary>
    /// IBusVisitor
    /// </summary>
    public interface IBusVisitor : IAcyclicVisitor
    {
        /// <summary>
        /// Visit for Bus
        /// </summary>
        /// <param name="bus"></param>
        void Visit(AcyclicBus bus);
    }
}
