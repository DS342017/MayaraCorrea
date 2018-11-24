using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Pedido
    {
        [Key]
        public int idPedido { get; set; }
        public String NomeMedicamento { get; set; }
        public String QtdeMedicamento { get; set; }
        public String CodCliente { get; set; }
        public String DataEntrega { get; set; }

    }
}