using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_doble
{
    public partial class Form1 : Form
    {Lista lst = new Lista();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            lst.Insertar(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text));
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox4.Text = lst.Listar();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox4.Text = lst.ListarInverso();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lst.Eliminar(Convert.ToInt32(textBox1.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lst.EliminarPrimero();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            lst.EliminarUltimo();
        }
    }
}
