using AutoMapper;
using BTWApplication.Contracts.Persistence;
using BTWApplication.Features.Customer.Commands.AddCustomer;
using MediatR;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWApplication.Features.Customer.Commands.UpCustomer
{
    public class UpCustomerCommandHandler : IRequestHandler<UpCustomerCommand, int>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<UpCustomerCommandHandler> _logger;

        public UpCustomerCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, ILogger<UpCustomerCommandHandler> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<int> Handle(UpCustomerCommand request, CancellationToken cancellationToken)
        {
            var verifyData = await _unitOfWork.Repository<BTWDomain.Customer>().GetFirstOrDefaultAsync(x => x.Id == request.Id);

            int resp = 0;

            if (verifyData != null)
            {
                verifyData.Nombre = request.Nombre;
                verifyData.Apellido = request.Apellido;
                verifyData.Correo = request.Correo;
                verifyData.Direccion = request.Direccion;
                verifyData.Telefono = request.Telefono;
                verifyData.Estado = request.Estado;

                await _unitOfWork.Repository<BTWDomain.Customer>().UpdateAsync(verifyData);

                _logger.LogInformation($"El cliente con el id {verifyData.Id} fue actualizado correctamente ");


                return resp = 1;

            }
            else
            {
                return resp = 0;
            }
        }
    }
}
