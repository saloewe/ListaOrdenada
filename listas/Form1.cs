using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace listas
{
    public partial class Form1 : Form
    {
        Estructura catalogo = new Estructura();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassBases nuevo;
            nuevo = new ClassBases(Convert.ToInt32(txtCodigo.Text), txtNombre.Text, Convert.ToInt32(txtPrecio.Text));
            catalogo.agregar(nuevo);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text = catalogo.lista();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = catalogo.buscar(Convert.ToInt32(txtCodigo.Text));
        }

        private void btnListarInverso_Click(object sender, EventArgs e)
        {
            textBox2.Text = catalogo.listarinverso();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            catalogo.Eliminar(Convert.ToInt32(txtCodigo.Text));
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            catalogo.EliminarUltimo();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            catalogo.EliminarPriimero();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            catalogo.invertirOrden();
        }
    }
}
