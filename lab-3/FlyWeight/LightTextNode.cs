﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    public class LightTextNode : LightNode
    {
        private string _text;
        
        public LightTextNode(string text)
        {
            _text = text;
        }

        public override string InnerHTML()
        {
            return _text;
        }

        public override string OuterHTML()
        {
            return _text;
        }
    }
}
