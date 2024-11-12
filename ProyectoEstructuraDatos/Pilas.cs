using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructuraDatos
{
    public class Facturacion
    {
        public struct pilaventa
        {
            public string  producto, observaciones;
            public int ? cantidad;
            public double ? precioventa, total;
            public DateTime fechave;
        }
        public pilaventa[] venta;
        public int max;
        public int tope;

        public Facturacion() { }

        public Facturacion(int maximo)
        {
            this.max = maximo;
            venta = new pilaventa[max];
            tope = 0;
        }

        public void Push(int?cantida, string product, string observaciones, DateTime fecha, double? precio, double? total)
        {
            if (pilallena() == true)
            {
                MessageBox.Show("Pila llena");
            }
            else
            {
                venta[tope].cantidad = cantida; venta[tope].observaciones = observaciones; venta[tope].producto = product;
                venta[tope].fechave = fecha; venta[tope].precioventa = precio; venta[tope].total = total;
                tope += 1;
            }
        }
        public void Pop()
        {

            if (pilavacia() == true)
            {
                return;
            }
            else
            {
                tope = tope - 1;
                venta[tope].producto = null;
                venta[tope].cantidad = null;
                venta[tope].observaciones = null;
                venta[tope].precioventa = null;
                venta[tope].fechave = DateTime.MinValue;
                venta[tope].total = null;
               
                
            }
        }
        public bool pilavacia()
        {
            if (tope == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("La pila contiene elementos");
                return false;
            }
        }
        public bool pilallena()
        {
            if (tope == max)
            {
                MessageBox.Show("Pilla llena ");

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
