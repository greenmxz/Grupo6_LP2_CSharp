using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string contraseña;

        public Usuario()
        {

        }

        public Usuario(int id,string nomb,string cont)
        {
            idUsuario = id;
            nombre = nomb;
            contraseña = cont;
        }

        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Contraseña { get => contraseña; set => contraseña = value; }
    }
}
