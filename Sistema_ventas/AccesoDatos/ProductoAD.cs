using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos.Auxiliar;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using Modelo;

namespace AccesoDatos
{
    public class ProductoAD
    {
        public ProductoAD()
        {

        }

        public BindingList<Producto> devolverlista()
        {
            BindingList<Producto> listaproducto = new BindingList<Producto>();
            ConexionAD.conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT *  FROM Producto";
            ConexionAD.cast(cmd);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int estado = reader.GetInt32("estadoRegistro");
                if (estado == 1)
                {
                    int id = reader.GetInt32("idProducto");
                    string nombre = reader.GetString("nombre");
                    string descripcion = reader.GetString("descripcion");
                    float pu = reader.GetFloat("precioUnitario");
                    double peso = reader.GetDouble("peso");
                    int stock = reader.GetInt32("stock");
                    Producto p = new Producto(id, nombre, descripcion, pu, peso, stock);
                    p.Id = id;
                    listaproducto.Add(p);
                }
            }
            ConexionAD.cerrar();
            return listaproducto;
        }
    }

   
}
