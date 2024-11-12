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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void colaCircularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
          Form1 frmventascir = new Form1();
            frmventascir.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();
            this.Hide();
        }

        private void colaCircularesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form3 xx = new Form3();
            xx.Show();
            this.Hide();
        }

        private void listasEnlazadasSimplesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void listasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 frml = new Form4();
            frml.Show();
            this.Hide();
        }
    }
}
