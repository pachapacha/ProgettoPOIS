using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPOIS
{
    public abstract class Astronave
    {
        private int velocità;
        public List<PictureBox> ComponenteAstronave { get; set; }
        protected SchermataPrincipale form;

        //costruttore
        public Astronave(SchermataPrincipale form)
        {
            this.form = form;
            velocità = 50;
            ComponenteAstronave = new List<PictureBox>();
            Inizializza();

        }//fine costruttore

        //metodo astratto su cui verrà fatto override
        public abstract void Inizializza();

        //definizione metodo Movimento()
        public void Movimento(KeyEventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (e.KeyCode == Keys.Left)
                    ComponenteAstronave[i].Left -= velocità;

                if (e.KeyCode == Keys.Right)
                    ComponenteAstronave[i].Left += velocità;
            }

            ControlloBordo();

        }//fine metodo Movimento()

        //definizione metodo ControlloBordo
        private void ControlloBordo()
        {
            //se si arriva ai bordi vengono ridefinite le posizioni delle componenti dell'astronave
            if (ComponenteAstronave[0].Left <= 0)
            {
                ComponenteAstronave[0].Left = 0;
                ComponenteAstronave[1].Left = ComponenteAstronave[0].Width;
                ComponenteAstronave[2].Left = ComponenteAstronave[0].Width + ComponenteAstronave[1].Width;
            }
            else if (ComponenteAstronave[2].Right >= form.ClientSize.Width)
            {
                ComponenteAstronave[0].Left = form.ClientSize.Width - ComponenteAstronave[0].Width - ComponenteAstronave[1].Width - ComponenteAstronave[2].Width;
                ComponenteAstronave[1].Left = form.ClientSize.Width - ComponenteAstronave[1].Width - ComponenteAstronave[2].Width;
                ComponenteAstronave[2].Left = form.ClientSize.Width - ComponenteAstronave[2].Width;
            }

        }//fine metodo ControllaBordo()

    }
}
