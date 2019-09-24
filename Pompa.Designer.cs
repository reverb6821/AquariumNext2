namespace AquariumNext2._0
{
    partial class Pompa
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
            this.Ltins = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Calcola = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 2;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Ltins
            // 
            this.Ltins.BorderColor = System.Drawing.Color.SeaGreen;
            this.Ltins.Location = new System.Drawing.Point(255, 88);
            this.Ltins.Name = "Ltins";
            this.Ltins.Size = new System.Drawing.Size(191, 20);
            this.Ltins.TabIndex = 20;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(287, 54);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(129, 20);
            this.bunifuCustomLabel5.TabIndex = 19;
            this.bunifuCustomLabel5.Text = "Inserisci lt Vasca";
            this.bunifuCustomLabel5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(195, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(298, 36);
            this.bunifuCustomLabel1.TabIndex = 18;
            this.bunifuCustomLabel1.Text = "Calcolatore Pompa";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Calcola
            // 
            this.Calcola.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Calcola.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Calcola.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Calcola.BorderRadius = 0;
            this.Calcola.ButtonText = "Calcola";
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
            this.Calcola.Location = new System.Drawing.Point(255, 343);
            this.Calcola.Name = "Calcola";
            this.Calcola.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.Calcola.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.Calcola.OnHoverTextColor = System.Drawing.Color.White;
            this.Calcola.selected = false;
            this.Calcola.Size = new System.Drawing.Size(191, 61);
            this.Calcola.TabIndex = 21;
            this.Calcola.Text = "Calcola";
            this.Calcola.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Calcola.Textcolor = System.Drawing.Color.White;
            this.Calcola.TextFont = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calcola.Click += new System.EventHandler(this.Calcola_Click);
            // 
            // Pompa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(46)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(701, 570);
            this.Controls.Add(this.Calcola);
            this.Controls.Add(this.Ltins);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pompa";
            this.Text = "Pompa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox Ltins;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton Calcola;
    }
}