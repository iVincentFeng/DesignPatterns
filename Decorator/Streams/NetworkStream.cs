namespace DesignPatterns.Decorator.Streams
{
    public class NetworkStream : Stream
    {
        public override byte[] Read(int number)
        {
            byte[] bytes = null;

            // Read from network

            return bytes;
        }

        public override void Seek(int position)
        {
            // Seek in network
        }

        public override void Write(byte[] data)
        {
            // Write to network
        }
    }
}
