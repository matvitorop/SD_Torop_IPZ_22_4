namespace Composite
{
    public abstract class LightNode
    {
        public abstract string OuterHTML();
        public abstract string InnerHTML();

        public IIterator CreateIterator()
        {
            return new NodeIterator(this);
        }
    }
}
