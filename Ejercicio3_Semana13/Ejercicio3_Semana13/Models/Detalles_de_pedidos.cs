//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ejercicio3_Semana13.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Detalles_de_pedidos
    {
        public Nullable<int> IdPedido { get; set; }
        public int IdProducto { get; set; }
        public decimal PrecioUnidad { get; set; }
        public short Cantidad { get; set; }
        public float Descuento { get; set; }
    
        public virtual Pedidos Pedidos { get; set; }
    }
}
