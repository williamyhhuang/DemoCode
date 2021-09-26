namespace DemoCode.DesignPattern.Visitor
{
    /// <summary>
    /// IVisitor
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// Visit for Motor
        /// </summary>
        /// <param name="motor"></param>
        void Visit(Motor motor);

        /// <summary>
        /// Visit for Bus
        /// </summary>
        /// <param name="bus"></param>
        void Visit(Bus bus);
    }
}
