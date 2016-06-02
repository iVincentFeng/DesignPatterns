namespace DesignPatterns.Decorator.Streams
{
    public class FileStream : Stream
    {
        public override byte[] Read(int number)
        {
            byte[] bytes = null;

            // Read from file

            return bytes;
        }

        public override void Seek(int position)
        {
            // Seek in file
        }

        public override void Write(byte[] data)
        {
            // Write to file
        }
    }
}
