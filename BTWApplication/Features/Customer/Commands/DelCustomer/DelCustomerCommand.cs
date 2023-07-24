using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWApplication.Features.Customer.Commands.DelCustomer
{
    public class DelCustomerCommand : IRequest<int>
    {
        public int id { get; set; }
    }
}
