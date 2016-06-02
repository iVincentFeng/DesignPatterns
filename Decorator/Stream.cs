namespace DesignPatterns.Decorator
{
    public abstract class Stream
    {
        public abstract byte[] Read(int number);

        public abstract void Seek(int position);

        public abstract void Write(byte[] data);
    }
}
