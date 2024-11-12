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
    public partial class Form2 : Form
    {
        Facturacion fac = new Facturacion();
        public Form2()
        {
            InitializeComponent();
            agregarprod();
            desactivarcontroles();
            txtstock.Enabled = false;
            txtprecioventa.Enabled = false;
            txttotal.Enabled = false;
            txtpila.Enabled = true;
            cmbproductos.KeyPress += cmbproductos_KeyPress;
            datetimeventa.Enabled = false;
        }
        double? precio1, total, subtotal;
        int max, pila;
        int? cantidad, stock;
        int Cantidad;
        private void btneliminar_Click(object sender, EventArgs e)
        {

            if (fac.pilavacia()) { MessageBox.Show("La pila esta vacia, no puedes eliminar"); }
            else
            {
                fac.Pop();
                var lista = dgventas.CurrentRow; dgventas.Rows.Remove(lista);
            }
            calculartotalgeneral();
        }

        public void ordenar()
        {
            dgventas.Rows.Clear();
            for (int i = fac.tope - 1; i >= 0; i--)
            {
                dgventas.Rows.Add(i, fac.venta[i].producto, fac.venta[i].precioventa, fac.venta[i].cantidad, fac.venta[i].fechave, fac.venta[i].precioventa * fac.venta[i].cantidad); ;
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtcantidad.Text, out Cantidad))
            { error.SetError(txtcantidad, "Solo puede ingresa numeros"); txtcantidad.Focus(); return; }
            else error.SetError(txtcantidad, "");

            if (txtobservacion.Text == "")
            { error.SetError(txtobservacion, "Ingrese la observación sobre la compra"); txtobservacion.Focus(); return; }
            else error.SetError(txtobservacion, "");

            if (txtcantidad.Text == "")
            { error.SetError(txtcantidad, "ingrese la cantidad del produto"); txtcantidad.Focus(); return; }
            else error.SetError(txtcantidad, "");

            if (cmbproductos.Text == "")
            { error.SetError(cmbproductos, " Ingrese el producto"); cmbproductos.Focus(); return; }
            else error.SetError(cmbproductos, "");

            capturar();
         
            if (fac.pilallena()) { MessageBox.Show("pilallena"); } else { fac.Push(cantidad, prodc, observaciones, fecha, precio1, total); }
            limpiar();
            calculartotalgeneral();
            ordenar();
        }

        private void cmbproductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbproductos.Text == "Ceramica")
            {
                precio1 = 375.00;
                stock = 300;
                txtprecioventa.Text = Convert.ToString(precio1);
                txtstock.Text = Convert.ToString(stock);
            }
            if (cmbproductos.Text == "Baterias")
            {
                precio1 = 4385.00;
                stock = 10;
                txtprecioventa.Text = Convert.ToString(precio1);
                txtstock.Text = Convert.ToString(stock);

            }
            if (cmbproductos.Text == "Perlin Galvanizado")
            {
                precio1 = 1219.00;
                stock = 30;
                txtprecioventa.Text = Convert.ToString(precio1);
                txtstock.Text = Convert.ToString(stock);
            }
            if (cmbproductos.Text == "Cable de Alta tención")
            {
                precio1 = 322.00;
                stock = 40;
                txtprecioventa.Text = Convert.ToString(precio1);
                txtstock.Text = Convert.ToString(stock);
            }
            if (cmbproductos.Text == "Cemento Canal")
            {
                precio1 = 410.00;
                stock = 50;
                txtprecioventa.Text = Convert.ToString(precio1);
                txtstock.Text = Convert.ToString(stock);
            }
            if (cmbproductos.Text == "TV Smrt")
            {
                precio1 = 14000.00;
                stock = 20;
                txtprecioventa.Text = Convert.ToString(precio1);
                txtstock.Text = Convert.ToString(stock);
            }
            if (cmbproductos.Text == "Clavos de Acero")
            {
                precio1 = 40.00;
                stock = 500;
                txtprecioventa.Text = Convert.ToString(precio1);
                txtstock.Text = Convert.ToString(stock);
            }
            if (cmbproductos.Text == "Cortador de bridrio")
            {
                precio1 = 6000.00;
                stock = 50;
                txtprecioventa.Text = Convert.ToString(precio1);
                txtstock.Text = Convert.ToString(stock);
            }


        }
        public void activarcontroles()
        {
            txtcantidad.Enabled = true;
            cmbproductos.Enabled = true;
            txtobservacion.Enabled = true;

        }
        public void desactivarpila()
        {
            txtpila.Enabled = false;
            btnguardar.Enabled = false;
        }
        public void calculartotalgeneral()
        {
            total = 0;
            txtpila.Text = "";

            for (int i = 0; i < fac.tope; i++)
            {
                total += fac.venta[i].precioventa * fac.venta[i].cantidad;
                txttotal.Text = total.ToString();
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtpila.Text, out pila))
            { error.SetError(txtpila, "Solo puede ingresa numeros"); txtpila.Focus(); return; }
            else error.SetError(txtpila, "");
            if (txtpila.Text == "")
            { error.SetError(txtpila, "ingrese el total de productos"); txtpila.Focus(); return; }
            else error.SetError(txtpila, "");
            activarcontroles();
            desactivarpila();
            max = int.Parse(txtpila.Text);
            fac = new Facturacion(max);
        }

        string prodc, observaciones;

        private void cmbproductos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Esto evita que el carácter ingresado se muestre en el TextBox
            }
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        DateTime fecha;

        private void txtobservacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public void limpiar()
        {
            txtprecioventa.Text = "";
            cmbproductos.Text = "";
            txtcantidad.Text = "";
            txtstock.Text = "";
            txtobservacion.Text = "";
        }
        public void desactivarcontroles()
        {
            txtcantidad.Enabled = false;
            txtobservacion.Enabled = false;
            cmbproductos.Enabled = false;
            txtprecioventa.Enabled = false;
            txtpila.Enabled = false;
            txtstock.Enabled = false;
            txttotal.Enabled = false;
        }
        public void agregarprod()
        {
            cmbproductos.Items.Add("Perlin Galvanizado");
            cmbproductos.Items.Add("Cemento Canal");
            cmbproductos.Items.Add("Cable de Alta tención");
            cmbproductos.Items.Add("TV Smrt");
            cmbproductos.Items.Add("Lavadora LG");
            cmbproductos.Items.Add("Clavos de Acero");
            cmbproductos.Items.Add("Cortador de bridrio");
        }

        public void capturar()
        {
            prodc = cmbproductos.Text.Trim();
            observaciones = txtobservacion.Text.Trim();
            fecha = DateTime.Parse(datetimeventa.Text);
            cantidad = int.Parse(txtcantidad.Text);
            precio1 = double.Parse(txtprecioventa.Text);//ESto//
            txttotal.Text = total.ToString();
            stock = stock - cantidad;
            subtotal = precio1 * cantidad;
            total=total+ subtotal;
            txttotal.Text = Convert.ToString(total);
        }
    }
}
