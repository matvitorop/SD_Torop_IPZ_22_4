using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class FlyweightFactory
    {
        private Dictionary<string, TagsRemember> _flyweights = new Dictionary<string, TagsRemember>();

        public TagsRemember GetFlyweight(string key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                // Create a new TagsRemember object with default values
                _flyweights[key] = new TagsRemember { tagName = key, displayType = "inline", closingType = "closing", cssClasses = new List<string>() };
            }
            return _flyweights[key];
        }
    }
}
