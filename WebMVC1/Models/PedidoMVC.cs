using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebMVC1.Models
{
    public class PedidoMVC
    {
        [Key]
        public int idPedido { get; set; }
        [MinLength(3)]
        [MaxLength(50)]
        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Este campo é Obrigatório")]
        public string NomeMedicamento { get; set; }
        [Display(Name = "Quantidade")]
        [Required(ErrorMessage = "Este campo é Obrigatório")]
        public string QtdeMedicamento { get; set; }
        [Required(ErrorMessage = "Este campo é Obrigatório")]
        [Display(Name = "Codigo do cliente")]
        [RegularExpression("^[0-9]*$")]
        [StringLength(1, MinimumLength = 5)]
        public string CodCliente { get; set; }
        [Required(ErrorMessage = "Este campo é Obrigatório")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de entrega")]
        public string DataEntrega { get; set; }
    }
}