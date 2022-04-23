using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppInventarioWeb.Models
{
    [Table("Unidades")]
    public class Unidad
    {
        [Key, Column(Order = 0)]
        public int NegocioId { get; set; }
        [Key, Column(Order = 1)]
        public int UnidadId { get; set; }
        public string Nombre { get; set; }
        public string Abreviatura { get; set; }
    }
}