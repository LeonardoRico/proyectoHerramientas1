namespace proyectoSemestre
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pctlogoUniversidad = new System.Windows.Forms.PictureBox();
            this.lblSelección = new System.Windows.Forms.Label();
            this.lblNiveles = new System.Windows.Forms.Label();
            this.btnNivel1 = new System.Windows.Forms.Button();
            this.btnNivel2 = new System.Windows.Forms.Button();
            this.btnNivel3 = new System.Windows.Forms.Button();
            this.btnNivel4 = new System.Windows.Forms.Button();
            this.btnNivel5 = new System.Windows.Forms.Button();
            this.btnNivel6 = new System.Windows.Forms.Button();
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
            this.pctlogoUniversidad.TabIndex = 10;
            this.pctlogoUniversidad.TabStop = false;
            // 
            // lblSelección
            // 
            this.lblSelección.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelección.Location = new System.Drawing.Point(39, 130);
            this.lblSelección.Name = "lblSelección";
            this.lblSelección.Size = new System.Drawing.Size(301, 60);
            this.lblSelección.TabIndex = 11;
            this.lblSelección.Text = "Los siguientes son los niveles de la Tecnología en Desarrollo de Software. Selecc" +
    "ione el nivel al cual pertenece la materia que desea cancelar:";
            // 
            // lblNiveles
            // 
            this.lblNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiveles.Location = new System.Drawing.Point(38, 96);
            this.lblNiveles.Name = "lblNiveles";
            this.lblNiveles.Size = new System.Drawing.Size(100, 23);
            this.lblNiveles.TabIndex = 12;
            this.lblNiveles.Text = "Niveles";
            this.lblNiveles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnNivel1
            // 
            this.btnNivel1.Location = new System.Drawing.Point(120, 205);
            this.btnNivel1.Name = "btnNivel1";
            this.btnNivel1.Size = new System.Drawing.Size(139, 23);
            this.btnNivel1.TabIndex = 13;
            this.btnNivel1.Text = "Nivel 1";
            this.btnNivel1.UseVisualStyleBackColor = true;
            // 
            // btnNivel2
            // 
            this.btnNivel2.Location = new System.Drawing.Point(120, 243);
            this.btnNivel2.Name = "btnNivel2";
            this.btnNivel2.Size = new System.Drawing.Size(139, 23);
            this.btnNivel2.TabIndex = 14;
            this.btnNivel2.Text = "Nivel 2";
            this.btnNivel2.UseVisualStyleBackColor = true;
            // 
            // btnNivel3
            // 
            this.btnNivel3.Location = new System.Drawing.Point(120, 281);
            this.btnNivel3.Name = "btnNivel3";
            this.btnNivel3.Size = new System.Drawing.Size(139, 23);
            this.btnNivel3.TabIndex = 15;
            this.btnNivel3.Text = "Nivel 3";
            this.btnNivel3.UseVisualStyleBackColor = true;
            // 
            // btnNivel4
            // 
            this.btnNivel4.Location = new System.Drawing.Point(120, 319);
            this.btnNivel4.Name = "btnNivel4";
            this.btnNivel4.Size = new System.Drawing.Size(139, 23);
            this.btnNivel4.TabIndex = 16;
            this.btnNivel4.Text = "Nivel 4";
            this.btnNivel4.UseVisualStyleBackColor = true;
            // 
            // btnNivel5
            // 
            this.btnNivel5.Location = new System.Drawing.Point(120, 357);
            this.btnNivel5.Name = "btnNivel5";
            this.btnNivel5.Size = new System.Drawing.Size(139, 23);
            this.btnNivel5.TabIndex = 17;
            this.btnNivel5.Text = "Nivel 5";
            this.btnNivel5.UseVisualStyleBackColor = true;
            // 
            // btnNivel6
            // 
            this.btnNivel6.Location = new System.Drawing.Point(120, 396);
            this.btnNivel6.Name = "btnNivel6";
            this.btnNivel6.Size = new System.Drawing.Size(139, 23);
            this.btnNivel6.TabIndex = 18;
            this.btnNivel6.Text = "Nivel 6";
            this.btnNivel6.UseVisualStyleBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(384, 451);
            this.Controls.Add(this.btnNivel6);
            this.Controls.Add(this.btnNivel5);
            this.Controls.Add(this.btnNivel4);
            this.Controls.Add(this.btnNivel3);
            this.Controls.Add(this.btnNivel2);
            this.Controls.Add(this.btnNivel1);
            this.Controls.Add(this.lblNiveles);
            this.Controls.Add(this.lblSelección);
            this.Controls.Add(this.pctlogoUniversidad);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pctlogoUniversidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pctlogoUniversidad;
        private System.Windows.Forms.Label lblSelección;
        private System.Windows.Forms.Label lblNiveles;
        private System.Windows.Forms.Button btnNivel1;
        private System.Windows.Forms.Button btnNivel2;
        private System.Windows.Forms.Button btnNivel3;
        private System.Windows.Forms.Button btnNivel4;
        private System.Windows.Forms.Button btnNivel5;
        private System.Windows.Forms.Button btnNivel6;
    }
}