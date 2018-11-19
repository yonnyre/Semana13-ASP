using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercio2_Semana13.ViewModel
{
    public class vwProductoCategoria
    {
        //campos a mostrar en la vista parcial
        public int idProducto { get; set; }
        public string NombreProducto { get; set; }
        public string  Categoria { get; set; }
        public int idProveedor { get; set; }
        public decimal PrecioUnidad { get; set; }

    }
}