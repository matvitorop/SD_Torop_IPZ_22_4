using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class SmartTextChecker : ITextReader
    {
        private ITextReader _textReader;

        public SmartTextChecker(ITextReader textReader)
        {
            _textReader = textReader;
        }

        public string[,] ReadText(string filePath)
        {
            Console.WriteLine("Opening file: " + filePath);
            
            string[,] textArray = _textReader.ReadText(filePath);
            
            Console.WriteLine("Successfully read file: " + filePath);
            Console.WriteLine("Total lines: " + textArray.GetLength(0));
            
            int totalCharacters = 0;

            for (int i = 0; i < textArray.GetLength(0); i++)
            {
                for (int j = 0; j < textArray.GetLength(1); j++)
                {
                    totalCharacters += textArray[i, j].Length;
                }
                Console.WriteLine();
            }


            Console.WriteLine("Total characters: " + totalCharacters);
            Console.WriteLine("Closing file: " + filePath);
            
            return textArray;
        }
    }
}
