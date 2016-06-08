namespace DesignPatterns.Flyweight
{
    public interface IFontFactory
    {
        Font GetFont(string name, int size, string color);
    }
}
