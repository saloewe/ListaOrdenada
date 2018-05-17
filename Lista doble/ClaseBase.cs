using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_doble
{
    class ClaseBase
    {
        private int _dato;
        private string _nombre;
        private int _precio;
        private ClaseBase sig;
        private ClaseBase ante;

        public int Dato { get { return _dato; } set { _dato = value; } }

        public ClaseBase(int dato, string nombre, int precio)
        {
            _dato = dato;
            _precio = precio;
            _nombre = nombre;
        }
        public ClaseBase Siguiente
        {
            get { return sig; }
            set { sig = value; }
        }

        public ClaseBase Anterior
        {
            get { return ante; }
            set { ante = value; }
        }
        public override string ToString()
        {
            return "Codigo = " + _dato + " Nombre: " + _nombre + "Precio: " + _precio;
        }
    }
}
