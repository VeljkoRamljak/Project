using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BikeSharing
{
    public partial class Pocetna : Form
    {
        public Pocetna()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NovaVoznja f3 = new NovaVoznja(); // Instantiate a Form3 object.
            f3.Show(); // Show Form3 and
            //this.Close();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            NoviKorisnik f4 = new NoviKorisnik(); // Instantiate a Form3 object.
            f4.Show(); // Show Form3 and
        }

        private void modeli_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            NoviTerminal fterm = new NoviTerminal(); // Instantiate a Form3 object.
            fterm.Show(); // Show Form3 and
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            NovoBiciklo fbiciklo = new NovoBiciklo(); // Instantiate a Form3 object.
            fbiciklo.Show(); // Show Form3 and
        }
    }
}
