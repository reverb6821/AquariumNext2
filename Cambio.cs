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
    public partial class Cambio : Form
    {
        public Cambio()
        {
            InitializeComponent();
        }

        private void Calcola_Click(object sender, EventArgs e)
        {
            try
            {
                float input1 = Convert.ToInt32(LtCambio.Text);
                float input2 = Convert.ToInt32(Khru.Text);
                float input3 = Convert.ToInt32(Ghru.Text);
                float input4 = Convert.ToInt32(Khdes.Text);


                float Somma = ((input1 / input2) * input4);
                float Ghsomma = ((input3 / input1) * Somma);

                MessageBox.Show(" Devi usare " + Somma + " lt di acqua di rubinetto su " + input1 + " lt di osmosi, e il gH sarà di " + Ghsomma);


            }
            catch (Exception)
            {

            }
        }
    }
}
