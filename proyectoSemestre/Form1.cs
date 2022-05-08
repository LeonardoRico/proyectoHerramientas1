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
        List<string> usuario = new List<string>();
        List<string> clave = new List<string>();
        public Form1(List<string> user, List<string> contra)
        {
            InitializeComponent();
            usuario = user;
            clave = contra;
        }

        private void btnInicio_Click_1(object sender, EventArgs e)
        {
            bool logIn = false;
            for (int m = 0; m < usuario.Count; m++)
            {
                if (txtUsuario.Text == usuario[m] && txtClave.Text == clave[m])
                {
                    logIn = true;
                }
            }

            if (logIn == true)
            {
                MessageBox.Show("Ingreso exitoso");
                Form3 ventana3 = new Form3();
                ventana3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o clave incorrectos");
                txtUsuario.Clear();
                txtClave.Clear();
            }
        }
        private void lnkRegistro_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 ventana2 = new Form2(usuario, clave);
            ventana2.Show();
        }
    }   
}
