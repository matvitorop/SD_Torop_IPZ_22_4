using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class LightElementNode : LightNode
    {
        private List<LightNode> children;
        private List<string> cssClasses;
        private string tagName;
        public string displayType;
        public string closingType;

        private NodeState displayState;
        private NodeState closingState;

        public string DisplayType { get => displayType; }
        public string ClosingType { get => closingType; }

        public LightElementNode(string tagName, string displayType, string closingType, List<string> cssClasses)
        {
            this.tagName = tagName;
            this.displayType = displayType;
            this.closingType = closingType;
            this.cssClasses = cssClasses;
            this.children = new List<LightNode>();

            if (displayType == "block")
                displayState = new BlockDisplayState(this);
            else
                displayState = new InlineDisplayState(this);

            if (closingType == "closing")
                closingState = new ClosingState(this);
            else
                closingState = new SelfClosingState(this);
        }
        public void SetDisplayState(string newDisplayType)
        {
            if (newDisplayType != displayType)
            {
                if (newDisplayType == "block")
                {
                    displayType = newDisplayType;
                    displayState = new BlockDisplayState(this);
                }
                else
                {
                    displayType = "inline";
                    displayState = new InlineDisplayState(this);
                }
                    
            }
        }

        public void SetClosingState(string newClosingType)
        {
            if (newClosingType != closingType)
            {
                if (newClosingType == "closing")
                {
                    closingType = newClosingType;
                    closingState = new ClosingState(this);
                }
                else
                {
                    closingType = "self-closing";
                    closingState = new SelfClosingState(this);
                }

            }
        }

        public void addChild(LightNode node)
        {   
            children.Add(node);
        }

        public void addClass(string css)
        {
            cssClasses.Add(css);
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

            displayState.Handle();

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

            closingState.Handle();
            
            return sb.ToString();
        }


    }
}
