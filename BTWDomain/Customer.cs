using BTWDomain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTWDomain
{
    public class Customer : Entity
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
