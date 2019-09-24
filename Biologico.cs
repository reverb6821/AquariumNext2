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
    public partial class Biologico : Form
    {
        public Biologico()
        {
            InitializeComponent();
        }

        private void BunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }

        private void Calcola_Click(object sender, EventArgs e)
        {
            try
            {
                int input1 = Convert.ToInt32(insLt.Text);

                int Bio = 10;
                int Somma = (input1 / Bio);

                MessageBox.Show("Per un ottimale filtraggio biologico hai bisogno di " + Somma + " gr di materiale biologico");

            }
            catch (Exception ex)
            {
            }
        }
    }
}
