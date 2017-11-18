namespace Modelo
{
    public class Producto
    {
        private static int i = 1;
        private int _id ;
        private string _nombre;
        private string _descripcion;
        private float _precio;
        private double _peso;
        public Producto()
        {

        }
        public Producto(string nombre, string descripcion, float precio, double peso)
        {
            _id =i;
            _nombre = nombre;
            _precio = precio;
            _peso = peso;
            _descripcion = descripcion;
            i++;
        }

        public Producto(int id,string nombre, string descripcion, float precio, double peso)
        {
            _id = id;
            _nombre = nombre;
            _precio = precio;
            _peso = peso;
            _descripcion = descripcion;
            i++;
        }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public float Precio { get => _precio; set => _precio = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public int Id { get => _id; set => _id = value; }
        public double Peso { get => _peso; set => _peso = value; }
    }
}
