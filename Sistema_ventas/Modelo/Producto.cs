using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    
    class Producto
    {
        private string _nombre;
        private string _marca;
        private float _precio;
        private string _descripcion;

        public Producto(string nombre, string marca, float precio, string descripcion)
        {
            Nombre = nombre;
            Marca = marca;
            Precio = precio;
            Descripcion = descripcion;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Marca { get => _marca; set => _marca = value; }
        public float Precio { get => _precio; set => _precio = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        //private int _codigo;--> El sistema generar el codigo en la bd o en la creacion del objeto


    }
}
