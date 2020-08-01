using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPOIS
{
    public class AstronaveInferiore : Astronave
    {

        //costruttore
        public AstronaveInferiore(SchermataPrincipale form) : base(form)
        {
        }

        //override del metodo Inizializza()
        public override void Inizializza()
        {
            for (int i = 0; i < 3; i++)
            {
                ComponenteAstronave.Add(new PictureBox()
                {
                    BackColor = Color.LawnGreen,
                    Height = 12,
                    Visible = true,
                    Width = 80,
                    Top = form.ClientSize.Height - 12,
                    Left = (form.ClientSize.Width - 80) / 2
                });

                // se prendiamo in considerazione la parte sinistra dell'astronave allora la sua locazione è questa
                if (i == 0)
                    ComponenteAstronave[i].Left -= 80;

                // se prendiamo in considerazione la parte destra dell'astronave allora la sua locazione è questa
                if (i == 2)
                    ComponenteAstronave[i].Left += 80;

                form.Controls.Add(ComponenteAstronave[i]);
            }

        }//fine metodo Inizializza()




    }

}
