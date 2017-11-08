using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
