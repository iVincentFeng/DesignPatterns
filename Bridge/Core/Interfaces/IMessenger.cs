namespace DesignPatterns.Bridge.Core.Interfaces
{
    public abstract class IMessenger
    {
        public IMessenger(IMessengerInfrastructure infrastructure)
        {
            this.infrastructure = infrastructure;
        }

        public abstract void Login(string userName, string password);

        public abstract void SendMessage(string message);

        public abstract void SendImage(byte[] image);

        protected IMessengerInfrastructure infrastructure = null;
    }
}
