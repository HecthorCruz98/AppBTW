using AutoMapper;
using BTWApplication.Contracts.Persistence;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWApplication.Features.Customer.Commands.AddCustomer
{
    public class AddCustomerCommandHandler : IRequestHandler<AddCustomerCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<AddCustomerCommandHandler> _logger;

        public AddCustomerCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<AddCustomerCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<int> Handle(AddCustomerCommand request, CancellationToken cancellationToken)
        {
            int resp = 0;
            if (request != null)
            {
                var Entity = _mapper.Map<BTWDomain.Customer>(request);
                var EntityAdd = await _unitOfWork.Repository<BTWDomain.Customer>().AddAsync(Entity);
                _logger.LogInformation($"El cliente fue creado con el id {EntityAdd.Id}");

                return resp = 1;
            }
            else
            {
                return resp = 0;
            }
        }
    }
}
