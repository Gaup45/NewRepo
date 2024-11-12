using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProyectoEstructuraDatos.ColasCircular;

namespace ProyectoEstructuraDatos
{
     public class Listas
    {
        public Nodo P { get; set; }
        Nodo Q { get; set; }
        //si funciona biennnnnnn
        public void Recorrido_Iterativo(DataGridView dgventas)
        {
            //dgventas.Rows.Clear();
            Nodo Q = P;
            while (Q != null)
            {
                dgventas.Rows.Add(Q.nombreproducto, Q.precioproducto, Q.cantidadproducto, Q.observacion, Q.fecha, Q.subtotal);
                Q = Q.Liga;
            }

        }
        //no funciona bien
        public void Recorrido_Recursivo(Nodo P,DataGridView dgventas)
        {
            
            if (P != null)
            {
                
                dgventas.Rows.Add(P.nombreproducto, P.precioproducto, P.cantidadproducto, P.observacion, P.fecha, P.subtotal);
                Recorrido_Recursivo(P.Liga, dgventas);
            }
           

        }
        //funciona
        public void Insertar_Incio(string nombreproducto, string observacion, int precio, int cantidad, DateTime fecha,int subtotal)
        {
            if(P==null)
            {
                P = new Nodo(nombreproducto, observacion, precio, cantidad, fecha,subtotal);
            }
            else
            {
                Q= new Nodo(nombreproducto, observacion, precio, cantidad, fecha, subtotal);
                Q.Liga = P;
                P = Q;
            }
        }
        //funciona
        public void Insertar_Final(string nombreproducto, string observacion, int precio, int cantidad, DateTime fecha,int subtotal)
        {
            Nodo T = P;
            if(P==null)
            {
                P=new Nodo(nombreproducto, observacion, precio, cantidad, fecha, subtotal);
            }
            else
            {
                while(T.Liga!=null)
                {
                    T = T.Liga;
                }
                Q=new Nodo(nombreproducto, observacion, precio, cantidad, fecha, subtotal);
                Q.Liga = null;
                T.Liga = Q;
            }
        }
        Nodo T;
        Nodo Y;
        //falta probar
        public void Insertar_Antesdex(string nombreproducto, string observacion, int precio, int cantidad, DateTime fecha, int subtotal,string x ,DataGridView dgventas)
        {
            Nodo Y, T = null;
            Nodo Q = P;
            int bandera = 1;
            while((Q.nombreproducto !=x)&&(bandera==1))
            {
                if (Q.Liga != null)
                {
                    T = Q;
                    Q = Q.Liga;

                }
                else
                {
                    bandera = 0;
                }
            }
            if(bandera==1)
            {
                 Y = new Nodo( nombreproducto, observacion, precio,  cantidad,fecha, subtotal);
                if(P==Q)
                {
                    Y.Liga = P;
                    P = Y;
                   
                    Recorrido_Recursivo(P.Liga, dgventas);
                }
                else
                {
                    T.Liga = Y;
                    Y.Liga = Q;

                }
            }
            else
            {
                MessageBox.Show("El nodo dado como referencia no se encuentra en la lista");
            }
  
        }
       //falta probar
        public void DespuesdeX(string nombreproducto, string observacion, int precio, int cantidad, DateTime fecha,string X ,int subtotal,DataGridView dgventas)
        {
            Nodo T;   
            Nodo Q = P;
            int bandera = 1;
            while ((Q.nombreproducto != X) && (bandera == 1))
            {
                if(Q.Liga !=null)
                {
                    Q = Q.Liga;
                }
                else
                {
                    bandera = 0;
                }
            }
            if(bandera==1)
            {
                T = new Nodo(nombreproducto, observacion,precio,cantidad,fecha, subtotal);
                T.Liga = Q.Liga;
                Q.Liga = T;
            }
            else { MessageBox.Show("El nodo de referencia no se encuentra en la lista"); }
           
        }
        //da bien
        public void Eliminar_PrimerNodo(DataGridView dgventas)
        {
            Q =P;
            if(P==null)
            {
                MessageBox.Show("Ya no hay nodos");
            }
            else
            {

                P = Q.Liga;
                Q = null;
                dgventas.Rows.RemoveAt(0);

            }
        }
        //da bien
        public void Elminar_UltimoNodo(DataGridView dgventas)
        {
            Q = P;
            if(P==null)
            {
                MessageBox.Show("Ya no hay nodos");

            }
            else
            {
               if(P.Liga==null)
                {
                    P = null;
                }
               else
                {
                    while (Q.Liga != null)
                    {
                        T = Q;
                        Q = Q.Liga; //aqui esta el error
                    }
                    T.Liga = null;
                    Q = null;

                }
                // Verifica si el DataGridView tiene al menos una fila
                if (dgventas.Rows.Count > 0)
                {
                    // Obtiene el índice de la última fila
                    int lastIndex = dgventas.Rows.Count - 1;

                    // Elimina la última fila
                    dgventas.Rows.RemoveAt(lastIndex);
                }
                else
                {
                    // Si el DataGridView está vacío, puedes mostrar un mensaje o realizar alguna acción apropiada.
                    MessageBox.Show("El DataGridView está vacío. No hay datos que eliminar.");
                }


            }
        }

        public void Busqueda_Desordenado(string X,DataGridView dgventas)
        {
            Nodo Q = P;
                Q = P;
                while(Q !=null && Q.nombreproducto != X)
                {
                    Q=Q.Liga;
                }
                if(Q==null)
                {
                    MessageBox.Show("EL elemento no se encuentra en la lista");
                    return;
                }
                else 
                {
                    MessageBox.Show("El elemento se encuentra en la lista");
                    dgventas.Rows.Clear();
                    dgventas.Rows.Add(Q.nombreproducto, Q.precioproducto, Q.cantidadproducto, Q.observacion, Q.fecha, Q.subtotal);
                }
            

        }
        public void Busqueda_Recursiva(string X,Nodo P,DataGridView dgventas)
        {
            if(P !=null) 
            {
                if (P.nombreproducto == X)
                {
                    MessageBox.Show("Se encuentra en la lista");
                    dgventas.Rows.Clear();
                    dgventas.Rows.Add(P.nombreproducto, P.precioproducto, P.cantidadproducto, P.observacion, P.fecha, P.subtotal);
                }
                else
                {
                    Busqueda_Recursiva(X, P.Liga,dgventas);
                   

                }
            }
            else
            {
                MessageBox.Show("EL elemento no se encuentra en la lista");
            }
        }
        public void Busqueda_Ordenada()
        {

        }
        public void Eliminar_anteriorX()
        {

        }
        public void Eliminar_NodoconInformacion(string x, string nombreproducto, string observacion, int cantidad, int precio, DateTime fecha, int subtotal)
        {
        }
        public void eliminarX(string x)
        {

            Nodo Q = P;
            int Bandera = 1;
            Nodo T;
            if (P == null)
            {
                MessageBox.Show("Ya no hay Nodo");

            }
            else
            {
                while (Q.Liga.nombreproducto != x && (Bandera == 1))
                {
                    if (Q.Liga != null)
                    {
                        T = Q;
                        Q = Q.Liga;

                    }
                    else
                    {
                        Bandera = 0;
                    }
                }
                if (Bandera == 0)
                {
                    MessageBox.Show("El elemneto no se encunetra en la lista");
                }
                else
                {
                    if (P == Q)
                    {
                        P = Q.Liga;
                    }
                    else
                    {
                        P = Q.Liga;
                        Q = null;
                    }
                }
            }
        }
    }
}
