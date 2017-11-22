﻿using System.ComponentModel;
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
