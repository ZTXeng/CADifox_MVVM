using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadCommandation.Request
{
    public class WritLineRequest:IRequest<bool>
    {
        public WritLineRequest() { }
    }
}
