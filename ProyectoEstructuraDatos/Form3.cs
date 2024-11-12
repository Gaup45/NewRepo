using System;
using System.Collections;
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
    public partial class Form3 : Form
    {
        public string producto, observacion;
        public int maximo = 0, cantidad;
        public double precio, subtotal, total;
        public DateTime fecha;
        ArrayList ColasCircular = new ArrayList();

        ColasCircular colacir = new ColasCircular();
        public Form3()
        {
            InitializeComponent();
            agregarproductos();
            DesactivarControles();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            colacir.EliminarCola(dgventas);
            if (dgventas.Rows.Count > 0)
            {
                if (colacir.ColaVacia() == false)
                {

                   
                   
                    MessageBox.Show("Se eliminó la cola");

                    eecalcular();
                }
            }
           
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            maximo = 0;
            txtmaximo.Enabled = true;
            btnaceptar.Enabled = true;
            DesactivarControles();
            txtcantidad.Clear();
            txtmaximo.Clear();
            txtprecio.Clear();
            cmbproducto.Text = "";
            txtobservación.Clear();
            total = 0;
            txttotal.Clear();
        }

        public void agregarproductos()
        {
            cmbproducto.Items.Add("Ceramica Roja");
            cmbproducto.Items.Add("Bateria de autos");
            cmbproducto.Items.Add("Perlin Galvanizado");
            cmbproducto.Items.Add("Cemento Canal");
            cmbproducto.Items.Add("Cable de Alta tención");
            cmbproducto.Items.Add("TV Smrt");
            cmbproducto.Items.Add("Lavadora LG");
            cmbproducto.Items.Add("Clavos de Acero");
            cmbproducto.Items.Add("Cortador de bridrio");
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtcantidad.Text == "") { errorProvider1.SetError(txtcantidad, "Ingrese la cantidad"); txtcantidad.Focus(); return; }
            else errorProvider1.SetError(txtcantidad, "");

            if (txtmaximo.Text == "") { errorProvider1.SetError(txtmaximo, "Ingrese el máximo"); txtmaximo.Focus(); return; }
            else errorProvider1.SetError(txtmaximo, "");

            if (txtprecio.Text == "") { errorProvider1.SetError(txtprecio, "Ingrese el precio del producto"); txtprecio.Focus(); return; }
            else errorProvider1.SetError(txtprecio, "");

            if (cmbproducto.Text == "") { errorProvider1.SetError(cmbproducto, "Ingrese el producto"); cmbproducto.Focus(); return; }
            else errorProvider1.SetError(cmbproducto, "");



            producto = cmbproducto.Text;
            cantidad = int.Parse(txtcantidad.Text);
            precio = double.Parse(txtprecio.Text);
            subtotal = cantidad * precio;
            fecha = Convert.ToDateTime(datatime.Text);
            observacion = txtobservación.Text;
            if (colacir.Colallena())
            {
                MessageBox.Show("La cola esta llena, no puede agregar más");

            }
            else
            {
                colacir.InsertarCola(/*dgventas,*/ producto, cantidad, precio, subtotal, fecha, observacion);
                cargargrid();
                total += subtotal;
                txttotal.Text = Convert.ToString(total);
                //agregardata();
                txtcantidad.Clear();
                txtprecio.Clear();
                cmbproducto.Text = "";
            }
        }

        private void txtmaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtprecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Menu frm = new Menu();
            frm.Show();
            this.Hide();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        public void eecalcular()
        {

            string nombreDeLaColumna = "_Subtotal";

            decimal suma = 0;
            foreach (DataGridViewRow fila in dgventas.Rows)
            {
                if (!fila.IsNewRow && fila.Cells[nombreDeLaColumna].Value != null)
                {
                    suma += Convert.ToDecimal(fila.Cells[nombreDeLaColumna].Value);
                }
            }
            txttotal.Text = suma.ToString();


        }
        public void cargargrid()
        {
            dgventas.Rows.Clear();
            for (int i = 0; i <= colacir.final; i++)
            {
                dgventas.Rows.Add(
                    colacir.colacircularventas[i].producto,
                    colacir.colacircularventas[i].precio,
                    colacir.colacircularventas[i].cantidad,
                    colacir.colacircularventas[i].subtotal,
                    colacir.colacircularventas[i].fechaventa,
                    colacir.colacircularventas[i].observacion


                    );
            }
        }
        public void DesactivarControles()
        {
            btnagregar.Enabled = false;
            btneliminar.Enabled = false;
            txtcantidad.Enabled = false;
            cmbproducto.Enabled = false;
            txtprecio.Enabled = false;
            txttotal.Enabled = false;
        }
        public void ActivarControles()
        {
            btnaceptar.Enabled = false;
            txtmaximo.Enabled = false;
            btnagregar.Enabled = true;
            btneliminar.Enabled = true;
            txtcantidad.Enabled = true;
            cmbproducto.Enabled = true;
            txtprecio.Enabled = true;
        }
        public void agregardata()
        {
            dgventas.Rows.Add(producto, precio, cantidad, subtotal, fecha, observacion);
        }
        private void btnaceptar_Click(object sender, EventArgs e)
        {
            ActivarControles();
            maximo = int.Parse(txtmaximo.Text);
            colacir = new ColasCircular(maximo);
            if (txtmaximo.Text == "") { errorProvider1.SetError(txtmaximo, "Ingrese la cantidad maxima "); txtmaximo.Focus(); return; }
            else errorProvider1.SetError(txtmaximo, "");
        }
    }
}
