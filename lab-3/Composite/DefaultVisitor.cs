using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class DefaultVisitor : INodeVisitor
    {
        public void Visit(LightElementNode element)
        {
            element.cssClasses.Add("container");
            element.cssClasses.Add("block");
        }

        public void Visit(LightTextNode text)
        {
            Console.WriteLine($"Text of this object - {text._text}");
        }
    }
}
