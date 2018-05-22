using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas
{
    class Estructura
    {
        ClassBases inicio = null;

        public void agregar(ClassBases nuevo)
        {
            if (inicio == null)
                inicio = nuevo;
            else
            {
                ClassBases t1, t2;
                t1 = inicio;
                while (t1 != null)
                {
                    t2 = t1.Siguiente;
                    if (nuevo.Dato <= t1.Dato)
                    {
                        nuevo.Siguiente = inicio;
                        inicio = nuevo;
                        break;
                    }
                    else if (nuevo.Dato > t1.Dato && t2 == null)
                    {
                        t1.Siguiente = nuevo;
                        break;
                    }
                    else if (t1.Dato < nuevo.Dato && t2.Dato >= nuevo.Dato)
                    {
                        t1.Siguiente = nuevo;
                        nuevo.Siguiente = t2;
                        break;
                    }
                    else
                        t1 = t1.Siguiente;

                }
            }
        }

        public void EliminarPriimero()
        {
            inicio = inicio.Siguiente;
        }

        public void EliminarUltimo()
        {
            ClassBases anterior = inicio;
            ClassBases actual = inicio.Siguiente;
            while (actual.Siguiente != null)
            {
                anterior = actual;
                actual = actual.Siguiente;
            }
            anterior.Siguiente = null;
        }

        public void invertirOrden()
        {
            ClassBases q, r, x, y;
            q = inicio;
            while (q.Siguiente != null)
            {
                q = q.Siguiente;
            }
            r = inicio.Siguiente;
            q.Siguiente = inicio;
            inicio.Siguiente = null;
            y = inicio;
            while (r != q)
            {
                x = r;
                r = r.Siguiente;
                q.Siguiente = x;
                x.Siguiente = y;
                y = x;
            }
            inicio = q;
        }
        public void Eliminar(int dato)
        {
            ClassBases anterior = inicio;
            ClassBases actual = inicio.Siguiente;
            while (anterior != null)
            {
                if (actual.Dato == dato)
                {
                    if (anterior == inicio)
                    {
                        inicio.Siguiente = actual.Siguiente;
                        break;
                    }else if (anterior.Siguiente == null)
                    {
                        anterior = null;
                        break;
                    }else
                    {
                        anterior = actual;
                        break;
                    }
                }
                anterior = actual;
                actual = actual.Siguiente;
            }        
        }

        public string buscar(int dato)
        {
            ClassBases actual = inicio;
            string cadena = "";
            while (actual != null)
            {
                if (actual.Dato == dato)
                {
                    cadena = actual.ToString();
                }
                actual = actual.Siguiente;
            }
            return cadena;

        }
        public string listarinverso()
        {
            string res = "";
            ClassBases t = inicio;
            while (t != null)
            {
                res = t.ToString() + "\r\n" + res;
                t = t.Siguiente;
            }
            return res;
        }
        public string lista()
        {
            string res = "";
            ClassBases t = inicio;
            while (t != null)
            {
                res += t.ToString() + "\r\n";
                t = t.Siguiente;
            }
            return res;
        }
    }
}
