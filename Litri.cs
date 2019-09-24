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
    public partial class Litri : Form
    {
        public Litri()
        {
            InitializeComponent();
        }

        private void LarghezzaIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void LunghezzaIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Litri_Load(object sender, EventArgs e)
        {

        }

        private void AltezzaIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void Calcola_Click(object sender, EventArgs e)
        {
            try
            {
                int input1 = Convert.ToInt32(LunghezzaIn.Text);
                int input2 = Convert.ToInt32(LarghezzaIn.Text);
                int input3 = Convert.ToInt32(AltezzaIn.Text);

                int Litri = 1000;
                int Somma = (input1 * input2 * input3 / Litri);

                MessageBox.Show("La capienza della vasca è di " + Somma + " lt");


            }
            catch (Exception ex)
            {

            }
        }
    }
    
}
