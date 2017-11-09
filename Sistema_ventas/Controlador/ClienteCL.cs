using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Modelo;

namespace Controlador
{
    public class ClienteCL
    {
        private ClienteAD accesoDatos;
        public ClienteCL()
        {
            accesoDatos = new ClienteAD();
        }
        public BindingList<Cliente> devolverLista()
        {
            return accesoDatos.devolverLista();
        }
    }
}
