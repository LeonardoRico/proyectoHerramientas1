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
        string[] usuario = new string[5];
        string[] clave = new string[5];
        int n = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (n < 5)
            {
                MessageBox.Show("Se registró exitosamente");
                usuario[n] = txtUsuarioNew.Text;
                clave[n] = txtClaveNew.Text;
            }
            else
            {
                Console.WriteLine("El sistema alcanzó la capacidad máxima");
            }

            n += 1;
            Form1 ventana1 = new Form1(usuario, clave);
            ventana1.Show();
            this.Close();
        }

    }
}
