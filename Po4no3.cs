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
    public partial class Po4no3 : Form
    {
        public Po4no3()
        {
            InitializeComponent();
        }

        private void Po4no3_Load(object sender, EventArgs e)
        {
            try
            {
                int input1 = Convert.ToInt32(LtVasca.Text);

                int No3 = 10;
                int Somma = (input1 * No3);

                MessageBox.Show("Hai un rapporto PO4/No3 di " + Somma);

                if (Somma < 0)
                {
                    MessageBox.Show("La quantita di no3 da mantenere è " + Somma);
                }
                else if (Somma == 10)
                {
                    MessageBox.Show("Hai il giusto rapporto ");
                }
                else if (Somma > 11 && Somma < 30)
                {
                    MessageBox.Show("Con questa concentrazione di no3 rischi le alghe");
                }

                if (Somma > 40)
                {
                    MessageBox.Show("Valore mg/lt troppo elevato, fare cambio urgente del 30% e misurare di nuovo i valori di NO3 e PO4 in vasca");
                }


            }
            catch (Exception ex)
            {

            }
        }
    }
}
