using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class FlyweightFactory
    {
        private Dictionary<string, string> _flyweights = new Dictionary<string, string>();

        public string GetFlyweight(string key)
        {
            if (!_flyweights.ContainsKey(key))
            {
                _flyweights[key] = key;
            }
            return _flyweights[key];
        }
    }
}
