using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPOIS
{
    public partial class SchermataPrincipale : Form
    {
        private List<Mattone> mattoni;
        private AstronaveInferiore astronaveInferiore;
        private AstronaveSuperiore astronaveSuperiore;
        private Palla palla;
        private Smeraldo smeraldo;
        private Palla pallaBonus;
        private Rubino rubino;
        private Ametista ametista;
        private int ricRubino;
        public static int NumPalle { get; set; } = 1;

        public SchermataPrincipale()
        {
            InitializeComponent();
            mattoni = new List<Mattone>();
            astronaveInferiore = new AstronaveInferiore(this);
            astronaveSuperiore = new AstronaveSuperiore(this);
            palla = new Palla(this, imgPalla, astronaveInferiore, astronaveSuperiore);
            smeraldo = new Smeraldo(this,imgSmeraldo);
            pallaBonus = new Palla(this, imgPalla, astronaveInferiore, astronaveSuperiore);
            pallaBonus.Posiziona();
            rubino = new Rubino(this, imgRubino);
            ametista = new Ametista(this, imgAmetista);
        }

        private void SchermataPrincipale_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 30; i++)
            {
                mattoni.Add(new Mattone(this));
            }

        }

        private void InputTastiera(object sender, KeyEventArgs e)
        {
            astronaveInferiore.Movimento(e);
            astronaveSuperiore.Movimento(e);
        }

        private void TimerTick(object sender, EventArgs e)
        {
            palla.RendiVisibile();
            palla.MovimentoPalla();

           //se la palla colpissce la gemma smeraldo
            if(palla.SmeraldoColpito() == true)
            {
                smeraldo.Effetto();
                NumPalle = 2;
            }

            //viene messa in gioco un'altra pallina 
            if(smeraldo.NotificaForm == true)
            {
                pallaBonus.RendiVisibile();
                pallaBonus.MovimentoPalla();
  
            }

            //se la palla colpisce la gemma rubino
            if(palla.RubinoColpito() == true || pallaBonus.RubinoColpito() == true)
            {
                rubino.Effetto();
                ricRubino = Punteggio.OttieniPunteggio;
            } 
           
            //se la palla colpisce la gemma ametista
            if (palla.AmetistaColpito() == true || pallaBonus.AmetistaColpito() == true)
            {
                ametista.Effetto();
            }

            //notifica punteggio e vite rimaste 
            this.Text = "Punteggio " + Punteggio.OttieniPunteggio + "   Vite " + Punteggio.Vite;


            //aumento velocità della pallina tenendo conto del punteggio e dell'intersezione con la gemma rubino
            if (Punteggio.OttieniPunteggio > 50 && Punteggio.OttieniPunteggio <= 150 && ricRubino == 0)
            {
                Palla.AumentoVelocità = 2;
            }
            else if (Punteggio.OttieniPunteggio > 150 && Punteggio.OttieniPunteggio <= 300 && ricRubino == 0)
            {
                Palla.AumentoVelocità = 4;

            }
            else if (Punteggio.OttieniPunteggio > 300 && ricRubino == 0)
            {
                Palla.AumentoVelocità = 6;
            }
            else if (ricRubino > 0)
            {
                if(Punteggio.OttieniPunteggio - ricRubino > 50 && Punteggio.OttieniPunteggio - ricRubino <= 100)
                {
                    Palla.AumentoVelocità = 2;
                }
                else if (Punteggio.OttieniPunteggio - ricRubino > 100 && Punteggio.OttieniPunteggio - ricRubino <= 150)
                {
                    Palla.AumentoVelocità = 4;
                }
                else if (Punteggio.OttieniPunteggio - ricRubino > 150)
                {
                    Palla.AumentoVelocità = 6;
                }
            }

            //se si esauriscono le vite
            if(Punteggio.Vite == 0)
            {
                timer.Enabled = false;
                if ((MessageBox.Show("Hai totalizzato " + Punteggio.OttieniPunteggio + " punti\nVuoi ritonare nel menù?", "Game Over", MessageBoxButtons.YesNo)) ==
                DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    this.Close();
                }

            }

            //sono stati distrutti tutti i mattoncini e le gemme presenti
            if (Punteggio.OttieniPunteggio == 450)
            {
                timer.Enabled = false;
                if ((MessageBox.Show("Bravo hai vinto !!!\nVuoi ritonare nel menù?", "Game Over", MessageBoxButtons.YesNo)) ==
                DialogResult.Yes)
                {
                    Application.Restart();
                }
                else
                {
                    this.Close();
                }
            }

        }
 

    }
}
