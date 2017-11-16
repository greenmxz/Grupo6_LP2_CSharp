using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            string url = "server=200.16.7.96;" +
                "user=inf282g6;" +
                "database=inf282g6;" +
                "port=3306;" +
                "password=ta1RQx6flDXdiTpr;";
            MySqlConnection conn = new MySqlConnection(url);
            conn.Open();

            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT *  FROM Producto";
            cmd.Connection = conn;

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int id = reader.GetInt32("idProducto");
                string nombre = reader.GetString("nombre");
                string descripcion = reader.GetString("descripcion");
                float pu = reader.GetFloat("precioUnitario");
                double peso = reader.GetDouble("peso");
                
                Producto p = new Producto(nombre, descripcion,pu, peso);
                p.Id = id;
                listaproducto.Add(p);
            }
            conn.Close();
            return listaproducto;
        }
    }

   
}
