using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class ClosingState : NodeState
    {
        public ClosingState(LightElementNode lightElementNode) : base(lightElementNode) { }
        public override void Handle()
        {
            if (context.ClosingType == "closing")
            {
                Console.WriteLine("Setting closing tag...");
            }
            else
            {
                Console.WriteLine("Setting self-closing tag...");
            }
        }
    }
}
