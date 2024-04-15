using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    public class HandlerLvl2 : BaseHandler
    {
        public override void HandleRequest(Request request)
        {
            if (request.issue.Equals("Cant connect to the network"))
            {
                Console.WriteLine("Level 2 support: Check network configuration");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
