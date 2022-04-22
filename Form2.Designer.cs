
namespace proyectoSemestre
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pctlogoUniversidad = new System.Windows.Forms.PictureBox();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.lblClaveNew = new System.Windows.Forms.Label();
            this.txtClaveNew = new System.Windows.Forms.TextBox();
            this.txtUsuarioNew = new System.Windows.Forms.TextBox();
            this.lblUsuarioNew = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogoUniversidad)).BeginInit();
            this.SuspendLayout();
            // 
            // pctlogoUniversidad
            // 
            this.pctlogoUniversidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctlogoUniversidad.BackgroundImage")));
            this.pctlogoUniversidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctlogoUniversidad.Location = new System.Drawing.Point(42, 12);
            this.pctlogoUniversidad.Name = "pctlogoUniversidad";
            this.pctlogoUniversidad.Size = new System.Drawing.Size(298, 64);
            this.pctlogoUniversidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctlogoUniversidad.TabIndex = 9;
            this.pctlogoUniversidad.TabStop = false;
            // 
            // lblRegistro
            // 
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(136, 113);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(100, 23);
            this.lblRegistro.TabIndex = 10;
            this.lblRegistro.Text = "Registro";
            this.lblRegistro.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblClaveNew
            // 
            this.lblClaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClaveNew.Location = new System.Drawing.Point(120, 245);
            this.lblClaveNew.Name = "lblClaveNew";
            this.lblClaveNew.Size = new System.Drawing.Size(67, 20);
            this.lblClaveNew.TabIndex = 14;
            this.lblClaveNew.Text = "Clave";
            this.lblClaveNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtClaveNew
            // 
            this.txtClaveNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClaveNew.ForeColor = System.Drawing.Color.Black;
            this.txtClaveNew.Location = new System.Drawing.Point(120, 266);
            this.txtClaveNew.Multiline = true;
            this.txtClaveNew.Name = "txtClaveNew";
            this.txtClaveNew.Size = new System.Drawing.Size(130, 30);
            this.txtClaveNew.TabIndex = 13;
            // 
            // txtUsuarioNew
            // 
            this.txtUsuarioNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioNew.ForeColor = System.Drawing.Color.Black;
            this.txtUsuarioNew.Location = new System.Drawing.Point(120, 187);
            this.txtUsuarioNew.Multiline = true;
            this.txtUsuarioNew.Name = "txtUsuarioNew";
            this.txtUsuarioNew.Size = new System.Drawing.Size(130, 30);
            this.txtUsuarioNew.TabIndex = 12;
            // 
            // lblUsuarioNew
            // 
            this.lblUsuarioNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuarioNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioNew.Location = new System.Drawing.Point(120, 165);
            this.lblUsuarioNew.Name = "lblUsuarioNew";
            this.lblUsuarioNew.Size = new System.Drawing.Size(70, 20);
            this.lblUsuarioNew.TabIndex = 11;
            this.lblUsuarioNew.Text = "Usuario nuevo";
            this.lblUsuarioNew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(151, 322);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 15;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(384, 451);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblClaveNew);
            this.Controls.Add(this.txtClaveNew);
            this.Controls.Add(this.txtUsuarioNew);
            this.Controls.Add(this.lblUsuarioNew);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.pctlogoUniversidad);
            this.Name = "Form2";
            this.Text = "Registro";
            ((System.ComponentModel.ISupportInitialize)(this.pctlogoUniversidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctlogoUniversidad;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label lblClaveNew;
        private System.Windows.Forms.TextBox txtClaveNew;
        private System.Windows.Forms.TextBox txtUsuarioNew;
        private System.Windows.Forms.Label lblUsuarioNew;
        private System.Windows.Forms.Button btnRegistrar;
    }
}