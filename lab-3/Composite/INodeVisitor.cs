using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface INodeVisitor
    {
        public void Visit(LightElementNode element);
        public void Visit(LightTextNode text);
    }
}
