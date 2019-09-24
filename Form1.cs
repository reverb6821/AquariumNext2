using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AquariumNext2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Permette di spostare l'app per il desktop
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Novita_Click(object sender, EventArgs e)
        {

        }

        //Tasto esci
        private void Esci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Tasto minimizza
        private void Minimizza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //Barra sopra a tutto
        private void BarraTop_Paint(object sender, PaintEventArgs e)
        {

        }

        //Azione che permette di far spostare l'app con il mouse
        private void BarraTop_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        //Permette di visualizzare ciò che viene aperto tramite il bottone selezionato nel riquadro "Centrale"
        private void ApriFormInPanel(object Forma)
        {
            if (this.Centrale.Controls.Count > 0)
                this.Centrale.Controls.RemoveAt(0);
            Form fh = Forma as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Centrale.Controls.Add(fh);
            this.Centrale.Tag = (fh);
            fh.Show();
        }

        // Calcolatori App
        private void Litri_Click(object sender, EventArgs e)
        {
            ApriFormInPanel(new Litri());
        }

        private void Fondo_Click(object sender, EventArgs e)
        {
            ApriFormInPanel(new Fondocs());
        }

        private void Illuminazione_Click(object sender, EventArgs e)
        {
            ApriFormInPanel(new Illuminazione());
        }

        private void Biologico_Click(object sender, EventArgs e)
        {
            ApriFormInPanel(new Biologico());
        }

        private void Pompa_Click(object sender, EventArgs e)
        {
            ApriFormInPanel(new Pompa());
        }

        private void Po4no3_Click(object sender, EventArgs e)
        {
            ApriFormInPanel(new Po4no3());
        }

        private void Cambio_Click(object sender, EventArgs e)
        {
            ApriFormInPanel(new Cambio());
        }

        private void Fertilizzazione_Click(object sender, EventArgs e)
        {
            
        }

        private void BunifuCustomLabel4_Click(object sender, EventArgs e)
        {

        }

        //Info App
        private void About_Click(object sender, EventArgs e)
        {
            ApriFormInPanel(new About());
        }
    }
}
