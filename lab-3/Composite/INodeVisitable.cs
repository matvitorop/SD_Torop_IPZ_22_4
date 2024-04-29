using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface INodeVisitable
    {
        public void Accept(INodeVisitor visitor);
    }
}
