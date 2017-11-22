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
                    /* EXTRACCIÓN DE PRODUCTOS */
                    MySqlConnection conProd1 = new MySqlConnection();
                    BindingList<Producto> listaProd = new BindingList<Producto>();
                    try
                    {
                        string cadena = "server=200.16.7.96;user=inf282g6;database=inf282g6;" +
                             "port=3306;password=ta1RQx6flDXdiTpr;";
                        conProd1 = new MySqlConnection(cadena);
                        conProd1.Open();
                        MySqlCommand cmdProd1 = new MySqlCommand();
                        cmdProd1.CommandText = "SELECT * FROM DetallePedido WHERE idPedido=" + id;
                        cmdProd1.Connection = conProd1;
                        MySqlDataReader readerProd1 = cmdProd1.ExecuteReader();
                        while (readerProd1.Read())
                        {
                            int idProd = readerProd1.GetInt32("idProducto");
                            int valid = 0;
                            foreach (Producto pr in listaProd)
                            {
                                if (pr.Id == idProd)
                                {
                                    valid = 1;
                                    break;
                                }
                            }
                            if (valid == 0)
                            {
                                int cantidad = readerProd1.GetInt32("cantidad");
                                MySqlConnection conProd2 = new MySqlConnection();
                                try
                                {
                                    string cadenaA = "server=200.16.7.96;user=inf282g6;database=inf282g6;" +
                                         "port=3306;password=ta1RQx6flDXdiTpr;";
                                    conProd2 = new MySqlConnection(cadenaA);
                                    conProd2.Open();
                                    MySqlCommand cmdProd2 = new MySqlCommand();
                                    cmdProd2.CommandText = "SELECT * FROM Producto WHERE idProducto=" + idProd;
                                    cmdProd2.Connection = conProd2;
                                    MySqlDataReader readerProd2 = cmdProd2.ExecuteReader();
                                    readerProd2.Read();
                                    Producto prodPed = new Producto();
                                    prodPed.Id = idProd;
                                    prodPed.Nombre = readerProd2.GetString("nombre");
                                    listaProd.Add(prodPed);
                                }
                                catch(Exception gg3)
                                {

                                }
                            }
                        }
                    }
                    catch(Exception gg2)
                    {

                    }
                    Pedido p = new Pedido(id, clientePed, listaProd, pedidoEst, total, fecha);
                    lista.Add(p);
                }
            }
            ConexionAD.cerrar();
            return lista;
        }
    }
}
