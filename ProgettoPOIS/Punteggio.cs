using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgettoPOIS
{
    class Punteggio
    {
        //uso del design pattern Singleton
        private static Punteggio istanza = null;
        private Punteggio() { }
        public static Punteggio Istanza()
        {
            if (istanza == null)
                istanza = new Punteggio();
            return istanza;
        }

        private static int PunteggioTotale { get; set; }
        public static int OttieniPunteggio { get { return PunteggioTotale; } }
        public static int Vite { get; set; } = 3;

        //definizione metodo CalcolaGemme()
        public static void CalcolaGemme()
        {
            PunteggioTotale += 50;

        }//fine metodo CalcolaGemme()

        //definizione metodo CalcolaMattoni()
        public static void CalcolaMattoni()
        {
            PunteggioTotale += 10;

        }//fine metodo CalcolaMattoni()

    }

}
