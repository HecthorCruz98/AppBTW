using BTWApplication.Models.Customer;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWApplication.Features.Customer.Queries.ListCustomer
{
    public class ListCustomerQuery : IRequest<List<CustomerVm>>
    {
        public ListCustomerQuery(int? Id)
        {
            id = Id;
        }
        public int? id { get; set; }
    }
}
