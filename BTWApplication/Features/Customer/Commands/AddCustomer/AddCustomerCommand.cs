using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWApplication.Features.Customer.Commands.AddCustomer
{
    public class AddCustomerCommand : IRequest<int>
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Identificacion { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }
    }
}
