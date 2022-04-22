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
    public partial class Form1 : Form
    {
        string[] usuario = new string[5];
        string[] clave = new string[5];
        public Form1(string[] user, string[] contra)
        {
            usuario = user;
            clave = contra; 
            InitializeComponent();
        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            bool logIn = false;
            for (int m = 0; m < 5; m++)
            {
                if (txtUsuario.Text == usuario[m] && txtClave.Text == clave[m])
                {
                    logIn = true;
                }
            }

            if (logIn == true)
            {
                MessageBox.Show("Ingreso exitoso");
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos");
            }

            Form3 ventana3 = new Form3();
            ventana3.Show();
            this.Close();

        }

        private void lnkregistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 ventana2 = new Form2();
            ventana2.Show();
            this.Hide();
        }
    }   
}
