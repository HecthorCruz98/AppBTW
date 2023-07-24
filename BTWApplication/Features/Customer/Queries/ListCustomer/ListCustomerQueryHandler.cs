using AutoMapper;
using BTWApplication.Contracts.Persistence;
using BTWApplication.Models.Customer;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWApplication.Features.Customer.Queries.ListCustomer
{
    public class ListCustomerQueryHandler : IRequestHandler<ListCustomerQuery, List<CustomerVm>>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ListCustomerQueryHandler> _logger;
        private readonly IMapper _mapper;

        public ListCustomerQueryHandler(
            IUnitOfWork unitOfWork,
            ILogger<ListCustomerQueryHandler> logger,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }
        public async Task<List<CustomerVm>> Handle(ListCustomerQuery request, CancellationToken cancellationToken)
        {
            if (request.id != null)
            {
                var Entity = await _unitOfWork.Repository<BTWDomain.Customer>().GetAsync(x => x.Id == request.id);
                var EntityVm = _mapper.Map<List<CustomerVm>>(Entity);

                return EntityVm;

            }
            else
            {
                var Entity = await _unitOfWork.Repository<BTWDomain.Customer>().GetAllAsync();
                var EntityVm = _mapper.Map<List<CustomerVm>>(Entity);

                return EntityVm;

            }
        }
    }
}
