﻿using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Vista
{
    public class AdmComboBox
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
    }
}
