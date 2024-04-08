using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class TagsRemember
    {
        public string tagName {  get; set; }
        public string displayType { get; set; }
        public string closingType { get; set; }
        public List<string> cssClasses { get; set; }
    }
}
