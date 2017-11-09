using System.ComponentModel;
using MySql.Data.MySqlClient;
using Modelo;
using AccesoDatos.Auxiliar;

namespace AccesoDatos
{
    public class ClienteAD
    {
        public ClienteAD()
        {

        }
        public BindingList<Cliente> devolverLista()
        {
            BindingList<Cliente> lista = new BindingList<Cliente>();
            ConexionAD.conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM Cliente";
            ConexionAD.cast(cmd);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int estado = reader.GetInt32("estadoRegistro");
                if (estado == 1)
                {
                    int id = reader.GetInt32("idCliente");
                    string ruc = reader.GetString("ruc");
                    string razSoc = reader.GetString("razonSocial");
                    string telef = reader.GetString("telefono");
                    string correo = reader.GetString("correo");
                    string direc = reader.GetString("direccion");
                    int dist = reader.GetInt32("idDistrito");
                    Cliente c = new Cliente(ruc, razSoc, telef, correo, direc, dist);
                    lista.Add(c);
                }
            }

            ConexionAD.cerrar();
            return lista;
        }
    }
}
