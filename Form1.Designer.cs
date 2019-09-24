namespace AquariumNext2._0
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BarraTop = new System.Windows.Forms.Panel();
            this.MenuLaterale = new System.Windows.Forms.Panel();
            this.Centrale = new System.Windows.Forms.Panel();
            this.Titolo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Esci = new Bunifu.Framework.UI.BunifuImageButton();
            this.Minimizza = new Bunifu.Framework.UI.BunifuImageButton();
            this.Calcolatori = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Litri = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Fondo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Illuminazione = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Biologico = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Pompa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.po4no3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Cambio = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Fertilizzazione = new Bunifu.Framework.UI.BunifuFlatButton();
            this.About = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BarraTop.SuspendLayout();
            this.MenuLaterale.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Esci)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizza)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 2;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BarraTop
            // 
            this.BarraTop.BackColor = System.Drawing.Color.DodgerBlue;
            this.BarraTop.Controls.Add(this.Titolo);
            this.BarraTop.Controls.Add(this.Minimizza);
            this.BarraTop.Controls.Add(this.Esci);
            this.BarraTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTop.Location = new System.Drawing.Point(0, 0);
            this.BarraTop.Name = "BarraTop";
            this.BarraTop.Size = new System.Drawing.Size(1000, 30);
            this.BarraTop.TabIndex = 0;
            this.BarraTop.Paint += new System.Windows.Forms.PaintEventHandler(this.BarraTop_Paint);
            this.BarraTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTop_MouseDown);
            // 
            // MenuLaterale
            // 
            this.MenuLaterale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.MenuLaterale.Controls.Add(this.About);
            this.MenuLaterale.Controls.Add(this.Fertilizzazione);
            this.MenuLaterale.Controls.Add(this.Cambio);
            this.MenuLaterale.Controls.Add(this.po4no3);
            this.MenuLaterale.Controls.Add(this.Pompa);
            this.MenuLaterale.Controls.Add(this.Biologico);
            this.MenuLaterale.Controls.Add(this.Illuminazione);
            this.MenuLaterale.Controls.Add(this.Fondo);
            this.MenuLaterale.Controls.Add(this.Litri);
            this.MenuLaterale.Controls.Add(this.bunifuCustomLabel4);
            this.MenuLaterale.Controls.Add(this.Calcolatori);
            this.MenuLaterale.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuLaterale.Location = new System.Drawing.Point(0, 30);
            this.MenuLaterale.Name = "MenuLaterale";
            this.MenuLaterale.Size = new System.Drawing.Size(300, 570);
            this.MenuLaterale.TabIndex = 1;
            // 
            // Centrale
            // 
            this.Centrale.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Centrale.BackgroundImage")));
            this.Centrale.Location = new System.Drawing.Point(299, 30);
            this.Centrale.Name = "Centrale";
            this.Centrale.Size = new System.Drawing.Size(701, 570);
            this.Centrale.TabIndex = 2;
            // 
            // Titolo
            // 
            this.Titolo.AutoSize = true;
            this.Titolo.BackColor = System.Drawing.Color.Transparent;
            this.Titolo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titolo.ForeColor = System.Drawing.Color.White;
            this.Titolo.Location = new System.Drawing.Point(90, 5);
            this.Titolo.Name = "Titolo";
            this.Titolo.Size = new System.Drawing.Size(136, 19);
            this.Titolo.TabIndex = 0;
            this.Titolo.Text = "AquariumNext#";
            // 
            // Esci
            // 
            this.Esci.BackColor = System.Drawing.Color.DodgerBlue;
            this.Esci.Image = ((System.Drawing.Image)(resources.GetObject("Esci.Image")));
            this.Esci.ImageActive = null;
            this.Esci.Location = new System.Drawing.Point(968, 4);
            this.Esci.Name = "Esci";
            this.Esci.Size = new System.Drawing.Size(20, 20);
            this.Esci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Esci.TabIndex = 0;
            this.Esci.TabStop = false;
            this.Esci.Zoom = 10;
            this.Esci.Click += new System.EventHandler(this.Esci_Click);
            // 
            // Minimizza
            // 
            this.Minimizza.BackColor = System.Drawing.Color.DodgerBlue;
            this.Minimizza.Image = ((System.Drawing.Image)(resources.GetObject("Minimizza.Image")));
            this.Minimizza.ImageActive = null;
            this.Minimizza.Location = new System.Drawing.Point(942, 4);
            this.Minimizza.Name = "Minimizza";
            this.Minimizza.Size = new System.Drawing.Size(20, 20);
            this.Minimizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimizza.TabIndex = 1;
            this.Minimizza.TabStop = false;
            this.Minimizza.Zoom = 10;
            this.Minimizza.Click += new System.EventHandler(this.Minimizza_Click);
            // 
            // Calcolatori
            // 
            this.Calcolatori.AutoSize = true;
            this.Calcolatori.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcolatori.ForeColor = System.Drawing.Color.White;
            this.Calcolatori.Location = new System.Drawing.Point(110, 25);
            this.Calcolatori.Name = "Calcolatori";
            this.Calcolatori.Size = new System.Drawing.Size(90, 20);
            this.Calcolatori.TabIndex = 0;
            this.Calcolatori.Text = "Calcolatori";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(110, 351);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(81, 20);
            this.bunifuCustomLabel4.TabIndex = 1;
            this.bunifuCustomLabel4.Text = "Database";
            this.bunifuCustomLabel4.Click += new System.EventHandler(this.BunifuCustomLabel4_Click);
            // 
            // Litri
            // 
            this.Litri.Activecolor = System.Drawing.Color.DodgerBlue;
            this.Litri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Litri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Litri.BorderRadius = 0;
            this.Litri.ButtonText = "Calcolatore Litri";
            this.Litri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Litri.DisabledColor = System.Drawing.Color.Gray;
            this.Litri.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Litri.Iconcolor = System.Drawing.Color.Transparent;
            this.Litri.Iconimage = null;
            this.Litri.Iconimage_right = null;
            this.Litri.Iconimage_right_Selected = null;
            this.Litri.Iconimage_Selected = null;
            this.Litri.IconMarginLeft = 0;
            this.Litri.IconMarginRight = 0;
            this.Litri.IconRightVisible = true;
            this.Litri.IconRightZoom = 0D;
            this.Litri.IconVisible = true;
            this.Litri.IconZoom = 90D;
            this.Litri.IsTab = false;
            this.Litri.Location = new System.Drawing.Point(0, 67);
            this.Litri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Litri.Name = "Litri";
            this.Litri.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Litri.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.Litri.OnHoverTextColor = System.Drawing.Color.White;
            this.Litri.selected = false;
            this.Litri.Size = new System.Drawing.Size(300, 24);
            this.Litri.TabIndex = 2;
            this.Litri.Text = "Calcolatore Litri";
            this.Litri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Litri.Textcolor = System.Drawing.Color.White;
            this.Litri.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Litri.Click += new System.EventHandler(this.Litri_Click);
            // 
            // Fondo
            // 
            this.Fondo.Activecolor = System.Drawing.Color.DodgerBlue;
            this.Fondo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Fondo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fondo.BorderRadius = 0;
            this.Fondo.ButtonText = "Calcolatore Fondo";
            this.Fondo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fondo.DisabledColor = System.Drawing.Color.Gray;
            this.Fondo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fondo.Iconcolor = System.Drawing.Color.Transparent;
            this.Fondo.Iconimage = null;
            this.Fondo.Iconimage_right = null;
            this.Fondo.Iconimage_right_Selected = null;
            this.Fondo.Iconimage_Selected = null;
            this.Fondo.IconMarginLeft = 0;
            this.Fondo.IconMarginRight = 0;
            this.Fondo.IconRightVisible = true;
            this.Fondo.IconRightZoom = 0D;
            this.Fondo.IconVisible = true;
            this.Fondo.IconZoom = 90D;
            this.Fondo.IsTab = false;
            this.Fondo.Location = new System.Drawing.Point(-3, 99);
            this.Fondo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Fondo.Name = "Fondo";
            this.Fondo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Fondo.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.Fondo.OnHoverTextColor = System.Drawing.Color.White;
            this.Fondo.selected = false;
            this.Fondo.Size = new System.Drawing.Size(300, 24);
            this.Fondo.TabIndex = 3;
            this.Fondo.Text = "Calcolatore Fondo";
            this.Fondo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Fondo.Textcolor = System.Drawing.Color.White;
            this.Fondo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fondo.Click += new System.EventHandler(this.Fondo_Click);
            // 
            // Illuminazione
            // 
            this.Illuminazione.Activecolor = System.Drawing.Color.DodgerBlue;
            this.Illuminazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Illuminazione.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Illuminazione.BorderRadius = 0;
            this.Illuminazione.ButtonText = "Calcolatore Illuminazione";
            this.Illuminazione.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Illuminazione.DisabledColor = System.Drawing.Color.Gray;
            this.Illuminazione.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Illuminazione.Iconcolor = System.Drawing.Color.Transparent;
            this.Illuminazione.Iconimage = null;
            this.Illuminazione.Iconimage_right = null;
            this.Illuminazione.Iconimage_right_Selected = null;
            this.Illuminazione.Iconimage_Selected = null;
            this.Illuminazione.IconMarginLeft = 0;
            this.Illuminazione.IconMarginRight = 0;
            this.Illuminazione.IconRightVisible = true;
            this.Illuminazione.IconRightZoom = 0D;
            this.Illuminazione.IconVisible = true;
            this.Illuminazione.IconZoom = 90D;
            this.Illuminazione.IsTab = false;
            this.Illuminazione.Location = new System.Drawing.Point(0, 131);
            this.Illuminazione.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Illuminazione.Name = "Illuminazione";
            this.Illuminazione.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Illuminazione.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.Illuminazione.OnHoverTextColor = System.Drawing.Color.White;
            this.Illuminazione.selected = false;
            this.Illuminazione.Size = new System.Drawing.Size(300, 24);
            this.Illuminazione.TabIndex = 4;
            this.Illuminazione.Text = "Calcolatore Illuminazione";
            this.Illuminazione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Illuminazione.Textcolor = System.Drawing.Color.White;
            this.Illuminazione.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Illuminazione.Click += new System.EventHandler(this.Illuminazione_Click);
            // 
            // Biologico
            // 
            this.Biologico.Activecolor = System.Drawing.Color.DodgerBlue;
            this.Biologico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Biologico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Biologico.BorderRadius = 0;
            this.Biologico.ButtonText = "Filtraggio Biologico";
            this.Biologico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Biologico.DisabledColor = System.Drawing.Color.Gray;
            this.Biologico.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biologico.Iconcolor = System.Drawing.Color.Transparent;
            this.Biologico.Iconimage = null;
            this.Biologico.Iconimage_right = null;
            this.Biologico.Iconimage_right_Selected = null;
            this.Biologico.Iconimage_Selected = null;
            this.Biologico.IconMarginLeft = 0;
            this.Biologico.IconMarginRight = 0;
            this.Biologico.IconRightVisible = true;
            this.Biologico.IconRightZoom = 0D;
            this.Biologico.IconVisible = true;
            this.Biologico.IconZoom = 90D;
            this.Biologico.IsTab = false;
            this.Biologico.Location = new System.Drawing.Point(0, 163);
            this.Biologico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Biologico.Name = "Biologico";
            this.Biologico.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Biologico.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.Biologico.OnHoverTextColor = System.Drawing.Color.White;
            this.Biologico.selected = false;
            this.Biologico.Size = new System.Drawing.Size(300, 24);
            this.Biologico.TabIndex = 5;
            this.Biologico.Text = "Filtraggio Biologico";
            this.Biologico.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Biologico.Textcolor = System.Drawing.Color.White;
            this.Biologico.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Biologico.Click += new System.EventHandler(this.Biologico_Click);
            // 
            // Pompa
            // 
            this.Pompa.Activecolor = System.Drawing.Color.DodgerBlue;
            this.Pompa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Pompa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pompa.BorderRadius = 0;
            this.Pompa.ButtonText = "Portata Pompa";
            this.Pompa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Pompa.DisabledColor = System.Drawing.Color.Gray;
            this.Pompa.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pompa.Iconcolor = System.Drawing.Color.Transparent;
            this.Pompa.Iconimage = null;
            this.Pompa.Iconimage_right = null;
            this.Pompa.Iconimage_right_Selected = null;
            this.Pompa.Iconimage_Selected = null;
            this.Pompa.IconMarginLeft = 0;
            this.Pompa.IconMarginRight = 0;
            this.Pompa.IconRightVisible = true;
            this.Pompa.IconRightZoom = 0D;
            this.Pompa.IconVisible = true;
            this.Pompa.IconZoom = 90D;
            this.Pompa.IsTab = false;
            this.Pompa.Location = new System.Drawing.Point(0, 195);
            this.Pompa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Pompa.Name = "Pompa";
            this.Pompa.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Pompa.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.Pompa.OnHoverTextColor = System.Drawing.Color.White;
            this.Pompa.selected = false;
            this.Pompa.Size = new System.Drawing.Size(300, 24);
            this.Pompa.TabIndex = 6;
            this.Pompa.Text = "Portata Pompa";
            this.Pompa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Pompa.Textcolor = System.Drawing.Color.White;
            this.Pompa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pompa.Click += new System.EventHandler(this.Pompa_Click);
            // 
            // po4no3
            // 
            this.po4no3.Activecolor = System.Drawing.Color.DodgerBlue;
            this.po4no3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.po4no3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.po4no3.BorderRadius = 0;
            this.po4no3.ButtonText = "Calcolatore po4no3";
            this.po4no3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.po4no3.DisabledColor = System.Drawing.Color.Gray;
            this.po4no3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.po4no3.Iconcolor = System.Drawing.Color.Transparent;
            this.po4no3.Iconimage = null;
            this.po4no3.Iconimage_right = null;
            this.po4no3.Iconimage_right_Selected = null;
            this.po4no3.Iconimage_Selected = null;
            this.po4no3.IconMarginLeft = 0;
            this.po4no3.IconMarginRight = 0;
            this.po4no3.IconRightVisible = true;
            this.po4no3.IconRightZoom = 0D;
            this.po4no3.IconVisible = true;
            this.po4no3.IconZoom = 90D;
            this.po4no3.IsTab = false;
            this.po4no3.Location = new System.Drawing.Point(0, 227);
            this.po4no3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.po4no3.Name = "po4no3";
            this.po4no3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.po4no3.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.po4no3.OnHoverTextColor = System.Drawing.Color.White;
            this.po4no3.selected = false;
            this.po4no3.Size = new System.Drawing.Size(300, 24);
            this.po4no3.TabIndex = 7;
            this.po4no3.Text = "Calcolatore po4no3";
            this.po4no3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.po4no3.Textcolor = System.Drawing.Color.White;
            this.po4no3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.po4no3.Click += new System.EventHandler(this.Po4no3_Click);
            // 
            // Cambio
            // 
            this.Cambio.Activecolor = System.Drawing.Color.DodgerBlue;
            this.Cambio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Cambio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Cambio.BorderRadius = 0;
            this.Cambio.ButtonText = "Calcolatore Cambio Acqua";
            this.Cambio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cambio.DisabledColor = System.Drawing.Color.Gray;
            this.Cambio.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cambio.Iconcolor = System.Drawing.Color.Transparent;
            this.Cambio.Iconimage = null;
            this.Cambio.Iconimage_right = null;
            this.Cambio.Iconimage_right_Selected = null;
            this.Cambio.Iconimage_Selected = null;
            this.Cambio.IconMarginLeft = 0;
            this.Cambio.IconMarginRight = 0;
            this.Cambio.IconRightVisible = true;
            this.Cambio.IconRightZoom = 0D;
            this.Cambio.IconVisible = true;
            this.Cambio.IconZoom = 90D;
            this.Cambio.IsTab = false;
            this.Cambio.Location = new System.Drawing.Point(0, 259);
            this.Cambio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Cambio.Name = "Cambio";
            this.Cambio.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Cambio.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.Cambio.OnHoverTextColor = System.Drawing.Color.White;
            this.Cambio.selected = false;
            this.Cambio.Size = new System.Drawing.Size(300, 24);
            this.Cambio.TabIndex = 8;
            this.Cambio.Text = "Calcolatore Cambio Acqua";
            this.Cambio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Cambio.Textcolor = System.Drawing.Color.White;
            this.Cambio.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cambio.Click += new System.EventHandler(this.Cambio_Click);
            // 
            // Fertilizzazione
            // 
            this.Fertilizzazione.Activecolor = System.Drawing.Color.DodgerBlue;
            this.Fertilizzazione.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Fertilizzazione.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Fertilizzazione.BorderRadius = 0;
            this.Fertilizzazione.ButtonText = "Fertilizzazione";
            this.Fertilizzazione.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fertilizzazione.DisabledColor = System.Drawing.Color.Gray;
            this.Fertilizzazione.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fertilizzazione.Iconcolor = System.Drawing.Color.Transparent;
            this.Fertilizzazione.Iconimage = null;
            this.Fertilizzazione.Iconimage_right = null;
            this.Fertilizzazione.Iconimage_right_Selected = null;
            this.Fertilizzazione.Iconimage_Selected = null;
            this.Fertilizzazione.IconMarginLeft = 0;
            this.Fertilizzazione.IconMarginRight = 0;
            this.Fertilizzazione.IconRightVisible = true;
            this.Fertilizzazione.IconRightZoom = 0D;
            this.Fertilizzazione.IconVisible = true;
            this.Fertilizzazione.IconZoom = 90D;
            this.Fertilizzazione.IsTab = false;
            this.Fertilizzazione.Location = new System.Drawing.Point(0, 291);
            this.Fertilizzazione.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Fertilizzazione.Name = "Fertilizzazione";
            this.Fertilizzazione.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Fertilizzazione.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.Fertilizzazione.OnHoverTextColor = System.Drawing.Color.White;
            this.Fertilizzazione.selected = false;
            this.Fertilizzazione.Size = new System.Drawing.Size(300, 24);
            this.Fertilizzazione.TabIndex = 9;
            this.Fertilizzazione.Text = "Fertilizzazione";
            this.Fertilizzazione.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Fertilizzazione.Textcolor = System.Drawing.Color.White;
            this.Fertilizzazione.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fertilizzazione.Click += new System.EventHandler(this.Fertilizzazione_Click);
            // 
            // About
            // 
            this.About.Activecolor = System.Drawing.Color.DodgerBlue;
            this.About.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.About.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.About.BorderRadius = 0;
            this.About.ButtonText = "About";
            this.About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.About.DisabledColor = System.Drawing.Color.Gray;
            this.About.Font = new System.Drawing.Font("Century Gothic", 5.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Iconcolor = System.Drawing.Color.Transparent;
            this.About.Iconimage = null;
            this.About.Iconimage_right = null;
            this.About.Iconimage_right_Selected = null;
            this.About.Iconimage_Selected = null;
            this.About.IconMarginLeft = 0;
            this.About.IconMarginRight = 0;
            this.About.IconRightVisible = true;
            this.About.IconRightZoom = 0D;
            this.About.IconVisible = true;
            this.About.IconZoom = 90D;
            this.About.IsTab = false;
            this.About.Location = new System.Drawing.Point(0, 546);
            this.About.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.About.Name = "About";
            this.About.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.About.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.About.OnHoverTextColor = System.Drawing.Color.White;
            this.About.selected = false;
            this.About.Size = new System.Drawing.Size(50, 24);
            this.About.TabIndex = 10;
            this.About.Text = "About";
            this.About.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.About.Textcolor = System.Drawing.Color.White;
            this.About.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Centrale);
            this.Controls.Add(this.MenuLaterale);
            this.Controls.Add(this.BarraTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.BarraTop.ResumeLayout(false);
            this.BarraTop.PerformLayout();
            this.MenuLaterale.ResumeLayout(false);
            this.MenuLaterale.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Esci)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizza)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Centrale;
        private Bunifu.Framework.UI.BunifuCustomLabel Titolo;
        private System.Windows.Forms.Panel MenuLaterale;
        private System.Windows.Forms.Panel BarraTop;
        private Bunifu.Framework.UI.BunifuImageButton Esci;
        private Bunifu.Framework.UI.BunifuImageButton Minimizza;
        private Bunifu.Framework.UI.BunifuFlatButton Litri;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel Calcolatori;
        private Bunifu.Framework.UI.BunifuFlatButton About;
        private Bunifu.Framework.UI.BunifuFlatButton Fertilizzazione;
        private Bunifu.Framework.UI.BunifuFlatButton Cambio;
        private Bunifu.Framework.UI.BunifuFlatButton po4no3;
        private Bunifu.Framework.UI.BunifuFlatButton Pompa;
        private Bunifu.Framework.UI.BunifuFlatButton Biologico;
        private Bunifu.Framework.UI.BunifuFlatButton Illuminazione;
        private Bunifu.Framework.UI.BunifuFlatButton Fondo;
    }
}

