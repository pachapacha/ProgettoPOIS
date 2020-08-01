using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPOIS
{
    public class Palla
    {
        private int velocitàX;
        private int velocitàY;
        public static int AumentoVelocità { get; set; }
        private PictureBox palla;
        private SchermataPrincipale form;
        private AstronaveInferiore astronaveInferiore;
        private AstronaveSuperiore astronaveSuperiore;
        private bool intersezioneSmeraldo;
        private bool intersezioneRubino;
        private bool intersezioneAmetista;
        private bool nascosto;



        //costruttore
        public Palla(SchermataPrincipale form, PictureBox img, AstronaveInferiore astronaveInferiore, AstronaveSuperiore astronaveSuperiore)
        {
            this.form = form;
            AumentoVelocità = 0;
            velocitàX = 6;
            velocitàY = 6;
            this.astronaveInferiore = astronaveInferiore;
            this.astronaveSuperiore = astronaveSuperiore;
            this.palla = new PictureBox()
            {
                Width = img.Width,
                Height = img.Height,
                Visible = false,
                Image = img.Image,
                Left = 640,
                Top = 640,
                Tag = "Palla",
                BackColor = Color.Transparent

            };

            form.Controls.Add(palla);
        }//fine costruttore

        //definizione metodo MovimentoPalla()
        public void MovimentoPalla()
        {
            if (velocitàX < 0)
            {
                palla.Left += velocitàX - AumentoVelocità;
            }
            else if (velocitàX > 0)
            {
                palla.Left += velocitàX + AumentoVelocità;
            }

            if (velocitàY < 0)
            {
                palla.Top += velocitàY - AumentoVelocità;
            }
            else if (velocitàY > 0)
            {
                palla.Top += velocitàY + AumentoVelocità;
            }


            if (form.Controls.OfType<PictureBox>().Where(t => (string)t.Tag == "Ametista").Count() == 0)
            {
                intersezioneAmetista = false;
            }


            if (form.Controls.OfType<PictureBox>().Where(t => (string)t.Tag == "Smeraldo").Count() == 0)
            {
                intersezioneSmeraldo = false;
            }

            if (form.Controls.OfType<PictureBox>().Where(t => (string)t.Tag == "Rubino").Count() == 0)
            {
                intersezioneRubino = false;
            }

            //intersezione con un mattoncino
            foreach (var item in form.Controls.OfType<PictureBox>().Where(t => (string)t.Tag == "Mattone"))
            {
                if (palla.Bounds.IntersectsWith(item.Bounds))
                {
                    if (Punteggio.OttieniPunteggio <= 150)
                    {
                        form.Controls.Remove(item);
                        velocitàY *= -1;
                        Punteggio.CalcolaMattoni();
                    }
                    else if (Punteggio.OttieniPunteggio > 150)
                    {
                        item.Tag = "MattoneRes1";
                        if (velocitàY > 0)
                        {
                            palla.Top -= 10;
                            velocitàY *= -1;
                        }
                        else
                        {
                            palla.Top += 10;
                            velocitàY *= -1;
                        }
                    }

                }
            
            }

            //intersezione con mattoncino con resistenza 1
            foreach (var item in form.Controls.OfType<PictureBox>().Where(t => (string)t.Tag == "MattoneRes1"))
            {
                if (palla.Bounds.IntersectsWith(item.Bounds))
                {
                    if (Punteggio.OttieniPunteggio <= 300)
                    {
                        form.Controls.Remove(item);
                        velocitàY *= -1;
                        Punteggio.CalcolaMattoni();
                    }
                    else if(Punteggio.OttieniPunteggio > 300)
                    {
                        item.Tag = "MattoneRes2";
                        if (velocitàY > 0)
                        {
                            palla.Top -= 10;
                            velocitàY *= -1;
                        }
                        else
                        {
                            palla.Top += 10;
                            velocitàY *= -1;
                        }
                    }
                }
          
            }

            //intersezione con un mattoncino con resistenza 2
            foreach (var item in form.Controls.OfType<PictureBox>().Where(t => (string)t.Tag == "MattoneRes2"))
            {
                if (palla.Bounds.IntersectsWith(item.Bounds))
                {
                        form.Controls.Remove(item);
                        velocitàY *= -1;
                        Punteggio.CalcolaMattoni();
                }

            }

            //intersezione con gemma smeraldo
            foreach (var item in form.Controls.OfType<PictureBox>().Where(t => (string)t.Tag == "Smeraldo"))
            {
                if (palla.Bounds.IntersectsWith(item.Bounds))
                {
                    intersezioneSmeraldo = true;
                    form.Controls.Remove(item);
                    velocitàY *= -1;
                    Punteggio.CalcolaGemme();
                }
            }

            //intersezione con gemma rubino
            foreach (var item in form.Controls.OfType<PictureBox>().Where(t => (string)t.Tag == "Rubino"))
            {
                if (palla.Bounds.IntersectsWith(item.Bounds))
                {
                    intersezioneRubino = true;
                    form.Controls.Remove(item);
                    velocitàY *= -1;
                    Punteggio.CalcolaGemme();
                }
            }

            //intersezione con gemma ametista
            foreach (var item in form.Controls.OfType<PictureBox>().Where(t => (string)t.Tag == "Ametista"))
            {
                if (palla.Bounds.IntersectsWith(item.Bounds))
                {
                    intersezioneAmetista = true;
                    form.Controls.Remove(item);
                    velocitàY *= -1;
                    Punteggio.CalcolaGemme();
                }
            }


            //la palla colpisce l'astronave inferiore opppure quella superiore nella parte sinistra
            if ((palla.Bounds.IntersectsWith(astronaveInferiore.ComponenteAstronave[0].Bounds)) || (palla.Bounds.IntersectsWith(astronaveSuperiore.ComponenteAstronave[0].Bounds)))
            {
                velocitàY = -velocitàY;
                if (velocitàX == 0) // se la palla ha appena colpito la parte centrale e si accinge a colpire la parte sinistra
                { 
                    velocitàX = -6 - AumentoVelocità;
                }
                else
                {
                    velocitàX = Math.Abs(velocitàX) * -1;
                }
            }
            //la palla colpisce l'astronave inferiore oppure quella superiore nella parte destra
            else if ((palla.Bounds.IntersectsWith(astronaveInferiore.ComponenteAstronave[2].Bounds)) || (palla.Bounds.IntersectsWith(astronaveSuperiore.ComponenteAstronave[2].Bounds)))
            {
                velocitàY = -velocitàY;
                if (velocitàX == 0) // se la palla ha appena colpito la parte centrale e si accinge a colpire la parte destra
                {
                    velocitàX = 6 + AumentoVelocità;
                }
                else
                {
                    velocitàX = Math.Abs(velocitàX);
                }
            }
            //la palla colpisce l'astronave inferiore oppure quella superiore nella parte centrale
            else if ((palla.Bounds.IntersectsWith(astronaveInferiore.ComponenteAstronave[1].Bounds)) || (palla.Bounds.IntersectsWith(astronaveSuperiore.ComponenteAstronave[1].Bounds)))
            {
                velocitàY = -velocitàY;
                velocitàX = 0;
            }
            //la palla non viene salvata dall'astronave
            else if ((palla.Bottom >= form.ClientSize.Height) || (palla.Top <= 0))
            {
                if (SchermataPrincipale.NumPalle == 1)
                {
                    Punteggio.Vite -= 1;
                }
                else if (SchermataPrincipale.NumPalle == 2)
                {
                    nascosto = true;
                    velocitàX = 0;
                    velocitàY = 0;
                    SchermataPrincipale.NumPalle = 1;
                }

                //rigenerazione al centro del form
                palla.Left = (form.ClientSize.Width - palla.Width) / 2;
                palla.Top = (form.ClientSize.Height - palla.Height) / 2;

            }
            //la palla colpisce le parti laterali del form
            else if (palla.Left <= 0 || palla.Right >= form.ClientSize.Width)
            {
                velocitàX *= -1;
            }


        }//fine metodo MovimentoPalla()

        //definizione metodo SmeraldoColpito()
        public bool SmeraldoColpito()
        {
            if(intersezioneSmeraldo == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//fine metodo SmeraldoColpito()

        //definizione metodo RubinoColpito()
        public bool RubinoColpito()
        {
            if(intersezioneRubino == true)
            {
                return true;

            }
            else
            {
                return false;
            }
        }//fine metodo RubinoColpito()

        //definizione metodo AmetistaColpito()
        public bool AmetistaColpito()
        {
            if (intersezioneAmetista == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//fine metodo AmetistaColpito()

        //definizione metodo RendiVisibile()
        public void RendiVisibile()
        {
            if (nascosto == false)
            {
                palla.Visible = true;
            }
            else if (nascosto == true)
            {
                palla.Visible = false;
            }
        }//fine metodo RendiVisibile()

        //definizione metodo Posiziona()
        public void Posiziona()
        {
             palla.Left = 640;
             palla.Top = 250;

        }//fine metodo Posiziona()

    }
}
