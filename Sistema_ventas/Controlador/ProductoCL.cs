using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using Modelo;
using AccesoDatos;

namespace Controlador
{
    public class ProductoCL
    {
        private ProductoAD accesoDatos;
        public ProductoCL()
        {
            accesoDatos = new ProductoAD();
        }
        public BindingList<Producto> devolverlista()
        {
            return accesoDatos.devolverlista();
        }

        public BindingList<Producto> devolverlista(string nombre)
        {
            return accesoDatos.devolverlista(nombre);
        }
    }
}
