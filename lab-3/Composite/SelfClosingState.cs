using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class SelfClosingState : NodeState
    {
        public SelfClosingState(LightElementNode lightElementNode) : base(lightElementNode) { }
        public override void Handle()
        {
            if (context.ClosingType == "self-closing")
            {
                Console.WriteLine("Setting self-closing tag...");
            }
            else
            {
                Console.WriteLine("Setting closing tag...");
            }
        }
    }
}
