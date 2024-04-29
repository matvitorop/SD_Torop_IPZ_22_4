using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class AddChildCommand : ICommand
    {
        private LightElementNode _element;
        private LightNode _child;

        public AddChildCommand(LightElementNode element, LightNode child)
        {
            _element = element;
            _child = child;
        }

        public void Execute()
        {
            _element.addChild(_child);
        }

        public void Undo()
        {
            _element.removeChild(_child);
        }
    }
}
