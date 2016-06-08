using System.Collections.Generic;

namespace DesignPatterns.Flyweight
{
    public class FontFactory : IFontFactory
    {
        public static FontFactory GetInstance()
        {
            return NestedClass.Instance;
        }

        public Font GetFont(string name, int size, string color)
        {
            string fontKey = this.GetFontKey(name, size, color);

            if (!this.fonts.ContainsKey(fontKey))
            {
                this.fonts.Add(fontKey, new Font()
                {
                    Name = name,
                    Size = size,
                    Color = color
                });
            }

            return this.fonts[fontKey];
        }

        private string GetFontKey(string name, int size, string color)
        {
            return string.Format("{0}_{1}_{2}", name, size, color);
        }

        private FontFactory()
        {
        }

        private Dictionary<string, Font> fonts = new Dictionary<string, Font>();

        private class NestedClass
        {
            public static readonly FontFactory Instance = new FontFactory();
        }
    }
}
