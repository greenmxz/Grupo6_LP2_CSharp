using System.ComponentModel;
using AccesoDatos;
using Modelo;

namespace Controlador
{
    public class PedidoCL
    {
        private PedidoAD accesoDatos;
        public PedidoCL()
        {
            accesoDatos = new PedidoAD();
        }
        public BindingList<Pedido> devolverLista()
        {
            return accesoDatos.devolverLista();
        }
    }
}
