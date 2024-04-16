using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class FileImageLoad : IImageLoading
    {
        public void Load(string href)
        {
            Console.WriteLine($"Loading image {href} from the system");
        }
    }
}
