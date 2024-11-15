using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstructuraDatos
{
    public class Nodo
    {
       public string nombreproducto { get; set; } 
       public string observacion { get; set; }
       public int precioproducto { get; set; }
       public int cantidadproducto { get; set; }
        public int subtotal { get; set; }
       public DateTime fecha { get; set; }
        public Nodo Liga { get; set;}

        public Nodo(string producto,string observacion, int precio, int cantidad, DateTime fecha, int subtotal)
        {
            this.nombreproducto = producto;
            this.precioproducto = precio;
            this.cantidadproducto = cantidad;
            this.fecha = fecha;
            this.observacion = observacion;
            Liga = null;
            this.subtotal = subtotal;
        }
        
    }
}