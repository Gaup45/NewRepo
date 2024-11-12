using System;
using System.CodeDom;
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
    public partial class Form1 : Form
    {
        ColaSimple cola = new ColaSimple();
        string nombreproducto, obser;
        int precio, can, subtotal, max, totalgeneral,stock;
        DateTime fe;

        public Form1()
        {
            InitializeComponent(); DEsactivarControles();
            cargarcombo();
            cmbpro.KeyPress += cmbpro_KeyPress;


        }
        int colatt;
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtcola.Text, out colatt)) { error.SetError(txtcola, "Porfavor Ingreso solo Numeros"); txtcola.Focus(); return; } else error.SetError(txtcola, "");
            if (txtcola.Text == "") { error.SetError(txtcola, "Porfavor ingrese un dato"); txtcola.Focus(); return; } else error.SetError(txtcola, "");
            max = int.Parse(txtcola.Text);
            cola = new ColaSimple(max);
            ActivarControles();
            txtcola.Enabled = false;
            btnnuevo.Enabled = false;
        }
        public void limpiar()
        {
            cmbpro.Text = "";
            txtprecioventa.Text = "";
            txtobservacion.Text = "";
            txtcantidad.Text = "";
            txtstock.Text = "";

        }
        public void CapturerDatos()
        {
            nombreproducto = cmbpro.Text;
            obser = txtobservacion.Text;
            precio = int.Parse(txtprecioventa.Text);
            can = int.Parse(txtcantidad.Text);
            fe = Convert.ToDateTime(datetimeventa.Value);
            txttotalventa.Text = totalgeneral.ToString();
            subtotal = precio * can;
            totalgeneral += subtotal;
            txttotalventa.Text = Convert.ToString(totalgeneral);
            stock = stock - can;
            
        }
        
        private void btnagregar_Click(object sender, EventArgs e)
        {
           

            //calcular();
            if (cola.Cola_LLena() == false)
            {
                if (cmbpro.Text == "") { error.SetError(cmbpro, "Eliga un producto"); cmbpro.Focus(); return; } else error.SetError(cmbpro, "");
                if (txtobservacion.Text == "") { error.SetError(txtobservacion, "Ingrese la observacion"); txtobservacion.Focus(); return; } else error.SetError(txtobservacion, "");
                if (txtcantidad.Text == "") { error.SetError(txtcantidad, "Porfavor no deje vacio el campo"); txtcantidad.Focus(); return; } else error.SetError(txtcantidad, "");
                if (txtprecioventa.Text == "") { error.SetError(txtprecioventa, "Porfavor no deje vacio el campo"); txtprecioventa.Focus(); return; } else error.SetError(txtprecioventa, "");
                if (!int.TryParse(txtprecioventa.Text, out colatt)) { error.SetError(txtprecioventa, "Porfavo ingrese el precio"); txtprecioventa.Focus(); return; } else error.SetError(txtprecioventa, "");
                if (!int.TryParse(txtcantidad.Text, out colatt)) { error.SetError(txtcola, "Porfavor ingrese la cantidad"); txtcantidad.Focus(); return; } else error.SetError(txtcantidad, "");
                CapturerDatos();
                cola.Insertar_Cola(nombreproducto, precio, obser, can, fe,subtotal);
                mostrardara();
                
                MessageBox.Show("Cola Vacia");
                limpiar();
                btneliminar.Enabled = true;
            }
            else
            {

            }

        }
        public void mostrardara()
        {
            dgventas.Rows.Clear();
            for (int i = 0; i < cola.final; i++)
            {

                dgventas.Rows.Add(cola.arrayCola[i].nombreproducto, cola.arrayCola[i].precio, cola.arrayCola[i].obervacion, cola.arrayCola[i].cantidad, cola.arrayCola[i].fecha, cola.arrayCola[i].precio * cola.arrayCola[i].cantidad);
            }

        }
        public void calcular()
        {

           
                subtotal = precio *  can;
                totalgeneral = +subtotal;
                txttotalventa.Text = totalgeneral.ToString();

            

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            

                if (cola.Cola_Vacia())
                {
                    MessageBox.Show("Cola Vacia");
                }
                else 
                {
                cola.Eliminar_Cola(nombreproducto, precio, obser, can, fe,subtotal);
                var lista = dgventas.ColumnCount; dgventas.Rows.RemoveAt(0);
                MessageBox.Show("Se elimino cola");
                eecalcular();
                }
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
        private void btnsalir_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }
        public void cargarcombo()
        {
            cmbpro.Items.Add("Papel");
            cmbpro.Items.Add("Papelografo");
            cmbpro.Items.Add("Cartulina");
            cmbpro.Items.Add("Lapiz");
        }

        private void cmbpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtobservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void cmbpro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbpro.Text == "Papel")
            {
                precio = 6;
                stock = 15;
                txtstock.Text = Convert.ToString(stock);
                txtprecioventa.Text = Convert.ToString(precio);
            }
            if (cmbpro.Text == "Papelografo")
            {
                precio = 8;
                stock = 20;
                txtstock.Text = Convert.ToString(stock);
                txtprecioventa.Text = Convert.ToString(precio);
            }
            if (cmbpro.Text == "Cartulina")
            {
                precio = 12;
                stock = 23;
                txtstock.Text = Convert.ToString(stock);
                txtprecioventa.Text = Convert.ToString(precio);
            }
            if (cmbpro.Text == "Lapiz")
            {
                precio = 5;
                stock = 10;
                txtstock.Text = Convert.ToString(stock);
                txtprecioventa.Text = Convert.ToString(precio);
            }

        }

        public void DEsactivarControles()
        {
            cmbpro.Enabled = false;
            txtprecioventa.Enabled = false;
            txttotalventa.Enabled = false;
            txtobservacion.Enabled = false;
            txtcantidad.Enabled = false;
            datetimeventa.Enabled = false;
            btnagregar.Enabled = false;
            txtstock.Enabled = false;
            btneliminar.Enabled = false;
        }
        public void ActivarControles()
        {
            cmbpro.Enabled = true;
            txtcantidad.Enabled = true;
            txtobservacion.Enabled = true;
       
            btnagregar.Enabled=true;
        }
        public void CalcularTotal()
        {
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

       

        
    }
}
