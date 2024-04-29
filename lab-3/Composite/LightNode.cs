namespace Composite
{
    public abstract class LightNode : ILifeCycleHooks
    {
        public abstract string OuterHTML();
        public abstract string InnerHTML();

        public virtual bool OnCreated()
        {
            return true;
        }

        public virtual bool OnStylesApplied()
        {
            return true;
        }

        public virtual void ElementSaving()
        {
        }

        public void Template()
        {
            if (OnCreated())
            {
                Console.WriteLine("HTML element is created successfully");
                
                
                if (OnStylesApplied())
                {
                    Console.WriteLine("Some styles was changed successfully");
                }

                ElementSaving();
            }
        }
    }
}
