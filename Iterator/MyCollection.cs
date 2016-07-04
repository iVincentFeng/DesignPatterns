using System.Collections;

namespace DesignPatterns.Iterator
{
    public class MyCollection : IEnumerable
    {
        public IEnumerator GetEnumerator()
        {
            return new MyEnumerator(this);
        }

        private object[] elements = null;

        private class MyEnumerator : IEnumerator
        {
            public MyEnumerator(MyCollection collection)
            {
                this.collection = collection;
            }

            public bool MoveNext()
            {
                if (++this.index < this.collection.elements.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public void Reset()
            {
                this.index = -1;
            }

            public object Current
            {
                get
                {
                    return this.collection.elements[this.index];
                }
            }

            private MyCollection collection = null;
            private int index = -1;
        }
    }
}
