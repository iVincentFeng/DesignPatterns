namespace DesignPatterns.ChainOfResponsibility
{
    public class DiscountResponse
    {
        public bool IsApproved
        {
            get;
            set;
        }

        public string RejectReason
        {
            get;
            set;
        }
    }
}
