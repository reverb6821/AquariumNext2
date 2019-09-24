using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquariumNext2._0
{
    public partial class Illuminazione : Form
    {
        public Illuminazione()
        {
            InitializeComponent();
        }

        private void InsLt1_TextChanged(object sender, EventArgs e)
        {

        }

        // Calcola i watt
        private void CalcolaWatt_Click(object sender, EventArgs e)
        {
            float input1 = Convert.ToInt32(InsWatt.Text);
            float input2 = Convert.ToInt32(insLt1.Text);

            float Somma = (input1 / input2);

            MessageBox.Show("Hai un rapporto Watt/lt pari a " + Somma);

            if (Somma <= 0.3)
            {
                MessageBox.Show("il wattaggio è debole ");
            }
            else if (Somma > 0.3 && Somma < 0.7)
            {
                MessageBox.Show("il wattaggio è medio ");
            }
            if (Somma >= 0.7)
                MessageBox.Show("il wattaggio è alto ");
        }
        //Calcola lumen
        private void CalcoloLumen_Click(object sender, EventArgs e)
        {
            float input1 = Convert.ToInt32(InsLumen.Text);
            float input2 = Convert.ToInt32(insLt2.Text);

            float Somma = (input1 / input2);

            MessageBox.Show("Hai un rapporto Lumen/lt pari a " + Somma);

            if (Somma <= 40)
            {
                MessageBox.Show("lumen minimo ");
            }
            else if (Somma > 40 && Somma < 60)
            {
                MessageBox.Show("lumen medio ");
            }
            if (Somma >= 60)
            {
                MessageBox.Show("lumen alto ");
            }
        }
    }
}
