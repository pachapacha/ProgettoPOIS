namespace ProgettoPOIS
{
    partial class SchermataPrincipale
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchermataPrincipale));
            this.imgPalla = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.imgSmeraldo = new System.Windows.Forms.PictureBox();
            this.imgRubino = new System.Windows.Forms.PictureBox();
            this.imgAmetista = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgPalla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSmeraldo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRubino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAmetista)).BeginInit();
            this.SuspendLayout();
            // 
            // imgPalla
            // 
            this.imgPalla.BackColor = System.Drawing.Color.Transparent;
            this.imgPalla.Image = ((System.Drawing.Image)(resources.GetObject("imgPalla.Image")));
            this.imgPalla.Location = new System.Drawing.Point(149, 255);
            this.imgPalla.Name = "imgPalla";
            this.imgPalla.Size = new System.Drawing.Size(16, 16);
            this.imgPalla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgPalla.TabIndex = 0;
            this.imgPalla.TabStop = false;
            this.imgPalla.Visible = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.TimerTick);
            // 
            // imgSmeraldo
            // 
            this.imgSmeraldo.BackColor = System.Drawing.Color.Transparent;
            this.imgSmeraldo.Image = ((System.Drawing.Image)(resources.GetObject("imgSmeraldo.Image")));
            this.imgSmeraldo.Location = new System.Drawing.Point(771, 310);
            this.imgSmeraldo.Name = "imgSmeraldo";
            this.imgSmeraldo.Size = new System.Drawing.Size(60, 60);
            this.imgSmeraldo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgSmeraldo.TabIndex = 1;
            this.imgSmeraldo.TabStop = false;
            this.imgSmeraldo.Visible = false;
            // 
            // imgRubino
            // 
            this.imgRubino.BackColor = System.Drawing.Color.Transparent;
            this.imgRubino.Image = ((System.Drawing.Image)(resources.GetObject("imgRubino.Image")));
            this.imgRubino.Location = new System.Drawing.Point(771, 69);
            this.imgRubino.Name = "imgRubino";
            this.imgRubino.Size = new System.Drawing.Size(60, 60);
            this.imgRubino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgRubino.TabIndex = 2;
            this.imgRubino.TabStop = false;
            this.imgRubino.Visible = false;
            // 
            // imgAmetista
            // 
            this.imgAmetista.BackColor = System.Drawing.Color.Transparent;
            this.imgAmetista.Image = ((System.Drawing.Image)(resources.GetObject("imgAmetista.Image")));
            this.imgAmetista.Location = new System.Drawing.Point(495, 277);
            this.imgAmetista.Name = "imgAmetista";
            this.imgAmetista.Size = new System.Drawing.Size(60, 60);
            this.imgAmetista.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.imgAmetista.TabIndex = 3;
            this.imgAmetista.TabStop = false;
            this.imgAmetista.Visible = false;
            // 
            // SchermataPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.imgAmetista);
            this.Controls.Add(this.imgRubino);
            this.Controls.Add(this.imgSmeraldo);
            this.Controls.Add(this.imgPalla);
            this.Name = "SchermataPrincipale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgettoPOIS";
            this.Load += new System.EventHandler(this.SchermataPrincipale_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InputTastiera);
            ((System.ComponentModel.ISupportInitialize)(this.imgPalla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSmeraldo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgRubino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgAmetista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgPalla;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox imgSmeraldo;
        private System.Windows.Forms.PictureBox imgRubino;
        private System.Windows.Forms.PictureBox imgAmetista;
    }
}

