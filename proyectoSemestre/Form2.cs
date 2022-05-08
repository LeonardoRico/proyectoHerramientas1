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
    public partial class Form2 : Form
    {
        List<string> usuario = new List<string>();
        List<string> clave = new List<string>();
        public Form2(List<string> user, List<string> contra)
        {
            InitializeComponent();
            usuario = user;
            clave = contra;
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            usuario.Add(txtUsuarioNew.Text);
            clave.Add(txtClaveNew.Text);

            MessageBox.Show("Registro exitoso");

            Form1 ventana1 = new Form1(usuario, clave);
            ventana1.Show();
            this.Hide();
        }
    }
}
