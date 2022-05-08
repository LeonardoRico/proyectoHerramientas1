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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void btnFunda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta materia no atrasa ninguna otra");
        }

        private void btnMatDisc_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta materia no atrasa ninguna otra");
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
            MessageBox.Show("Esta materia no atrasa ninguna otra");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta materia no atrasa ninguna otra");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta materia no atrasa ninguna otra");
        }

        private void lnkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 ventana3 = new Form3();
            ventana3.Show();
            this.Hide();
        }
    }
}
