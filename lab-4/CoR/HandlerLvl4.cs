using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    public class HandlerLvl4 : BaseHandler
    {
        public override void HandleRequest(Request request)
        {
            if (request.issue.Equals("Frequent interference"))
            {
                Console.WriteLine("Level 4 support: Try to speak on open place");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
