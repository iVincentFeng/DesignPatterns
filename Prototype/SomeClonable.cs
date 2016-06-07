namespace Prototype
{
    public class SomeClonable : IMyClonable
    {
        public int IntProperty
        {
            get;
            set;
        }

        public string StringProperty
        {
            get;
            set;
        }

        public IMyClonable Clone()
        {
            return (IMyClonable)this.MemberwiseClone();
        }
    }
}
