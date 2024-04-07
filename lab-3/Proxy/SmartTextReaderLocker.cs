using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextReaderLocker : ITextReader
    {
        private ITextReader _textReader;
        private Regex _regex;

        public SmartTextReaderLocker(ITextReader textReader, string pattern)
        {
            _textReader = textReader;
            _regex = new Regex(pattern);
        }

        public string[,] ReadText(string filePath)
        {
            if (_regex.IsMatch(filePath))
            {
                Console.WriteLine("Access denied!");
                return new string[0, 0];
            }
            else
            {
                return _textReader.ReadText(filePath);
            }
        }
    }
}
