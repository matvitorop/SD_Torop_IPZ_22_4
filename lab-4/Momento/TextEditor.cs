using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Memento
{
    public class TextEditor
    {
        private TextDocument _document;

        private List<ITextMemento> snapshots = new List<ITextMemento>();
        
        public TextEditor(TextDocument document)
        {
            _document = document;
        }

        public void Backup()
        {
            snapshots.Add(_document.Save());
        }

        public void Restore()
        {
            var snapshot = snapshots.Last();
            _document.Restore(snapshot);
            snapshots.Remove(snapshot);

        }

        public void PrintDocument()
        {
            _document.Print();
        }

        public void textAppend(string text)
        {
            _document.AppendText(text);
        }
        public void ChangeText(string newText)
        {
            _document.ChangeText("\nWrong version #3");
        }

    }
}
