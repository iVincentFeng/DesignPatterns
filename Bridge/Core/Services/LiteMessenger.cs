using DesignPatterns.Bridge.Core.Interfaces;

namespace DesignPatterns.Bridge.Core.Services
{
    public class LiteMessenger : IMessenger
    {
        public LiteMessenger(IMessengerInfrastructure infrastructure)
            : base(infrastructure)
        {
        }

        public override void Login(string userName, string password)
        {
            this.infrastructure.Connect();
        }

        public override void SendMessage(string message)
        {
            this.infrastructure.WriteText(message);
        }

        public override void SendImage(byte[] image)
        {
            this.infrastructure.DrawImage(image);
        }
    }
}
