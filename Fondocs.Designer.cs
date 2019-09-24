namespace AquariumNext2._0
{
    partial class Fondocs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Calcola = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Titolo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.LunghezzaIn = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.LarghezzaIn = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.AltezzaIn = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 2;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Calcola
            // 
            this.Calcola.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Calcola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Calcola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Calcola.BorderRadius = 0;
            this.Calcola.ButtonText = "CALCOLA";
            this.Calcola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Calcola.DisabledColor = System.Drawing.Color.Gray;
            this.Calcola.Iconcolor = System.Drawing.Color.Transparent;
            this.Calcola.Iconimage = null;
            this.Calcola.Iconimage_right = null;
            this.Calcola.Iconimage_right_Selected = null;
            this.Calcola.Iconimage_Selected = null;
            this.Calcola.IconMarginLeft = 0;
            this.Calcola.IconMarginRight = 0;
            this.Calcola.IconRightVisible = true;
            this.Calcola.IconRightZoom = 0D;
            this.Calcola.IconVisible = true;
            this.Calcola.IconZoom = 90D;
            this.Calcola.IsTab = false;
            this.Calcola.Location = new System.Drawing.Point(248, 350);
            this.Calcola.Name = "Calcola";
            this.Calcola.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Calcola.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.Calcola.OnHoverTextColor = System.Drawing.Color.White;
            this.Calcola.selected = false;
            this.Calcola.Size = new System.Drawing.Size(196, 58);
            this.Calcola.TabIndex = 16;
            this.Calcola.Text = "CALCOLA";
            this.Calcola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Calcola.Textcolor = System.Drawing.Color.White;
            this.Calcola.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcola.Click += new System.EventHandler(this.Calcola_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(244, 247);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(344, 24);
            this.bunifuCustomLabel3.TabIndex = 15;
            this.bunifuCustomLabel3.Text = "Inserisci altezza fondo desiderato";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(242, 168);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(193, 24);
            this.bunifuCustomLabel2.TabIndex = 14;
            this.bunifuCustomLabel2.Text = "Inserisci Larghezza";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(242, 92);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(199, 24);
            this.bunifuCustomLabel1.TabIndex = 13;
            this.bunifuCustomLabel1.Text = "Inserisci Lunghezza";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.BunifuCustomLabel1_Click);
            // 
            // Titolo
            // 
            this.Titolo.AutoSize = true;
            this.Titolo.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titolo.ForeColor = System.Drawing.Color.White;
            this.Titolo.Location = new System.Drawing.Point(230, 9);
            this.Titolo.Name = "Titolo";
            this.Titolo.Size = new System.Drawing.Size(265, 33);
            this.Titolo.TabIndex = 12;
            this.Titolo.Text = "Calcolatore Fondo";
            // 
            // LunghezzaIn
            // 
            this.LunghezzaIn.BorderColor = System.Drawing.Color.SeaGreen;
            this.LunghezzaIn.Location = new System.Drawing.Point(246, 133);
            this.LunghezzaIn.Name = "LunghezzaIn";
            this.LunghezzaIn.Size = new System.Drawing.Size(190, 20);
            this.LunghezzaIn.TabIndex = 20;
            this.LunghezzaIn.TextChanged += new System.EventHandler(this.BunifuCustomTextbox1_TextChanged);
            // 
            // LarghezzaIn
            // 
            this.LarghezzaIn.BorderColor = System.Drawing.Color.SeaGreen;
            this.LarghezzaIn.Location = new System.Drawing.Point(246, 203);
            this.LarghezzaIn.Name = "LarghezzaIn";
            this.LarghezzaIn.Size = new System.Drawing.Size(190, 20);
            this.LarghezzaIn.TabIndex = 21;
            // 
            // AltezzaIn
            // 
            this.AltezzaIn.BorderColor = System.Drawing.Color.SeaGreen;
            this.AltezzaIn.Location = new System.Drawing.Point(248, 288);
            this.AltezzaIn.Name = "AltezzaIn";
            this.AltezzaIn.Size = new System.Drawing.Size(196, 20);
            this.AltezzaIn.TabIndex = 22;
            // 
            // Fondocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(701, 570);
            this.Controls.Add(this.AltezzaIn);
            this.Controls.Add(this.LarghezzaIn);
            this.Controls.Add(this.LunghezzaIn);
            this.Controls.Add(this.Calcola);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Titolo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fondocs";
            this.Text = "Fondocs";
            this.Load += new System.EventHandler(this.Fondocs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFlatButton Calcola;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel Titolo;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox LunghezzaIn;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox LarghezzaIn;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox AltezzaIn;
    }
}