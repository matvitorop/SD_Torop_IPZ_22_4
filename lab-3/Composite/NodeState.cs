using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public abstract class NodeState
    {
        protected LightElementNode context;

        public NodeState(LightElementNode context)
        {
            this.context = context;
        }
        public void SetContext(LightElementNode context)
        {
            this.context = context;
        }

        public abstract void Handle();
    }
}
