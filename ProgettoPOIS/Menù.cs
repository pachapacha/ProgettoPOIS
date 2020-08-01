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
    public partial class Menù : Form
    {
        public Menù()
        {
            InitializeComponent();
        }

        private void IniziaPartita_Click(object sender, EventArgs e)
        {
            this.Hide();
            SchermataPrincipale schermataPrincipale = new SchermataPrincipale();
            schermataPrincipale.ShowDialog();
            this.Close();

        }

        private void Menù_Load(object sender, EventArgs e)
        {

        }

        private void Esci_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Istruzioni_Click(object sender, EventArgs e)
        {
            this.Hide();
            Istruzioni istruzioni = new Istruzioni();
            istruzioni.ShowDialog();
            this.Close();
        }
    }
}
