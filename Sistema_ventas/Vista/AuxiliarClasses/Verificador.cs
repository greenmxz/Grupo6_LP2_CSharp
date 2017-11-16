using System;
using System.Windows.Forms;

namespace Vista
{
    public class Verificador
    {
        public Verificador()
        {
        }
        public static bool rucValido(string RUC)
        {
            if (RUC == "") { return false; }
            if (RUC.Length != 11) { return false; }
            if (RUC[1] != '0') { return false; }
            if (RUC[0] != '1' && RUC[0] != '2') { return false; }
            return true;
        }
        public static bool correoValido(string correo)
        {
            if (correo == "") { return false; }
            string[] div1 = correo.Split('@');
            if (div1[0].Length == correo.Length) { return false; }
            string[] div2 = div1[1].Split('.');
            int num = 0;
            foreach (string val in div2)
            {
                num++;
            }
            string[] validadores = { "com", "es", "pe", "org" };
            foreach (string val in validadores)
            {
                if (val == div2[num - 1]) { return true; }
            }
            return false;
        }
        public static void imprimirMessageBoxCliente(string RUC, string razSoc, string telef, string correo, string direc, string distrito)
        {
            string cadError = " errorres en el proceso";
            int contError = 0;
            if (!rucValido(RUC))
            {
                contError++;
                if (RUC == "") { cadError = cadError + Environment.NewLine + "- No ha proporcionado el Registro Único del Contribuyente (RUC) del cliente."; }
                else { cadError = cadError + Environment.NewLine + "- El RUC proporcionado no es válido."; }
            }
            if (telef == "")
            {
                contError++;
                cadError = cadError + Environment.NewLine + "- No ha proporcionado el teléfono del cliente.";
            }
            if (razSoc == "")
            {
                contError++;
                cadError = cadError + Environment.NewLine + "- No ha proporcionado la razón social del cliente.";
            }
            if (!correoValido(RUC))
            {
                contError++;
                if (correo == "") { cadError = cadError + Environment.NewLine + "- No ha proporcionado el correo electrónico del cliente."; }
                else { cadError = cadError + Environment.NewLine + "- El correo proporcionado no es válido"; }
            }
            if (direc == "")
            {
                contError++;
                cadError = cadError + Environment.NewLine + "- No ha proporcionado la dirección del cliente.";
            }
            if (correo == "")
            {
                contError++;
                cadError = cadError + Environment.NewLine + "- No ha proporcionado el distrito del cliente.";
            }
            MessageBox.Show("Se han encontrado " + contError + cadError, "Error en el proceso");
        }
        public static void imprimirMessageBoxProducto(string nombre, string descrip, string marca, string precUnit)
        {
            string cadError = " errorres en el proceso";
            int contError = 0;
            if (nombre == "")
            {
                contError++;
                cadError = cadError + Environment.NewLine + "- No ha proporcionado el nombre del producto.";
            }
            if (descrip == "")
            {
                contError++;
                cadError = cadError + Environment.NewLine + "- No ha proporcionado la descripción del producto.";
            }
            if (marca == "")
            {
                contError++;
                cadError = cadError + Environment.NewLine + "- No ha proporcionado la marca del producto.";
            }
            if (precUnit == "")
            {
                contError++;
                cadError = cadError + Environment.NewLine + "- No ha proporcionado el precio unitario del producto.";
            }
            else
            {
                if (Double.Parse(precUnit) <= 0)
                {
                    contError++;
                    cadError = cadError + Environment.NewLine + "- El precio unitario proporcionado no es válido.";
                }
            }
            /*if (stock == "")
            {
                contError++;
                cadError = cadError + Environment.NewLine + "- No ha proporcionado el stock del producto.";
            }
            else
            {
                if (Int32.Parse(stock) <= 0)
                {
                    contError++;
                    cadError = cadError + Environment.NewLine + "- El stock proporcionado no es válido.";
                }
            }*/
            MessageBox.Show("Se han encontrado " + contError + cadError, "Error en el proceso");
        }
    }
}
