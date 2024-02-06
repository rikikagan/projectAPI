using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subscriber.CORE.response
{
    public class BaseResponse
    {
        public bool Succceed { get; set; }
        public string Message { get; set; }
        public BaseResponse()
        {
            Succceed = false;
        }
    }
}
