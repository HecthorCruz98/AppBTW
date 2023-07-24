using BTWApplication.Models.Customer;
using BTWDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BTWApplication.Features.Customer.Commands.AddCustomer;
using BTWApplication.Features.Customer.Commands.UpCustomer;
using BTWApplication.Features.Customer.Commands.DelCustomer;

namespace BTWApplication.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<AddCustomerCommand, Customer>();
            CreateMap<UpCustomerCommand, Customer>();
            CreateMap<DelCustomerCommand, Customer>();
            CreateMap<Customer, CustomerVm>();
        }
    }
}
