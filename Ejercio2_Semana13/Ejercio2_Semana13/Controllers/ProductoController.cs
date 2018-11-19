using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ejercio2_Semana13.Models;

namespace Ejercio2_Semana13.Controllers
{
    public class ProductoController : Controller
    {
        // GET: Producto
        NeptunoWebEntities db = new NeptunoWebEntities();
       
        public ActionResult ListaPedidoCategoria()
        {
            ViewBag.IdCategoria = new SelectList(db.Categorias, "IdCategoria", "NombreCategoria");
            return View();
        }
        //metodo de vistaparcial
        public PartialViewResult ListadoPedidoIdCategoria(int categoria)
        {
            //obtener los pedidos filtrar por fecha y cliente
            var listado = db.Productos.Where(p => p.IdCategoria == categoria);
            //crear una lista de vwpedidofecha
            List<ViewModel.vwProductoCategoria> coleccion = new List<ViewModel.vwProductoCategoria>();
            //lenar la coleccion de las propiedades de vwpedidofecha

            foreach (Productos producto in listado)
            {
                ViewModel.vwProductoCategoria pro = new ViewModel.vwProductoCategoria();

                pro.idProducto = producto.IdProducto;
                pro.NombreProducto = producto.NombreProducto;
                pro.Categoria = producto.Categorias.NombreCategoria;
                pro.idProveedor = Convert.ToInt32(producto.IdProveedor);
                pro.PrecioUnidad = Convert.ToDecimal(producto.PrecioUnidad);
                coleccion.Add(pro);

            }

            return PartialView("ListaPedidoCategoria_PC",coleccion);
        }

        }
}