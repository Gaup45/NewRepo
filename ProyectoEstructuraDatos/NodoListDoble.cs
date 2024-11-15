using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuraDatos
{
    public class NodoListDoble
    {
        public Nodo siguente { get; set; }
        public Nodo anterior { get; set; }

        public string Nproducld { get; set; }
        public int PrecioVld { get; set; }
        public int CantPld { get; set; }
        public string Observacionld { get; set; }
        public int subtotalld { get; set; }
        public DateTime Fechald { get; set; }


        //Contructor//

        public NodoListDoble(string producto, int precio, int cantidad,string observacion, int subtotal, DateTime fecha)
        {
            siguente = null;
            anterior = null;

            Nproducld = producto;
            PrecioVld = precio;
            CantPld = cantidad;
            Observacionld = observacion;
            subtotalld = subtotal;
            Fechald = fecha;

        }

    }
}
