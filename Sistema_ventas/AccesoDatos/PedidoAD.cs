using System;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using Modelo;
using AccesoDatos.Auxiliar;

namespace AccesoDatos
{
    public class PedidoAD
    {
        public PedidoAD()
        {

        }
        public BindingList<Pedido> devolverLista()
        {
            BindingList<Pedido> lista = new BindingList<Pedido>();
            ConexionAD.conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM Pedido";
            ConexionAD.cast(cmd);
            Cliente clientePed = new Cliente();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int estado = reader.GetInt32("estadoRegistro");
                if (estado == 1)
                {
                    int id = reader.GetInt32("idPedido");
                    double total = reader.GetDouble("importeTotal");
                    DateTime fecha = reader.GetDateTime("fechaPedido");
                    int idCliente = reader.GetInt32("idCliente");
                    int idEstadoPedido = reader.GetInt32("idEstadoPedido");
                    string pedidoEst = "";
                    switch (idEstadoPedido)
                    {
                        case 1:
                            pedidoEst = "Registrado";
                            break;
                        case 2:
                            pedidoEst = "Pagado";
                            break;
                        case 3:
                            pedidoEst = "Anulado";
                            break;
                        case 4:
                            pedidoEst = "Despachado";
                            break;
                    }
                    /* EXTRACCIÓN DE CLIENTE */
                    MySqlConnection conCli = new MySqlConnection();
                    try
                    {
                        string cadena = "server=200.16.7.96;user=inf282g6;database=inf282g6;" +
                            "port=3306;password=ta1RQx6flDXdiTpr;";
                        conCli = new MySqlConnection(cadena);
                        conCli.Open();
                        MySqlCommand cmdCli = new MySqlCommand();
                        cmdCli.CommandText = "SELECT * FROM Cliente WHERE idCliente=" + idCliente;
                        cmdCli.Connection = conCli;
                        MySqlDataReader readerCli = cmdCli.ExecuteReader();
                        readerCli.Read();
                        clientePed = new Cliente();
                        clientePed.Id = readerCli.GetInt32("idCliente");
                        clientePed.Ruc = readerCli.GetString("ruc");
                        clientePed.RazonSocial = readerCli.GetString("razonSocial");
                        conCli.Close();
                    }
                    catch (Exception gg1)
                    {
                    }
                    Pedido p = new Pedido(id, clientePed, pedidoEst, total, fecha);
                    lista.Add(p);
                }
            }
            ConexionAD.cerrar();
            return lista;
        }
    }
}
