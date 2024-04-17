using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento
{
    public class TextDocumentMemento : ITextMemento
    {
        private string _text;

        public DateTime creationDate { get; } = DateTime.Now;
        public TextDocumentMemento(string text)
        {
            _text = text;
        }

        public string GetState()
        {
            return _text;
        }
    }
}
