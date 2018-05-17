using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_doble
{
    class Lista
    {
        private ClaseBase primero;
        private ClaseBase ultimo;

        public Lista()
        {
            primero = null;
            ultimo = null;
        }

        public void Insertar(int dato, string nombre, int precio)
        {
            ClaseBase nuevo = new ClaseBase(dato, nombre, precio);

         
            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = null;
                primero.Anterior = null;
                ultimo = primero;
            }
            else
            {
                ClaseBase t1 = primero;
                
                while(t1 != null)
                {
                   
                    if (nuevo.Dato <= t1.Dato)
                    {
                        nuevo.Siguiente = primero;
                        primero = nuevo;
                        primero.Anterior =null;
                        primero.Siguiente.Anterior = primero;
                        break;
                    }
                    else if (nuevo.Dato > t1.Dato && t1.Siguiente == null)
                    {
                        nuevo.Anterior = t1;
                        nuevo.Siguiente = null;
                        t1.Siguiente = nuevo;
                        ultimo = nuevo;
                        

                        break;
                    }
                    else if (t1.Dato < nuevo.Dato && t1.Siguiente.Dato >= nuevo.Dato)
                    {
                        nuevo.Siguiente = t1.Siguiente;
                        t1.Siguiente = nuevo;
                        break;
                    }
                    else
                        t1 = t1.Siguiente;
                }
            }
        }

        public string Listar()
        {
            string cadena = "";
            ClaseBase actual;
            actual = primero;
            while (actual != null)
            {
                cadena += actual.ToString() + "\r\n";
                actual = actual.Siguiente;
            }
            return cadena;
        } 

        public string ListarInverso()
        {
            string cadena = "";
            ClaseBase actual;
            actual = ultimo;
            while (actual != null)
            {
                cadena += actual.ToString() + "\r\n";
                actual = actual.Anterior;
            }
            return cadena;
        }

        public void Eliminar(int dato)
        {
            ClaseBase anterior = primero;
            ClaseBase actual = primero.Siguiente;
            while (anterior != null)
            {
                if (actual.Dato == dato)
                {
                    if (anterior == primero)
                    {
                        primero.Siguiente = actual.Siguiente;
                        break;
                    }
                    else if (anterior.Siguiente == null)
                    {
                        ultimo = ultimo.Anterior;
                        ultimo.Siguiente = null;
                        break;
                    }
                    else
                    {
                        anterior = actual;
                        break;
                    }
                }
                anterior = actual;
                actual = actual.Siguiente;
            }
        }

        public void EliminarPrimero()
        {
            primero = primero.Siguiente;
        }

        public void EliminarUltimo()
        {
            ultimo = ultimo.Anterior;
            ultimo.Siguiente = null;
        }

    }
                 
}
