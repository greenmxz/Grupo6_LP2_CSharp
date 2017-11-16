using System;
using System.ComponentModel;


namespace Modelo
{
    public class Pedido
    {
        private static int i = 2;
        private int _idPedido;
        private Cliente _datoCliente;
        private BindingList<Producto> _lProductos;
        private string _estado;
        private double _total;
        private DateTime _dateReg;
        public Pedido()
        {
            _datoCliente = new Cliente();
            this._lProductos = new BindingList<Producto>();
        }
        public Pedido(int idPedido, Cliente datoCliente, BindingList<Producto> lProductos, string estado,
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
        public string Estado { get => _estado; set => _estado = value; }
        public double Total { get => _total; set => _total = value; }
        public DateTime DateReg { get => _dateReg; set => _dateReg = value; }
        internal BindingList<Producto> LProductos { get => _lProductos; set => _lProductos = value; }
    }
}
