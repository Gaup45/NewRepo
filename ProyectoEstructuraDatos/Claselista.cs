using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuraDatos
{
    public class Claselista
    {
        //bariables de tipo nodo//
        public Nodo primero { get; set; }
        public Nodo ultimo { get; set; }
        public Nodo raiz { get; set; }

        Claselista() 
        {
            primero = null;
            ultimo = null;
            raiz = null;
        }

        //metodos//

        public void Insertar (string producto, int precio, int cantidad, string observacion, int subtotal, DateTime fecha)
        {
            if (primero ==null)
            {
                Nodo nuevo = new Nodo(producto, precio, cantidad, observacion, subtotal, fecha);
            }
        }
    }
}
