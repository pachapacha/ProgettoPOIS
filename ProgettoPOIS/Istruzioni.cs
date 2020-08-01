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
    public partial class Istruzioni : Form
    {
        public Istruzioni()
        {
            InitializeComponent();
        }

        private void RitornaMenù_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menù menù = new Menù();
            menù.ShowDialog();
            this.Close();

        }

        private void Istruzioni_Load(object sender, EventArgs e)
        {

        }
    }
}
