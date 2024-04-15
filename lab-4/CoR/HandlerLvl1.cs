using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    public class HandlerLvl1 : BaseHandler
    {
        public override void HandleRequest(Request request)
        {
            if (request.issue.Equals("Cant turn on the device"))
            {
                Console.WriteLine("Level 1 support: Check gadget integrity");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
