using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class InlineDisplayState : NodeState
    {
        public InlineDisplayState(LightElementNode lightElementNode) : base(lightElementNode) { }
        public override void Handle()
        {
            if (context.DisplayType == "inline")
            {
                Console.WriteLine("Setting inline display...");
            }
            else
            {
                Console.WriteLine("Setting block display...");
            }
        }
    }
}
