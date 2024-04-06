using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class FileWriterAdapter : Logger
    {
        private FileWriter _writer;

        public FileWriterAdapter(FileWriter writer)
        {
            _writer = writer;
        }

        public override void Log(string message)
        {
            _writer.WriteLine(message);

            base.Log(message);
        }

        public override void Error(string message)
        {
            _writer.WriteLine("[ERROR] " + message);

            base.Error(message);
        }

        public override void Warn(string message)
        {
            _writer.WriteLine("[WARNING] " + message);

            base.Warn(message);
        }
    }
}
