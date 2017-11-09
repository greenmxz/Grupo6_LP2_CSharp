using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System;
using System.ComponentModel;

namespace Vista
{
    public class AdminDB
    {
        public static void manipCombo(string tabla, string campo, ComboBox cboManip)
        {
            /* Manipulación de ComboBox */
            /* INICIO */
            ConexionVista.conectar();
            MySqlCommand cmd = new MySqlCommand();
            cmd.CommandText = "SELECT * FROM " + tabla;
            ConexionVista.cast(cmd);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string distrito = reader.GetString(campo);
                cboManip.Items.Add(distrito);
            }
            reader.Close();
            ConexionVista.cerrar();
            /* FIN */
        }
        public static int executeFunction(string nombre, BindingList<string> param, BindingList<string> values)
        {
            ConexionVista.conectar();

            MySqlCommand cmdCons = new MySqlCommand();
            ConexionVista.cast(cmdCons);
            cmdCons.CommandText = nombre;
            cmdCons.CommandType = System.Data.CommandType.StoredProcedure;

            if(param != null)
            {
                int i = 0;
                foreach(string elem in param)
                {
                    MySqlParameter parameter = new MySqlParameter();
                    parameter.Value = values[i];
                    parameter.Direction = System.Data.ParameterDirection.Input;
                    parameter.ParameterName = elem;
                    i++;
                    cmdCons.Parameters.Add(parameter);
                }
            }

            MySqlParameter resp = new MySqlParameter();
            resp.Direction = System.Data.ParameterDirection.ReturnValue;
            cmdCons.Parameters.Add(resp);

            cmdCons.ExecuteNonQuery();
            int id = Convert.ToInt32(resp.Value.ToString());

            ConexionVista.cerrar();
            return id;
        }
    }
}
