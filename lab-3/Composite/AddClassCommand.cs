using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class AddClassCommand : ICommand
    {
        private LightElementNode _element;
        private string _css;

        public AddClassCommand(LightElementNode element, string css)
        {
            _element = element;
            _css = css;
        }

        public void Execute()
        {
            _element.addClass(_css);
        }

        public void Undo()
        {
            _element.removeClass(_css);
        }
    }
}
