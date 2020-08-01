namespace ProgettoPOIS
{
    partial class Menù
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menù));
            this.IniziaPartita = new System.Windows.Forms.Button();
            this.Istruzioni = new System.Windows.Forms.Button();
            this.Esci = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IniziaPartita
            // 
            this.IniziaPartita.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.IniziaPartita.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IniziaPartita.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IniziaPartita.Location = new System.Drawing.Point(460, 65);
            this.IniziaPartita.Name = "IniziaPartita";
            this.IniziaPartita.Size = new System.Drawing.Size(315, 105);
            this.IniziaPartita.TabIndex = 0;
            this.IniziaPartita.Text = "Inizia Partita";
            this.IniziaPartita.UseVisualStyleBackColor = false;
            this.IniziaPartita.Click += new System.EventHandler(this.IniziaPartita_Click);
            // 
            // Istruzioni
            // 
            this.Istruzioni.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Istruzioni.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Istruzioni.Location = new System.Drawing.Point(460, 274);
            this.Istruzioni.Name = "Istruzioni";
            this.Istruzioni.Size = new System.Drawing.Size(315, 105);
            this.Istruzioni.TabIndex = 1;
            this.Istruzioni.Text = "Istruzioni";
            this.Istruzioni.UseVisualStyleBackColor = false;
            this.Istruzioni.Click += new System.EventHandler(this.Istruzioni_Click);
            // 
            // Esci
            // 
            this.Esci.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Esci.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Esci.Location = new System.Drawing.Point(461, 490);
            this.Esci.Name = "Esci";
            this.Esci.Size = new System.Drawing.Size(315, 105);
            this.Esci.TabIndex = 2;
            this.Esci.Text = "Esci";
            this.Esci.UseVisualStyleBackColor = false;
            this.Esci.Click += new System.EventHandler(this.Esci_Click);
            // 
            // Menù
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.Esci);
            this.Controls.Add(this.Istruzioni);
            this.Controls.Add(this.IniziaPartita);
            this.Name = "Menù";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menù";
            this.Load += new System.EventHandler(this.Menù_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IniziaPartita;
        private System.Windows.Forms.Button Istruzioni;
        private System.Windows.Forms.Button Esci;
    }
}