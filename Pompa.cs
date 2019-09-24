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
    public partial class Pompa : Form
    {
        public Pompa()
        {
            InitializeComponent();
        }

        private void Calcola_Click(object sender, EventArgs e)
        {
            try
            {
                int input1 = Convert.ToInt32(Ltins.Text);

                int Velocita = 4;
                int Somma = (input1 / Velocita);

                MessageBox.Show("Hai bisogno di una pompa con una velocità di " + Somma + " l/h per una circolazione ottimale");

            }
            catch (Exception ex)
            {

            }
        }
    }
}
