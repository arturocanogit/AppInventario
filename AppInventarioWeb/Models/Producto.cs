using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppInventarioWeb.Models
{
    [Table("Productos")]
    public class Producto
    {
        [Key, Column(Order = 0)]
        public int NegocioId { get; set; }
        [Key, Column(Order = 1)]
        public int ProveedorId { get; set; }
        [Key, Column(Order = 2)]
        public int ProductoId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public double Costo { get; set; }
        [Required]
        public double Precio { get; set; }
        [Required]
        public int UnidadId { get; set; }
        [Required]
        public string UnidadLetra { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public virtual Unidad Unidad { get; set; }
    }
}