using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Modelo
{
    class Pedido
    {
        private int _idPedido;
        private Cliente _datoCliente;
        private BindingList<Producto> _lProductos;
        private bool _estado;
        private double _total;
        private DateTime _dateReg;

        public Pedido()
        {
            this._lProductos = new BindingList<Producto>();
        }

        public Pedido(int idPedido, Cliente datoCliente, BindingList<Producto> lProductos, bool estado,
                      double total, DateTime dateReg)
        {
            _idPedido = idPedido;
            _datoCliente = datoCliente;
            //para lista como inicializar, averiguar
            _estado = estado;
            _total = total;
            _dateReg = dateReg;
        }

        public int IdPedido { get => _idPedido; set => _idPedido = value; }
        public Cliente DatoCliente { get => _datoCliente; set => _datoCliente = value; }
        public bool Estado { get => _estado; set => _estado = value; }
        public double Total { get => _total; set => _total = value; }
        public DateTime DateReg { get => _dateReg; set => _dateReg = value; }
        internal BindingList<Producto> LProductos { get => _lProductos; set => _lProductos = value; }
    }
}
