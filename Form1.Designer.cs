
namespace proyectoSemestre
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.lnkRegistro = new System.Windows.Forms.LinkLabel();
            this.lblParaRegistrarse = new System.Windows.Forms.Label();
            this.pctlogoUniversidad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogoUniversidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(120, 163);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(70, 20);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(120, 187);
            this.txtUsuario.Multiline = true;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(130, 30);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtClave
            // 
            this.txtClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClave.Location = new System.Drawing.Point(120, 266);
            this.txtClave.Multiline = true;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(130, 30);
            this.txtClave.TabIndex = 2;
            // 
            // lblClave
            // 
            this.lblClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave.Location = new System.Drawing.Point(120, 245);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(67, 20);
            this.lblClave.TabIndex = 3;
            this.lblClave.Text = "Clave";
            this.lblClave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(136, 113);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(100, 23);
            this.lblBienvenida.TabIndex = 4;
            this.lblBienvenida.Text = "Bienvenido";
            this.lblBienvenida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.Gainsboro;
            this.btnInicio.Location = new System.Drawing.Point(151, 322);
            this.btnInicio.Margin = new System.Windows.Forms.Padding(0);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(75, 23);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Text = "Iniciar";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // lnkRegistro
            // 
            this.lnkRegistro.AutoSize = true;
            this.lnkRegistro.Location = new System.Drawing.Point(173, 386);
            this.lnkRegistro.Name = "lnkRegistro";
            this.lnkRegistro.Size = new System.Drawing.Size(29, 13);
            this.lnkRegistro.TabIndex = 6;
            this.lnkRegistro.TabStop = true;
            this.lnkRegistro.Text = "aquí";
            this.lnkRegistro.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkregistro_LinkClicked);
            // 
            // lblParaRegistrarse
            // 
            this.lblParaRegistrarse.AutoSize = true;
            this.lblParaRegistrarse.Location = new System.Drawing.Point(107, 373);
            this.lblParaRegistrarse.Name = "lblParaRegistrarse";
            this.lblParaRegistrarse.Size = new System.Drawing.Size(160, 13);
            this.lblParaRegistrarse.TabIndex = 7;
            this.lblParaRegistrarse.Text = "¿Aún no estás registrado? Hazlo";
            // 
            // pctlogoUniversidad
            // 
            this.pctlogoUniversidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctlogoUniversidad.BackgroundImage")));
            this.pctlogoUniversidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctlogoUniversidad.Location = new System.Drawing.Point(42, 12);
            this.pctlogoUniversidad.Name = "pctlogoUniversidad";
            this.pctlogoUniversidad.Size = new System.Drawing.Size(298, 64);
            this.pctlogoUniversidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctlogoUniversidad.TabIndex = 8;
            this.pctlogoUniversidad.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(384, 451);
            this.Controls.Add(this.pctlogoUniversidad);
            this.Controls.Add(this.lblParaRegistrarse);
            this.Controls.Add(this.lnkRegistro);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.lblClave);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Name = "Form1";
            this.Text = "Pantalla de inicio";
            ((System.ComponentModel.ISupportInitialize)(this.pctlogoUniversidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.LinkLabel lnkRegistro;
        private System.Windows.Forms.Label lblParaRegistrarse;
        private System.Windows.Forms.PictureBox pctlogoUniversidad;
    }
}

