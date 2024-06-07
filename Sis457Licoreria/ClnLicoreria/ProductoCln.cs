using CadLicoreria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClnLicoreria
{
    public class ProductoCln
    {
        public static int insertar(Producto producto)
        {
            using (var context = new LabLicoreriaEntities())
            {
                context.Producto.Add(producto);
                context.SaveChanges();
                return producto.idProducto;
            }
        }

        public static int actualizar(Producto producto)
        {
            using (var context = new LabLicoreriaEntities())
            {
                var existente = context.Producto.Find(producto.idProducto);
                if (existente != null)
                {
                    existente.codigo = producto.codigo;
                    existente.nombre = producto.nombre;
                    existente.descripcion = producto.descripcion;
                    existente.stock = producto.stock; // Actualización de stock
                    existente.precio = producto.precio;
                    existente.usuarioRegistro = producto.usuarioRegistro;
                    return context.SaveChanges();
                }
                return 0;
            }
        }

        public static int eliminar(int idProducto, string usuarioRegistro)
        {
            using (var context = new LabLicoreriaEntities())
            {
                var existente = context.Producto.Find(idProducto);
                if (existente != null)
                {
                    existente.estado = -1;
                    existente.usuarioRegistro = usuarioRegistro;
                    return context.SaveChanges();
                }
                return 0;
            }
        }

        public static Producto get(int idProducto)
        {
            using (var context = new LabLicoreriaEntities())
            {
                return context.Producto.Find(idProducto);
            }
        }

        public static List<Producto> listar()
        {
            using (var context = new LabLicoreriaEntities())
            {
                return context.Producto.Where(x => x.estado != -1).ToList();
            }
        }

        public static List<paProductosListar_Result> listarPa(string parametro)
        {
            using (var context = new LabLicoreriaEntities())
            {
                return context.paProductosListar(parametro).ToList();
            }
        }
    }
}
