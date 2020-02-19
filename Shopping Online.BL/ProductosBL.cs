using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Online.BL
{
    public class ProductosBL
    {
       public  List<Producto> ObtenerProductos()
        {
            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Descripcion = "laptop dell";
            producto1.Precio = 5000;
         

            var producto2 = new Producto();
            producto2.Id = 2;
            producto2.Descripcion = "plancha de cabello ";
            producto2.Precio = 2000;
          

            var producto3 = new Producto();
            producto3.Id = 3;
            producto3.Descripcion = "cdi para carro civic";
            producto3.Precio = 5000;
           

            var listadeproductos = new List<Producto>();

            listadeproductos.Add(producto1);
            listadeproductos.Add(producto2);
            listadeproductos.Add(producto3);

            return listadeproductos;
        }
    }
}
