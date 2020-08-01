using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPOIS
{
    public class Mattone
    {
        private Random rnd; //usato per generare casualmente la posizione dei mattoni nel form
        private PictureBox mattone;
        private SchermataPrincipale form;
        private List<PictureBox> mattoni; //lista che contiene tutti i mattoni generati nel form

        //costruttore
        public Mattone(SchermataPrincipale form)
        {
            rnd = new Random();
            this.form = form;
            mattoni = new List<PictureBox>();
            mattone = new PictureBox()
            {
                BackColor = Color.DeepSkyBlue,
                Width = 100,
                Height = 10,
                Tag = "Mattone",
                Visible = true
            };

            Inizializza(); 

        }//fine costruttore

        //definizione metodo inizializza()
        private void Inizializza()
        {
            OttieniMattoni(); // metodo che prende in considerazione tutti i mattoni presenti nel form, necessario per controllare eventuale intersezione
            Posiziona();
            form.Controls.Add(mattone);

        }//fine metodo Inizializza()


        //definizione metodo OttieniMattoni()
        private void OttieniMattoni()
        {
            foreach(var item in form.Controls.OfType<PictureBox>().Where(t => (string)t.Tag == "Mattone"))
            {
                mattoni.Add(item);
            }

        }//fine metodo OttieniMattoni()


        //definizione metodo Posiziona()
        private void Posiziona()
        {
            do
            {
                mattone.Left = rnd.Next(0, 1180);
                mattone.Top = PosizioneVerticale();

            } while (!ControllaIntersezione()); //cicla fino a quando non ottiene una posizione valida 

            mattoni.Add(mattone);

        }//fine metodo Posiziona()


        //definizione metodo ControllaIntersezione()
        private bool ControllaIntersezione()
        {
            for (int i = 0; i < mattoni.Count; i++)
            {
                if (this.mattone.Bounds.IntersectsWith(mattoni[i].Bounds))
                    return false;
            }

            return true;
        }//fine metodo ControllaIntersezione()

        //definizione metodo PosizioneVerticale()
        private int PosizioneVerticale()
        {
            int val;
            if (mattoni.Count < 15)
            {
                val = rnd.Next(150, 200);
            }
            else
            {
                val = rnd.Next(430, 480);
            }

            return val;
        }//fine metodo PosizioneVerticale()


    }
}
