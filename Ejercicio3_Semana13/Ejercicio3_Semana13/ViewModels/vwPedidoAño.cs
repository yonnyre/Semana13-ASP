using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ejercicio3_Semana13.ViewModels
{
    public class vwPedidoAño
    {
        //campos a mostrar en la vista parcial
        public int idPedido { get; set; }
        public DateTime FechaPedido { get; set; }
        public DateTime FechaEntrega { get; set; }
        public decimal Cargo { get; set; }
        public string Cliente { get; set; }
        public string Vendedor { get; set; }
    }
}