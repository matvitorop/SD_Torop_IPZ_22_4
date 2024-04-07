using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Triangle : Shape
    {
        public string Type { get; private set; } = "Triangle";
        public Triangle(IRender render) : base(render)
        { }

        public override void Draw()
        {
            _shapeRender.Render(Type);
        }
    }
}
