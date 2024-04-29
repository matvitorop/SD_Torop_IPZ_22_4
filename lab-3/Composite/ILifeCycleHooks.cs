using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public interface ILifeCycleHooks
    {
        bool OnCreated();
        bool OnStylesApplied();
        void ElementSaving();
        void Template();
    }
}
