using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FileWriter
    {
        public void Write(string message)
        {
            Console.Write($"Writing in one line - {message}");
        }

        public void WriteLine(string message)
        {
            Console.WriteLine($"Writing in next line - {message}");
        }

    }
}
