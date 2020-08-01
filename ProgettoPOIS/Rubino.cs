using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPOIS
{
    class Rubino : Gemma
    {
        private PictureBox rubino;
        private Random rnd; //usato per generare casualmente la posizione

        //cotruttore
        public Rubino(SchermataPrincipale form, PictureBox img) : base(form)
        {
            this.form = form;
            rnd = new Random();
            this.rubino = new PictureBox()
            {
                Width = img.Width,
                Height = img.Height,
                Visible = true,
                Image = img.Image,
                Left = rnd.Next(0,400),
                Top = rnd.Next(210,350),
                BackColor = Color.Transparent,
                Tag = "Rubino"
            };

            form.Controls.Add(rubino);
        }


        //override del metodo Effetto()
        //diminuisce la velocità della pallina se è stata aumentata precedentemente
        public override void Effetto()
        {
            Palla.AumentoVelocità = 0;

        }//fine metodo Effetto()

    }
}

