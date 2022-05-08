using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectoSemestre
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnNivel1_Click(object sender, EventArgs e)
        {
            Form4 ventana4 = new Form4();
            ventana4.Show();
            this.Hide();
        }

        private void btnNivel2_Click(object sender, EventArgs e)
        {
            Form5 ventana5 = new Form5();
            ventana5.Show();
            this.Hide();
        }

        private void btnNivel3_Click(object sender, EventArgs e)
        {
            Form6 ventana6 = new Form6();
            ventana6.Show();
            this.Hide();
        }

        private void btnNivel4_Click(object sender, EventArgs e)
        {
            Form7 ventana7 = new Form7();
            ventana7.Show();
            this.Hide();
        }

        private void btnNivel5_Click(object sender, EventArgs e)
        {
            Form8 ventana8 = new Form8();
            ventana8.Show();
            this.Hide();

        }

        private void btnNivel6_Click(object sender, EventArgs e)
        {
            Form9 ventana9 = new Form9();
            ventana9.Show();
            this.Hide();
        }

        private void lnkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
