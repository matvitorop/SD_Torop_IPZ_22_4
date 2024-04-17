using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Memento
{
    public class TextDocument
    {
        private string _text;

        public TextDocument(string text) 
        {
            _text = text;
        }

        public void Print()
        {
            Console.WriteLine("\nDocument Content:");
            Console.WriteLine(_text);
        }

        public ITextMemento Save()
        {
            return new TextDocumentMemento(this._text);
        }

        public void Restore(ITextMemento snapshot)
        {
            if(snapshot is TextDocumentMemento)
            {
                var memento = (TextDocumentMemento)snapshot;
                _text = memento.GetState();
            }
            else
            {
                throw new ArgumentException("Wrong type of snapshot");
            }
        }
        public void ChangeText(string newText)
        {
            _text = newText;
        }

        public void AppendText(string textToAdd)
        {
           _text += textToAdd;
        }

    }
}
