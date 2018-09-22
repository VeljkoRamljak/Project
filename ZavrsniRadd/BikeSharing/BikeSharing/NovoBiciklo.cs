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
    public partial class NovoBiciklo : Form
    {
        public NovoBiciklo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("uspješno dodan novo biciklo!");
        }

        private void NovoBiciklo_Load(object sender, EventArgs e)
        {

        }
    }
}
