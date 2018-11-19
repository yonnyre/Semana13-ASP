using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercicio3_Semana13.Models;

namespace Ejercicio3_Semana13.Controllers
{
    public class PedidoController : Controller
    {
        NeptunoWebEntities db = new NeptunoWebEntities();

        // GET: Pedido
        public ActionResult ListaPedidoAño()
        {
            ViewBag.IdEmpleado = new SelectList(db.Empleados, "IdEmpleado", "Nombre");
            return View();
        }

        public PartialViewResult ListadoPedidoAñoEmpleado(DateTime fecha_inicio ,DateTime fecha_fin, int empleado)
        {
          
            //obtener los pedidos filtrar por fecha y cliente
            var listado = db.Pedidos.Where(p => p.FechaPedido > fecha_inicio && p.FechaPedido <= fecha_fin && p.IdEmpleado == empleado);

     
            //crear una lista de vwpedidofecha
            List<ViewModels.vwPedidoAño> coleccion = new List<ViewModels.vwPedidoAño>();
            //lenar la coleccion de las propiedades de vwpedidofecha
            foreach (Pedidos pedido in listado)
            {
                ViewModels.vwPedidoAño ped = new ViewModels.vwPedidoAño();

                ped.idPedido = pedido.IdPedido;
                ped.FechaPedido = Convert.ToDateTime(pedido.FechaPedido);
                ped.FechaEntrega = Convert.ToDateTime(pedido.FechaEntrega);
                ped.Cargo = Convert.ToDecimal(pedido.Cargo);
                ped.Cliente = pedido.Clientes.NombreCompañia;
                ped.Vendedor = pedido.Empleados.Apellidos;
                coleccion.Add(ped);

            }
            return PartialView("ListaPedidoAño_PV", coleccion);
        }

    }
}