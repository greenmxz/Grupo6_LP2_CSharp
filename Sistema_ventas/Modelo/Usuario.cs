namespace Modelo
{
    public class Usuario
    {
        private int idUsuario;
        private string nombUsuario;
        private string nombre;
        private string paterno;
        private string materno;
        private string correo;
        private int tipo;
        public Usuario()
        {
        }
        public Usuario(int id,string nomb)
        {
            idUsuario = id;
            nombUsuario = nomb;
        }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombrUsuario { get => nombUsuario; set => nombUsuario = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Paterno { get => paterno; set => paterno = value; }
        public string Materno { get => materno; set => materno = value; }
        public string Correo { get => correo; set => correo = value; }
        public int Tipo { get => tipo; set => tipo = value; }
    }
}
