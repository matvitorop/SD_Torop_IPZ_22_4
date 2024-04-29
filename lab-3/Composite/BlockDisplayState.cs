using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class BlockDisplayState : NodeState
    {
        public BlockDisplayState(LightElementNode lightElementNode) : base(lightElementNode) { }  
        public override void Handle()
        {
            if (context.DisplayType == "block")
            {
                Console.WriteLine("Setting block display...");
            }
            else
            {
                Console.WriteLine("Setting inline display...");
            }
        }
    }
}
