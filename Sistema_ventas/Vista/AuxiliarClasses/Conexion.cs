using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Vista
{
    public class Conexion
    {
        public static MySqlConnection conect;
        public static void conectar()
        {
            try
            {
                string cadena = "server=200.16.7.96;user=inf282g6;database=inf282g6;" +
                    "port=3306;password=ta1RQx6flDXdiTpr;";
                conect = new MySqlConnection(cadena);
                conect.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error de conexión");
            }
        }
        public static void cerrar()
        {
            conect.Close();
        }
        public static void cast(MySqlCommand cmd)
        {
            cmd.Connection = conect;
        }
    }
}
