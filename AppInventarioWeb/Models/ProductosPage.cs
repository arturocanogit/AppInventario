using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppInventarioWeb.Models
{
    public class ProductosPage
    {
        public IEnumerable<Producto> Productos { get; set; }
        public IEnumerable<Proveedor> Proveedores { get; set; }
    }
}