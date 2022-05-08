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
    public partial class Form10 : Form
    {
        int m = 0;
        public Form10(int n)
        {
            m = n;
            InitializeComponent();
            //materias que atrasa fundamentos de programación
            if (n == 1)
            {
                lblMat1.Text = "HERRAMIENTAS DE PROGRAMACIÓN I";
                lblColMat1.BackColor = Color.Plum;
                lblMat2.Text = "ESTRUCTURA DE DATOS";
                lblColMat2.BackColor = Color.Plum;
                lblMat3.Text = "HERRAMIENTAS DE PROGRAMACION II";
                lblColMat3.BackColor = Color.PaleGreen;
                lblMat4.Text = "BASES DE DATOS I";
                lblColMat4.BackColor = Color.PaleGreen;
                lblMat5.Text = "ALGEBRA LINEAL";
                lblColMat5.BackColor = Color.PaleGreen;
                lblMat6.Text = "HERRAMIENTAS DE PROGRAMACION III";
                lblColMat6.BackColor = Color.AntiqueWhite;
                lblMat7.Text = "ELECTIVA I";
                lblColMat7.BackColor = Color.AntiqueWhite;
                lblMat8.Text = "BASES DE DATOS II";
                lblColMat8.BackColor = Color.AntiqueWhite;
                lblMat9.Text = "ELECTIVA II";
                lblColMat9.BackColor = Color.Khaki;
                lblMat10.Text = "INGENIERÍA DE SOFTWARE I";
                lblColMat10.BackColor = Color.Khaki;
                lblMat11.Text = "PROGRAMACIÓN DE DISPOSITIVOS MÓVILES";
                lblColMat11.BackColor = Color.LightSteelBlue;
                lblMat12.Text = "ELECTIVA III";
                lblColMat12.BackColor = Color.LightSteelBlue;
                lblMat13.Text = "INGENIERÍA DE SOFTWARE II";
                lblColMat13.BackColor = Color.LightSteelBlue;
                lblCantMat.Text = "13 MATERIAS";
            }

            //materias que atrasa matematicas operativas
            if (n == 2)
            {
                lblMat1.Text = "MATEMATICAS OPERATIVAS";
                lblColMat1.BackColor = Color.Plum;
                lblMat2.Text = "CALCULO DIFERENCIAL";
                lblColMat2.BackColor = Color.PaleGreen;
                lblMat3.Text = "CALCULO INTEGRAL";
                lblColMat3.BackColor = Color.AntiqueWhite;
                lblMat4.Text = "";
                lblColMat4.BackColor = Color.White;
                lblMat5.Text = "";
                lblColMat5.BackColor = Color.White;
                lblMat6.Text = "";
                lblColMat6.BackColor = Color.White;
                lblMat7.Text = "";
                lblColMat7.BackColor = Color.White;
                lblMat8.Text = "";
                lblColMat8.BackColor = Color.White;
                lblMat9.Text = "";
                lblColMat9.BackColor = Color.White;
                lblMat10.Text = "";
                lblColMat10.BackColor = Color.White;
                lblMat11.Text = "";
                lblColMat11.BackColor = Color.White;
                lblMat12.Text = "";
                lblColMat12.BackColor = Color.White;
                lblMat13.Text = "";
                lblColMat13.BackColor = Color.White;
                lblCantMat.Text = "3 MATERIAS";
            }

            //materias que atrasa desarrollo humano y social
            if (n == 3)
            {
                lblMat1.Text = "GESTION EMPRESARIAL";
                lblColMat1.BackColor = Color.Khaki;
                lblMat2.Text = "METODOLOGIA DE LA INVESTIGACION";
                lblColMat2.BackColor = Color.LightSteelBlue;
                lblMat3.Text = "";
                lblColMat3.BackColor = Color.White;
                lblMat4.Text = "";
                lblColMat4.BackColor = Color.White;
                lblMat5.Text = "";
                lblColMat5.BackColor = Color.White;
                lblMat6.Text = "";
                lblColMat6.BackColor = Color.White;
                lblMat7.Text = "";
                lblColMat7.BackColor = Color.White;
                lblMat8.Text = "";
                lblColMat8.BackColor = Color.White;
                lblMat9.Text = "";
                lblColMat9.BackColor = Color.White;
                lblMat10.Text = "";
                lblColMat10.BackColor = Color.White;
                lblMat11.Text = "";
                lblColMat11.BackColor = Color.White;
                lblMat12.Text = "";
                lblColMat12.BackColor = Color.White;
                lblMat13.Text = "";
                lblColMat13.BackColor = Color.White;
                lblCantMat.Text = "2 MATERIAS";
            }
            //materias que atrasa herramientas de programcion I
            if (n == 4)
            {
                lblMat1.Text = "HERRAMIENTAS DE PROGRAMACION II";
                lblColMat1.BackColor = Color.PaleGreen;
                lblMat2.Text = "HERRAMIENTAS DE PROGRAMACION III";
                lblColMat2.BackColor = Color.AntiqueWhite;
                lblMat3.Text = "ELECTIVA I";
                lblColMat3.BackColor = Color.AntiqueWhite;
                lblMat4.Text = "ELECTIVA II";
                lblColMat4.BackColor = Color.Khaki;
                lblMat5.Text = "PROGRAMACIÓN DE DISPOSITIVOS MÓVILES";
                lblColMat5.BackColor = Color.LightSteelBlue;
                lblMat6.Text = "ELECTIVA III";
                lblColMat6.BackColor = Color.LightSteelBlue;
                lblMat7.Text = "";
                lblColMat7.BackColor = Color.White;
                lblMat8.Text = "";
                lblColMat8.BackColor = Color.White;
                lblMat9.Text = "";
                lblColMat9.BackColor = Color.White;
                lblMat10.Text = "";
                lblColMat10.BackColor = Color.White;
                lblMat11.Text = "";
                lblColMat11.BackColor = Color.White;
                lblMat12.Text = "";
                lblColMat12.BackColor = Color.White;
                lblMat12.Text = "";
                lblColMat12.BackColor = Color.White;
                lblMat13.Text = "";
                lblColMat13.BackColor = Color.White;
                lblCantMat.Text = "6 MATERIAS";
            }
            //materias que atrasa estructura de datos
            if (n == 5)
            {
                lblMat1.Text = "BASES DE DATOS I";
                lblColMat1.BackColor = Color.PaleGreen;
                lblMat2.Text = "ALGEBRA LINEAL";
                lblColMat2.BackColor = Color.PaleGreen;
                lblMat3.Text = "BASES DE DATOS II";
                lblColMat3.BackColor = Color.AntiqueWhite;
                lblMat4.Text = "INGENIERIA DE SOFTWARE I";
                lblColMat4.BackColor = Color.Khaki;
                lblMat5.Text = "INGENIERIA DE SOFTWARE I";
                lblColMat5.BackColor = Color.LightSteelBlue;
                lblMat6.Text = "";
                lblColMat6.BackColor = Color.White;
                lblMat7.Text = "";
                lblColMat7.BackColor = Color.White;
                lblMat8.Text = "";
                lblColMat8.BackColor = Color.White;
                lblMat9.Text = "";
                lblColMat9.BackColor = Color.White;
                lblMat10.Text = "";
                lblColMat10.BackColor = Color.White;
                lblMat11.Text = "";
                lblColMat11.BackColor = Color.White;
                lblMat12.Text = "";
                lblColMat12.BackColor = Color.White;
                lblMat12.Text = "";
                lblColMat12.BackColor = Color.White;
                lblMat13.Text = "";
                lblColMat13.BackColor = Color.White;
                lblCantMat.Text = "5 MATERIAS";
            }
            //materias que atrasa matematicas operativas
            if (n == 6)
            {
                lblMat1.Text = "CALCULO DIFERENCIAL";
                lblColMat1.BackColor = Color.PaleGreen;
                lblMat2.Text = "CALCULO INTEGRAL";
                lblColMat2.BackColor = Color.AntiqueWhite;
                lblMat3.Text = "";
                lblColMat3.BackColor = Color.White;
                lblMat4.Text = "";
                lblColMat4.BackColor = Color.White;
                lblMat5.Text = "";
                lblColMat5.BackColor = Color.White;
                lblMat6.Text = "";
                lblColMat6.BackColor = Color.White;
                lblMat7.Text = "";
                lblColMat7.BackColor = Color.White;
                lblMat8.Text = "";
                lblColMat8.BackColor = Color.White;
                lblMat9.Text = "";
                lblColMat9.BackColor = Color.White;
                lblMat10.Text = "";
                lblColMat10.BackColor = Color.White;
                lblMat11.Text = "";
                lblColMat11.BackColor = Color.White;
                lblMat12.Text = "";
                lblColMat12.BackColor = Color.White;
                lblMat12.Text = "";
                lblColMat12.BackColor = Color.White;
                lblMat13.Text = "";
                lblColMat13.BackColor = Color.White;
                lblCantMat.Text = "2 MATERIAS";

            }

            
        }

        private void lnkAtras_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //devolver al nivel 1
            if(m <= 3)
            {
                Form4 ventana4 = new Form4();
                ventana4.Show();
                this.Hide();
            }

            //devolver al nivel 2
            if (m > 3 && m <= 6)
            {
                Form5 ventana5 = new Form5();
                ventana5.Show();
                this.Hide();
            }
        }

    }
}
