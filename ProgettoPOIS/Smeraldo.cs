using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPOIS
{
    public class Smeraldo : Gemma
    {
        private PictureBox smeraldo;
        public bool NotificaForm { get; set; }

        //cotruttore
        public Smeraldo(SchermataPrincipale form, PictureBox img) : base(form)
        {
            this.form = form;
            this.smeraldo = new PictureBox()
            {
                Width = img.Width,
                Height = img.Height,
                Visible = true,
                Image = img.Image,
                Left = 640,
                Top = 250,
                BackColor = Color.Transparent,
                Tag = "Smeraldo"
            };

            form.Controls.Add(smeraldo);
        }//fine costruttore

        
        //override del metodo Effetto()
        //avverte il form di mettere in gioco un'altra pallina
        public override void Effetto()
        {
            NotificaForm = true;

        }//fine metodo Effetto()


    }
}
