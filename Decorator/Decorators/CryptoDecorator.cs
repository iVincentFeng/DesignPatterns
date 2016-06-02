namespace DesignPatterns.Decorator.Decorators
{
    public class CryptoDecorator : Decorator
    {
        public CryptoDecorator(Stream stream)
            : base(stream)
        {
        }

        public override byte[] Read(int number)
        {
            byte[] bytes = this.stream.Read(number);

            // Do some cryption

            return bytes;
        }

        public override void Seek(int position)
        {
            this.stream.Seek(position);

            // Do some cryption
        }

        public override void Write(byte[] data)
        {
            // Do some cryption

            this.stream.Write(data);
        }
    }
}
