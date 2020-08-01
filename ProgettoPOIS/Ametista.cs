using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPOIS
{
    class Ametista : Gemma
    {
        private PictureBox ametista; //usato per generare casualmente la posizione
        private Random rnd;

        //cotruttore
        public Ametista(SchermataPrincipale form, PictureBox img) : base(form)
        {
            this.form = form;
            rnd = new Random();
            this.ametista = new PictureBox()
            {
                Width = img.Width,
                Height = img.Height,
                Visible = true,
                Image = img.Image,
                Left = rnd.Next(800,1200),
                Top = rnd.Next(210,350),
                BackColor = Color.Transparent,
                Tag = "Ametista"
            };

            form.Controls.Add(ametista);
        }//fine costruttore


        //override del metodo Effetto()
        //l'effetto consiste nell'aggiungere una vita
        public override void Effetto()
        {
            Punteggio.Vite += 1;
            
        }//fine metodo Effetto()


    }
}
