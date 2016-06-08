namespace DesignPatterns.Flyweight
{
    public class Font
    {
        // Avoid explicit object creation in client code.
        internal Font()
        {
        }

        public string Name
        {
            get;
            set;
        }

        public int Size
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }
    }
}
