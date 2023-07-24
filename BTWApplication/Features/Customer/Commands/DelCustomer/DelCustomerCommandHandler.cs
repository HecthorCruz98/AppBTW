using AutoMapper;
using BTWApplication.Contracts.Persistence;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace BTWApplication.Features.Customer.Commands.DelCustomer
{
    public class DelCustomerCommandHandler : IRequestHandler<DelCustomerCommand,int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<DelCustomerCommandHandler> _logger;
        private readonly IMapper _mapper;


        public DelCustomerCommandHandler(
            IUnitOfWork unitOfWork,
            ILogger<DelCustomerCommandHandler> logger,
            IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<int> Handle(DelCustomerCommand request, CancellationToken cancellationToken)
        {
            if (!request.id.Equals(null))
            {
                var Delete = await _unitOfWork.Repository<BTWDomain.Customer>().GetFirstOrDefaultAsync(x => x.Id == request.id);

                if (Delete != null)
                {
                    await _unitOfWork.Repository<BTWDomain.Customer>().DeleteAsync(Delete);

                    return 1;
                }
                else
                {
                    return 0;

                }

            }
            else
            {
                return 0;

            }
        }
    }
}
