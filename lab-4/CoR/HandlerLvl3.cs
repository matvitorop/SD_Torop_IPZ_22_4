using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    public class HandlerLvl3 : BaseHandler
    {
        public override void HandleRequest(Request request)
        {
            if (request.issue.Equals("Slow Internet"))
            {
                Console.WriteLine("Level 3 support: Contact with your Internet provider");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
