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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnHerramProgI_Click(object sender, EventArgs e)
        {
            int n = 4;
            Form10 ventana10 = new Form10(n);
            ventana10.Show();
            this.Hide();
        }

        private void btnElectroBas_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta materia no atrasa ninguna otra");
        }

        private void btnEstrucDat_Click(object sender, EventArgs e)
        {
            int n = 5;
            Form10 ventana10 = new Form10(n);
            ventana10.Show();
            this.Hide();
        }

        private void btnMatemOper_Click(object sender, EventArgs e)
        {
            int n = 6;
            Form10 ventana10 = new Form10(n);
            ventana10.Show();
            this.Hide();
        }

        private void btnConstiPartiCiu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta materia no atrasa ninguna otra");
        }

        private void btnGestAmb_Click(object sender, EventArgs e)
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
