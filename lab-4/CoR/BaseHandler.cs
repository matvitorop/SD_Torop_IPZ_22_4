using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoR
{
    public abstract class BaseHandler : IHandler
    {
        protected IHandler? NextHandler;
        
        public void SetNextHandler(IHandler handler)
        {
            NextHandler = handler;
        }

        public virtual void HandleRequest(Request request)
        {
            if (NextHandler != null)
            {
                NextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine("Unknown request");
            }

        }
    }
}
