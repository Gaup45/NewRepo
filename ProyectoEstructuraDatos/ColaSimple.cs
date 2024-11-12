using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructuraDatos
{
    public class ColaSimple
    {
        public struct colasimple
        {
            public string nombreproducto { get; set; }
            public int precio { get; set; }
            public string obervacion { get; set; }
            public DateTime fecha { get; set; }
            public int cantidad { get; set; }
            public int subtotal { get; set; }

        }
        public colasimple[] arrayCola { get; set; }
        public int frente { get; set; }
        public int max { get; set; }
        public int final { get; set; }
        public string datos { get; set; }

        public ColaSimple()
        { }
        public ColaSimple(int Max)
        {
            this.max = Max;
            arrayCola = new colasimple[Max];
            frente = 0;
            final = 0;

        }
        public bool Cola_Vacia()
        {
            if (frente == final)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        public bool Cola_LLena()
        {
            if (final == max)
            {
                MessageBox.Show("Cola LLena");
                return true;
            }
            else
            {

                return false;
            }
        }
        public void Insertar_Cola(string nombre, int pre, string obser, int can, DateTime fe,int subtotal)
        {
            if (Cola_LLena() == false)
            {

                arrayCola[final].nombreproducto = nombre;
                arrayCola[final].precio = pre;
                arrayCola[final].obervacion = obser;
                arrayCola[final].cantidad = can;
                arrayCola[final].fecha = fe;
                arrayCola[final].subtotal = subtotal;
                final = final + 1;
            }
            else
            {
                MessageBox.Show("Cola LLena");
            }
        }
        public void Eliminar_Cola(string nombre, int pre, string obser, int can, DateTime fe, int subtotal)
        {
            if (Cola_Vacia() == false)
            {
                arrayCola[frente].nombreproducto = null;
                arrayCola[frente].precio =0 ;
                arrayCola[frente].obervacion = null;
                arrayCola[frente].cantidad = 0;
                arrayCola[frente].fecha = DateTime.MinValue;
                frente = frente + 1;
            }
            else
            {
                MessageBox.Show("Cola Vacia");
            }
        }
    }
}
