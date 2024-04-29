using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class LightElementNode : LightNode
    {
        public List<LightNode> children;
        private List<string> cssClasses;
        private string tagName;
        private string displayType;
        private string closingType;

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses)
        {
            this.tagName = tagName;
            this.displayType = displayType;
            this.closingType = closingType;
            this.cssClasses = cssClasses;
            this.children = new List<LightNode>();
        }

        public void addChild(LightNode node)
        {
            children.Add(node);
        }
        public void removeChild(LightNode node)
        {
            children.Remove(node);
        }

        public void addClass(string css)
        {
            cssClasses.Add(css);
        }

        public void removeClass(string css)
        {
            cssClasses.Remove(css);
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
            sb.Append($"<{tagName} ");

            if (cssClasses.Count > 0)
            {
                sb.Append($"class=\"{string.Join(" ", cssClasses)}\" ");
            }
            sb.Append(">");
            if (displayType == "block")
            {
                sb.AppendLine();
            }
            foreach (var child in children)
            {
                sb.Append(child.OuterHTML());
            }
            if (closingType == "closing")
            {
                sb.Append($"</{tagName}>");
            }
            else if (closingType == "self-closing")
            {
                sb.Append("/>");
            }

            return sb.ToString();
        }

    }
}
