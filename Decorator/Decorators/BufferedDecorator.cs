namespace DesignPatterns.Decorator.Decorators
{
    public class BufferedDecorator : Decorator
    {
        public BufferedDecorator(Stream stream)
            : base(stream)
        {
        }

        public override byte[] Read(int number)
        {
            byte[] bytes = this.stream.Read(number);

            // Do some buffer

            return bytes;
        }

        public override void Seek(int position)
        {
            this.stream.Seek(position);

            // Do some buffer
        }

        public override void Write(byte[] data)
        {
            // Do some buffer

            this.stream.Write(data);
        }
    }
}
