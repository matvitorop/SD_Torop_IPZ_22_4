using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class LightTextNode : LightNode, INodeVisitable
    {
        public string _text;
        
        public LightTextNode(string text)
        {
            _text = text;
        }

        public override string InnerHTML()
        {
            return _text;
        }

        public override string OuterHTML()
        {
            return _text;
        }
        public void Accept(INodeVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
