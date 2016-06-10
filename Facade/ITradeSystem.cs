namespace DesignPatterns.Facade
{
    public interface ITradeSystem
    {
        void ProcessOrder();

        void ProcessBilling();

        void ProcessLogistics();
    }
}
