namespace Composite
{
    public abstract class LightNode
    {
        public abstract string OuterHTML();
        public abstract string InnerHTML();

        public abstract IIterator CreateIterator();
    }
}
