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
        public string Nombre { get; set; }
        public double Costo { get; set; }
        public double Precio { get; set; }
        public int UnidadNumero { get; set; }
        public string UnidadLetra { get; set; }
        public virtual Proveedor Proveedor { get; set; }
    }
}