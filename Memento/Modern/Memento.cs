using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace DesignPatterns.Memento.Modern
{
    public class Memento<T>
    {
        public void SaveState(T obj)
        {
            this.ms = new MemoryStream();
            this.bf.Serialize(ms, obj);
        }

        public T RestoreState()
        {
            this.ms.Seek(0, SeekOrigin.Begin);
            T obj = (T)this.bf.Deserialize(ms);
            this.ms.Close();
            return obj;
        }

        private BinaryFormatter bf = new BinaryFormatter();
        private MemoryStream ms = null;
    }
}
