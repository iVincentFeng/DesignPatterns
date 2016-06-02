namespace DesignPatterns.Decorator.Streams
{
    public class MemoryStream : Stream
    {
        public override byte[] Read(int number)
        {
            byte[] bytes = null;

            // Read from memory

            return bytes;
        }

        public override void Seek(int position)
        {
            // Seek in memory
        }

        public override void Write(byte[] data)
        {
            // Write to memory
        }
    }
}
