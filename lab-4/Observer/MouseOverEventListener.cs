using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class MouseOverEventListener : IEventListener
    {
        public void HandleEvent(string eventType)
        {
            if (eventType == "mouseover")
            {
                Console.WriteLine("Mouseover event handled.");
            }
        }
    }
}
