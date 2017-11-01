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
    }
}
