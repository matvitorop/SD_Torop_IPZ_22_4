using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class ClickEventListener : IEventListener
    {
        public void HandleEvent(string eventType)
        {
            if (eventType == "click")
            {
                Console.WriteLine("Click event handled.");
            }
        }
    }
}
