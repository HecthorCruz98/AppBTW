using BTWApplication.Contracts.Persistence;
using BTWApplication.Features.Customer.Commands.AddCustomer;
using BTWApplication.Features.Customer.Commands.DelCustomer;
using BTWApplication.Features.Customer.Commands.UpCustomer;
using BTWApplication.Features.Customer.Queries.ListCustomer;
using BTWApplication.Models.Customer;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ApiBTW.Controllers
{
    [ApiController]
    [Route("/api/v1/[controller]")]
    public class CustomerController : ControllerBase
    {
        IConfiguration _configuration;
        private readonly ILogger<CustomerController> _logger;
        private readonly IMediator _mediator;
        private readonly IUnitOfWork _unitOfWork;
        public CustomerController(ILogger<CustomerController> logger, IConfiguration configuration, IMediator mediator)
        {
            _mediator = mediator;
            _logger = logger;
            _configuration = configuration;
        }
        [HttpGet("GetCustomer")]
        public async Task<ActionResult<IEnumerable<CustomerVm>>> GetBills(int? Id)
        {
            var query = await _mediator.Send(new ListCustomerQuery(Id));
            return Ok(query);
        }

        [HttpPost("CreateCustomer")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> CreateCustomer([FromBody] AddCustomerCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPut("UpdateCustomer")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> UpdateCustomer([FromBody] UpCustomerCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
        [HttpPost("DelCustomer")]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<int>> DeleteCustomer([FromBody] DelCustomerCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
