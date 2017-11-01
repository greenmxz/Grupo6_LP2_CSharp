using System.IO;
using System.Windows.Forms;

namespace Vista
{
    public class AdmComboBox
    {
        public static void manipCombo(string ruta, ComboBox cboManip)
        {
            /* Manipulación de ComboBox */
            /* INICIO */
            FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
            while (true)
            {
                string distrito = sr.ReadLine();
                if (distrito == null) { break; }
                cboManip.Items.Add(distrito);
            }
            fs.Close();
            sr.Close();
            /* FIN */
        }
        //public static bool busquedaCombo(string dist, string ruta)
        //{
        //    /* Manipulación de ComboBox */
        //    /* INICIO */
        //    if(dist!="") { return false; }
        //    FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
        //    StreamReader sr = new StreamReader(fs, System.Text.Encoding.Default);
        //    while (true)
        //    {
        //        string distrito = sr.ReadLine();
        //        if (distrito == null) { break; }
        //        if (distrito == dist)
        //        {
        //            fs.Close();
        //            sr.Close();
        //            return true;
        //        }
        //    }
        //    fs.Close();
        //    sr.Close();
        //    return false;
        //    /* FIN */
        //}
    }
}
