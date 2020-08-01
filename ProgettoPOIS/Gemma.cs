using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPOIS
{
    public abstract class Gemma
    {
        protected SchermataPrincipale form;


        //costruttore 
        public Gemma(SchermataPrincipale form)
        {
            this.form = form;

        }//fine costruttore


        //metodo astratto su cui verrà fatto override
        public abstract void Effetto();
    }
}
