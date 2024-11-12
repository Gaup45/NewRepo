using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructuraDatos
{
    public  class ColasCircular
    {

        public struct productos
        {
            public string producto, observacion;
            public DateTime fechaventa;
            public int cantidad;
            public double precio, subtotal;

        }

        public productos[] colacircularventas;
        public int maximo;
        public int frente = -1;
        public int final = -1;
        public ColasCircular() { }
        public ColasCircular(int CantMaximo)
        {
            this.maximo = CantMaximo;
            colacircularventas = new productos[CantMaximo];


        }

        public bool Colallena()
        {
            if ((final == maximo - 1 && frente == 0) || (final + 1 == frente))
            {
                return true;
            }
            else return false;
        }
        public bool ColaVacia()
        {
            if (frente == -1)
            {
                return true;
            }
            else return false;
        }

        public void InsertarCola(/*DataGridView dgventas,*/ string Producto, int Cantidad, Double Precio, double Subtotal, DateTime Fecha, string Observacion)
        {
            if (Colallena() == true)
            {
                MessageBox.Show("Cola Llena");
            }
            else
            {
                if (final == maximo - 1)
                {
                    final = 0;
                }
                else
                {

                    final++;
                }
                colacircularventas[final].producto = Producto;
                colacircularventas[final].cantidad = Cantidad;
                colacircularventas[final].precio = Precio;
                colacircularventas[final].fechaventa = Fecha;
                colacircularventas[final].observacion = Observacion;
                colacircularventas[final].subtotal = Subtotal;

                //dgventas.Rows.Add(colacircularventas[final].producto,colacircularventas[final].precio, colacircularventas[final].cantidad,
                //    colacircularventas[final].subtotal, colacircularventas[final].fechaventa, colacircularventas[final].observacion);

                if (frente == -1)
                {
                    frente = 0;
                }
            }
        }
        public void EliminarCola(DataGridView dgventas)
        {
            if (ColaVacia() == true)
            {
                MessageBox.Show("Cola Vacia");

            }
            else
            {


                dgventas.Rows.RemoveAt(0);
                if (frente == final)
                {

                    frente = -1;
                    final = -1;
                }
                else
                {
                    if (frente == maximo - 1)
                    {
                        frente = 0;
                    }
                    else
                    {
                        frente = frente + 1;
                    }
                }
            }
        }
    }
}
