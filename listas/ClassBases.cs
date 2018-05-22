using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    class ClassBases
    {
        private int _dato;
        private string _nombre;
        private int _precio;
        //para editar la variable
        public int Dato
        {
            get { return _dato; }
            set { _dato = value; }
        }

        //la sig direccion
        private ClassBases _siguiente;
        public ClassBases Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public ClassBases(int dato, string nombre, int precio)
        {
            _dato = dato;
            _nombre = nombre;
            _precio = precio;
        }
        public override string ToString()
        {
            return "Codigo = " + _dato + " Nombre: " + _nombre + "Precio: " + _precio;
        }
    }
}
