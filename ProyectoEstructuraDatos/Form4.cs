using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoEstructuraDatos
{
    public partial class Form4 : Form
    {
        Listas l = new Listas();
        Nodo p ;
        string nombreproducto, observacion;
        int cantidad, precio,subtotal;
        DateTime fecha;
        public Form4()
        {
            InitializeComponent();
            cargargrid();
            cargarcombo();
            txttotalventa.Enabled = false;
        }
        public void eecalcular()
        {

            string nombreDeLaColumna = "_subtotal";

            decimal suma = 0;
            foreach (DataGridViewRow fila in dgventas.Rows)
            {
                if (!fila.IsNewRow && fila.Cells[nombreDeLaColumna].Value != null)
                {
                    suma += Convert.ToDecimal(fila.Cells[nombreDeLaColumna].Value);
                }
            }
            txttotalventa.Text = suma.ToString();
        }
        public void CapturarDatos()
        {
            nombreproducto = txtProducto.Text;
            observacion = txtobservacion.Text;
            cantidad = int.Parse(txtcantidad.Text);
            precio = int.Parse(txtprecioventa.Text);
            fecha = Convert.ToDateTime(datetimeventa.Value);
            subtotal = precio * cantidad;
        }

        private void btnInsertraInicio_Click(object sender, EventArgs e)
        {
            int u;
            if (txtcantidad.Text == "") { errorProvider1.SetError(txtcantidad, "Ingrese la cantidad"); txtcantidad.Focus(); return; }
            else errorProvider1.SetError(txtcantidad, "");
            if (txtprecioventa.Text == "") { errorProvider1.SetError(txtprecioventa, "Ingrese el precio del producto"); txtprecioventa.Focus(); return; }
            else errorProvider1.SetError(txtprecioventa, "");

            if (txtProducto.Text == "") { errorProvider1.SetError(txtProducto, "Ingrese el producto"); txtProducto.Focus(); return; }
            else errorProvider1.SetError(txtProducto, "");
            if (txtobservacion.Text == "") { errorProvider1.SetError(txtobservacion, "Ingrese la observacion"); txtobservacion.Focus(); return; } else errorProvider1.SetError(txtobservacion, "");
            if (!int.TryParse(txtprecioventa.Text, out u)) { errorProvider1.SetError(txtprecioventa, "Ingrese solo numeros"); txtprecioventa.Focus(); return; } else errorProvider1.SetError(txtprecioventa, "");
            if (!int.TryParse(txtcantidad.Text, out u)) { errorProvider1.SetError(txtcantidad, "Ingrese solo numeros"); txtcantidad.Focus(); return; } else errorProvider1.SetError(txtcantidad, "");
           
            CapturarDatos();
            if (comboBox1.Text == "Recorrido Recursivo")
            {
                dgventas.Rows.Clear();
                l.Insertar_Incio(nombreproducto, observacion, precio, cantidad, fecha, subtotal);
                l.Recorrido_Recursivo(l.P, dgventas);
            }
            if (comboBox1.Text == "Recorrido Iterativo")
            {
                dgventas.Rows.Clear();
                l.Insertar_Incio(nombreproducto, observacion, precio, cantidad, fecha, subtotal);
                l.Recorrido_Iterativo(dgventas);
            }
            eecalcular();
        }

        private void btnInsertardespuesde_Click(object sender, EventArgs e)
        {

            int u;
            if (txtcantidad.Text == "") { errorProvider1.SetError(txtcantidad, "Ingrese la cantidad"); txtcantidad.Focus(); return; }
            else errorProvider1.SetError(txtcantidad, "");
            if (txtprecioventa.Text == "") { errorProvider1.SetError(txtprecioventa, "Ingrese el precio del producto"); txtprecioventa.Focus(); return; }
            else errorProvider1.SetError(txtprecioventa, "");

            if (txtProducto.Text == "") { errorProvider1.SetError(txtProducto, "Ingrese el producto"); txtProducto.Focus(); return; }
            else errorProvider1.SetError(txtProducto, "");
            if (txtobservacion.Text == "") { errorProvider1.SetError(txtobservacion, "Ingrese la observacion"); txtobservacion.Focus(); return; } else errorProvider1.SetError(txtobservacion, "");
            if (!int.TryParse(txtprecioventa.Text, out u)) { errorProvider1.SetError(txtprecioventa, "Ingrese solo numeros"); txtprecioventa.Focus(); return; } else errorProvider1.SetError(txtprecioventa, "");
            if (!int.TryParse(txtcantidad.Text, out u)) { errorProvider1.SetError(txtcantidad, "Ingrese solo numeros"); txtcantidad.Focus(); return; } else errorProvider1.SetError(txtcantidad, "");

            CapturarDatos();
            
            l.DespuesdeX(nombreproducto, observacion, precio, cantidad, fecha,txtreferncia.Text, subtotal,dgventas);
            dgventas.Rows.Clear();
            l.Recorrido_Recursivo(l.P, dgventas);
        }

        private void btninsertarantesde_Click(object sender, EventArgs e)
        {
            int u;
            if (txtcantidad.Text == "") { errorProvider1.SetError(txtcantidad, "Ingrese la cantidad"); txtcantidad.Focus(); return; }
            else errorProvider1.SetError(txtcantidad, "");
            if (txtprecioventa.Text == "") { errorProvider1.SetError(txtprecioventa, "Ingrese el precio del producto"); txtprecioventa.Focus(); return; }
            else errorProvider1.SetError(txtprecioventa, "");

            if (txtProducto.Text == "") { errorProvider1.SetError(txtProducto, "Ingrese el producto"); txtProducto.Focus(); return; }
            else errorProvider1.SetError(txtProducto, "");
            if (txtobservacion.Text == "") { errorProvider1.SetError(txtobservacion, "Ingrese la observacion"); txtobservacion.Focus(); return; } else errorProvider1.SetError(txtobservacion, "");
            if (!int.TryParse(txtprecioventa.Text, out u)) { errorProvider1.SetError(txtprecioventa, "Ingrese solo numeros"); txtprecioventa.Focus(); return; } else errorProvider1.SetError(txtprecioventa, "");
            if (!int.TryParse(txtcantidad.Text, out u)) { errorProvider1.SetError(txtcantidad, "Ingrese solo numeros"); txtcantidad.Focus(); return; } else errorProvider1.SetError(txtcantidad, "");

            CapturarDatos();
            dgventas.Rows.Clear();
            l.Insertar_Antesdex(nombreproducto, observacion, precio, cantidad, fecha, subtotal,txtreferncia.Text,dgventas);
            l.Recorrido_Recursivo(l.P, dgventas);
        }
        Nodo P;
        private void btninsertarFinal_Click(object sender, EventArgs e)
        {
            int u;
            if (txtcantidad.Text == "") { errorProvider1.SetError(txtcantidad, "Ingrese la cantidad"); txtcantidad.Focus(); return; }
            else errorProvider1.SetError(txtcantidad, "");
            if (txtprecioventa.Text == "") { errorProvider1.SetError(txtprecioventa, "Ingrese el precio del producto"); txtprecioventa.Focus(); return; }
            else errorProvider1.SetError(txtprecioventa, "");

            if (txtProducto.Text == "") { errorProvider1.SetError(txtProducto, "Ingrese el producto"); txtProducto.Focus(); return; }
            else errorProvider1.SetError(txtProducto, "");
            if (txtobservacion.Text == "") { errorProvider1.SetError(txtobservacion, "Ingrese la observacion"); txtobservacion.Focus(); return; } else errorProvider1.SetError(txtobservacion, "");
            if (!int.TryParse(txtprecioventa.Text, out u)) { errorProvider1.SetError(txtprecioventa, "Ingrese solo numeros"); txtprecioventa.Focus(); return; } else errorProvider1.SetError(txtprecioventa, "");
            if (!int.TryParse(txtcantidad.Text, out u)) { errorProvider1.SetError(txtcantidad, "Ingrese solo numeros"); txtcantidad.Focus(); return; } else errorProvider1.SetError(txtcantidad, "");


            CapturarDatos();
            if (comboBox1.Text == "Recorrido Recursivo")
            {
                dgventas.Rows.Clear();
                l.Insertar_Final(nombreproducto, observacion, precio, cantidad, fecha, subtotal);
                l.Recorrido_Recursivo(l.P, dgventas);
            }
            if (comboBox1.Text == "Recorrido Iterativo")
            {
                dgventas.Rows.Clear();
                l.Insertar_Final(nombreproducto, observacion, precio, cantidad, fecha, subtotal);
                l.Recorrido_Iterativo(dgventas);
            }
            eecalcular();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Enabled = false; 
        }

        private void btneliminarprimernodo_Click(object sender, EventArgs e)
        {
            l.Eliminar_PrimerNodo(dgventas);
        }

        private void btneliminarUltimoNodo_Click(object sender, EventArgs e)
        {
            l.Elminar_UltimoNodo(dgventas);
        }

        private void btnbusquedadesordenada_Click(object sender, EventArgs e)
        {
                       
        }

        private void btnbusquedaordenada_Click(object sender, EventArgs e)
        {

        }

        private void btnbusquedaREcursiva_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
       

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            

        }
       

        private void btnbuscar_Click(object sender, EventArgs e)
        {
        }

        private void btnbusdesordenada_Click(object sender, EventArgs e)
        {
            string X = txtbusqueda.Text;
            l.Busqueda_Desordenado(X, dgventas);
        }

        private void btnbusquedarecursiva_Click_1(object sender, EventArgs e)
        {
            string X = txtbusqueda.Text;
            l.Busqueda_Recursiva(X,l.P,dgventas);
        }

        private void BTNRECURSIVO_Click(object sender, EventArgs e)
        {
            l.Recorrido_Recursivo(l.P,dgventas);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            l.Recorrido_Iterativo(dgventas);
        }
        public void cargargrid()
        {
            comboBox2.Items.Add("Recorrido Recursivo");
            comboBox2.Items.Add("Recorrido Iterativo");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if(comboBox2.Text == "Recorrido Recursivo")
            {
                dgventas.Rows.Clear();
                l.Recorrido_Recursivo(l.P,dgventas);
            }
            if(comboBox2.Text == "Recorrido Iterativo")
            {
                dgventas.Rows.Clear();
                l.Recorrido_Iterativo(dgventas);
            }
        }

        private void btneliminax_Click(object sender, EventArgs e)
        {
            l.eliminarX(txtreferncia.Text);
            dgventas.Rows.Clear();
            l.Recorrido_Iterativo(dgventas);
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        public void cargarcombo()
        {
            comboBox1.Items.Add("Recorrido Recursivo");
            comboBox1.Items.Add("Recorrido Iterativo");
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
