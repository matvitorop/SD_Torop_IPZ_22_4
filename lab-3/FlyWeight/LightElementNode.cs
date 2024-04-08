using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class LightElementNode : LightNode
    {
        private List<LightNode> children;
        private TagsRemember _tagsRemember;

        public LightElementNode(TagsRemember tagsRemember, string key, FlyweightFactory flyweight)
        {
            this._tagsRemember = tagsRemember;
            _tagsRemember = flyweight.GetFlyweight(key);

            this.children = new List<LightNode>();
        }

        public void addChild(LightNode node)
        {
            children.Add(node);
        }

        public void addClass(string css)
        {
            _tagsRemember.cssClasses.Add(css);
        }

        public override string InnerHTML()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var child in children)
            {
                sb.Append(child.OuterHTML());
            }
            return sb.ToString();
        }

        public override string OuterHTML()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"\n<{_tagsRemember.tagName} ");

            if (_tagsRemember.cssClasses.Count > 0)
            {
                sb.Append($"class=\"{string.Join(" ", _tagsRemember.cssClasses)}\" ");
            }
            sb.Append(">");
            if (_tagsRemember.displayType == "block")
            {
                sb.AppendLine();
            }
            foreach (var child in children)
            {
                sb.Append(child.OuterHTML());
            }
            if (_tagsRemember.closingType == "closing")
            {
                sb.Append($"</{_tagsRemember.tagName}>");
            }
            else if (_tagsRemember.closingType == "self-closing")
            {
                sb.Append("/>");
            }

            return sb.ToString();
        }
    }
}
