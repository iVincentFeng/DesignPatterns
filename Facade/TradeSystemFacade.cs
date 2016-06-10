using DesignPatterns.Facade.InternalComponents;

namespace DesignPatterns.Facade
{
    public class TradeSystemFacade :ITradeSystem
    {
        private SecurityManager securityManager = null;
        private OrderManager orderManager = null;
        private BillingManager billingManager = null;
        private LogisticsManager logisticsManager = null;

        public void ProcessOrder()
        {
            this.securityManager.Authenticate();
            this.securityManager.Authorize();
            this.orderManager.ProcessOrder();
        }

        public void ProcessBilling()
        {
            this.securityManager.Authenticate();
            this.securityManager.Authorize();
            this.billingManager.ProcessBilling();
        }

        public void ProcessLogistics()
        {
            this.securityManager.Authenticate();
            this.securityManager.Authorize();
            this.logisticsManager.ProcessLogistics();
        }
    }
}
