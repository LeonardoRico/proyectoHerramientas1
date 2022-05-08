
namespace proyectoSemestre
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.lnkAtras = new System.Windows.Forms.LinkLabel();
            this.lblNiveles = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pctlogoUniversidad = new System.Windows.Forms.PictureBox();
            this.btnGestAmb = new System.Windows.Forms.Button();
            this.btnConstiPartiCiu = new System.Windows.Forms.Button();
            this.btnMatemOper = new System.Windows.Forms.Button();
            this.btnEstrucDat = new System.Windows.Forms.Button();
            this.btnElectroBas = new System.Windows.Forms.Button();
            this.btnHerramProgI = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctlogoUniversidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lnkAtras
            // 
            this.lnkAtras.ActiveLinkColor = System.Drawing.Color.Black;
            this.lnkAtras.AutoSize = true;
            this.lnkAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnkAtras.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkAtras.LinkColor = System.Drawing.Color.Black;
            this.lnkAtras.Location = new System.Drawing.Point(160, 100);
            this.lnkAtras.Name = "lnkAtras";
            this.lnkAtras.Size = new System.Drawing.Size(43, 13);
            this.lnkAtras.TabIndex = 110;
            this.lnkAtras.TabStop = true;
            this.lnkAtras.Text = "<- Atrás";
            this.lnkAtras.VisitedLinkColor = System.Drawing.Color.Black;
            this.lnkAtras.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAtras_LinkClicked);
            // 
            // lblNiveles
            // 
            this.lblNiveles.BackColor = System.Drawing.Color.PowderBlue;
            this.lblNiveles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiveles.ForeColor = System.Drawing.Color.White;
            this.lblNiveles.Location = new System.Drawing.Point(2, 128);
            this.lblNiveles.Name = "lblNiveles";
            this.lblNiveles.Size = new System.Drawing.Size(379, 23);
            this.lblNiveles.TabIndex = 109;
            this.lblNiveles.Text = "NIVEL 2";
            this.lblNiveles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.PowderBlue;
            this.panel3.Controls.Add(this.pctlogoUniversidad);
            this.panel3.Location = new System.Drawing.Point(1, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 87);
            this.panel3.TabIndex = 108;
            // 
            // pctlogoUniversidad
            // 
            this.pctlogoUniversidad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctlogoUniversidad.BackgroundImage")));
            this.pctlogoUniversidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctlogoUniversidad.Location = new System.Drawing.Point(32, 11);
            this.pctlogoUniversidad.Name = "pctlogoUniversidad";
            this.pctlogoUniversidad.Size = new System.Drawing.Size(298, 64);
            this.pctlogoUniversidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pctlogoUniversidad.TabIndex = 64;
            this.pctlogoUniversidad.TabStop = false;
            // 
            // btnGestAmb
            // 
            this.btnGestAmb.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestAmb.Location = new System.Drawing.Point(96, 394);
            this.btnGestAmb.Name = "btnGestAmb";
            this.btnGestAmb.Size = new System.Drawing.Size(190, 34);
            this.btnGestAmb.TabIndex = 107;
            this.btnGestAmb.Text = "GESTION AMBIENTAL";
            this.btnGestAmb.UseVisualStyleBackColor = true;
            this.btnGestAmb.Click += new System.EventHandler(this.btnGestAmb_Click);
            // 
            // btnConstiPartiCiu
            // 
            this.btnConstiPartiCiu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConstiPartiCiu.Location = new System.Drawing.Point(96, 350);
            this.btnConstiPartiCiu.Name = "btnConstiPartiCiu";
            this.btnConstiPartiCiu.Size = new System.Drawing.Size(190, 34);
            this.btnConstiPartiCiu.TabIndex = 106;
            this.btnConstiPartiCiu.Text = "CONSTITUCION Y PARTICIPACION CIUDADANA";
            this.btnConstiPartiCiu.UseVisualStyleBackColor = true;
            this.btnConstiPartiCiu.Click += new System.EventHandler(this.btnConstiPartiCiu_Click);
            // 
            // btnMatemOper
            // 
            this.btnMatemOper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMatemOper.Location = new System.Drawing.Point(96, 306);
            this.btnMatemOper.Name = "btnMatemOper";
            this.btnMatemOper.Size = new System.Drawing.Size(190, 34);
            this.btnMatemOper.TabIndex = 105;
            this.btnMatemOper.Text = "MATEMATICAS OPERATIVAS";
            this.btnMatemOper.UseVisualStyleBackColor = true;
            this.btnMatemOper.Click += new System.EventHandler(this.btnMatemOper_Click);
            // 
            // btnEstrucDat
            // 
            this.btnEstrucDat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstrucDat.Location = new System.Drawing.Point(96, 262);
            this.btnEstrucDat.Name = "btnEstrucDat";
            this.btnEstrucDat.Size = new System.Drawing.Size(190, 34);
            this.btnEstrucDat.TabIndex = 104;
            this.btnEstrucDat.Text = "ESTRUCTURA DE DATOS";
            this.btnEstrucDat.UseVisualStyleBackColor = true;
            this.btnEstrucDat.Click += new System.EventHandler(this.btnEstrucDat_Click);
            // 
            // btnElectroBas
            // 
            this.btnElectroBas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElectroBas.Location = new System.Drawing.Point(96, 218);
            this.btnElectroBas.Name = "btnElectroBas";
            this.btnElectroBas.Size = new System.Drawing.Size(190, 34);
            this.btnElectroBas.TabIndex = 103;
            this.btnElectroBas.Text = "ELECTRONICA BASICA";
            this.btnElectroBas.UseVisualStyleBackColor = true;
            this.btnElectroBas.Click += new System.EventHandler(this.btnElectroBas_Click);
            // 
            // btnHerramProgI
            // 
            this.btnHerramProgI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHerramProgI.Location = new System.Drawing.Point(96, 174);
            this.btnHerramProgI.Name = "btnHerramProgI";
            this.btnHerramProgI.Size = new System.Drawing.Size(190, 34);
            this.btnHerramProgI.TabIndex = 102;
            this.btnHerramProgI.Text = "HERRAMIENTAS DE PROGRAMACION I";
            this.btnHerramProgI.UseVisualStyleBackColor = true;
            this.btnHerramProgI.Click += new System.EventHandler(this.btnHerramProgI_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 451);
            this.Controls.Add(this.lnkAtras);
            this.Controls.Add(this.lblNiveles);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnGestAmb);
            this.Controls.Add(this.btnConstiPartiCiu);
            this.Controls.Add(this.btnMatemOper);
            this.Controls.Add(this.btnEstrucDat);
            this.Controls.Add(this.btnElectroBas);
            this.Controls.Add(this.btnHerramProgI);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctlogoUniversidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lnkAtras;
        private System.Windows.Forms.Label lblNiveles;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pctlogoUniversidad;
        private System.Windows.Forms.Button btnGestAmb;
        private System.Windows.Forms.Button btnConstiPartiCiu;
        private System.Windows.Forms.Button btnMatemOper;
        private System.Windows.Forms.Button btnEstrucDat;
        private System.Windows.Forms.Button btnElectroBas;
        private System.Windows.Forms.Button btnHerramProgI;
    }
}