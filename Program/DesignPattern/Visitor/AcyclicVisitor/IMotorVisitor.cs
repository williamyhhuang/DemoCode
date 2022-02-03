namespace DemoCode.DesignPattern.Visitor.AcyclicVisitor
{
    /// <summary>
    /// IMotorVisitor
    /// </summary>
    public interface IMotorVisitor : IAcyclicVisitor
    {
        /// <summary>
        /// Visit for Motor
        /// </summary>
        /// <param name="motor"></param>
        void Visit(AcyclicMotor motor);
    }
}
