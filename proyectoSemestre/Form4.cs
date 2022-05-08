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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void lnkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 ventana3 = new Form3();
            ventana3.Show();
            this.Hide();
        }

        private void btnFunda_Click(object sender, EventArgs e)
        {
            int n = 1;
            this.Hide();
            Form10 ventana10 = new Form10(n);
            ventana10.Show();
        }

        private void btnMatDisc_Click(object sender, EventArgs e)
        {
            int n = 2;
            this.Hide();
            Form10 ventana10 = new Form10(n);
            ventana10.Show();
        }

        private void btnTGS_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta materia no atrasa ninguna otra");
        }

        private void btnSistOper_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta materia no atrasa ninguna otra");
        }

        private void btnDesHum_Click(object sender, EventArgs e)
        {
            int n = 3;
            Form10 ventana10 = new Form10(n);
            ventana10.Show();
            this.Hide();
        }

        private void btnLengMat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta materia no atrasa ninguna otra");
        }
    }
}
