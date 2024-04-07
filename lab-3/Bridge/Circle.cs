using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Circle : Shape
    {
        public string Type { get; private set; } = "Circle";
        public Circle(IRender render) : base(render) 
        { }

        public override void Draw()
        {
            _shapeRender.Render(Type);
        }
    }
}
