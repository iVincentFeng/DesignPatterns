using DesignPatterns.Bridge.Core.Interfaces;

namespace DesignPatterns.Bridge.Infrastructure
{
    public class PcMessengerInfrastructure : IMessengerInfrastructure
    {
        public void PlaySound()
        {
        }

        public void DrawImage(byte[] image)
        {
        }

        public void WriteText(string text)
        {
        }

        public void Connect()
        {
        }
    }
}
