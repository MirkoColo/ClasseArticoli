namespace ClasseArticoli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ALIMENTARI = new System.Windows.Forms.Button();
            this.NON_ALIMENTARI = new System.Windows.Forms.Button();
            this.ALIMENTARI_FRESCHI = new System.Windows.Forms.Button();
            this.SCONTRINO = new System.Windows.Forms.Button();
            this.Scontrinos = new System.Windows.Forms.ListBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // ALIMENTARI
            // 
            this.ALIMENTARI.Location = new System.Drawing.Point(89, 74);
            this.ALIMENTARI.Name = "ALIMENTARI";
            this.ALIMENTARI.Size = new System.Drawing.Size(125, 43);
            this.ALIMENTARI.TabIndex = 1;
            this.ALIMENTARI.Text = "ALIMENTARI";
            this.ALIMENTARI.UseVisualStyleBackColor = true;
            this.ALIMENTARI.Click += new System.EventHandler(this.ALIMENTARI_Click);
            // 
            // NON_ALIMENTARI
            // 
            this.NON_ALIMENTARI.Location = new System.Drawing.Point(251, 74);
            this.NON_ALIMENTARI.Name = "NON_ALIMENTARI";
            this.NON_ALIMENTARI.Size = new System.Drawing.Size(125, 43);
            this.NON_ALIMENTARI.TabIndex = 2;
            this.NON_ALIMENTARI.Text = "NON ALIMENTARI";
            this.NON_ALIMENTARI.UseVisualStyleBackColor = true;
            this.NON_ALIMENTARI.Click += new System.EventHandler(this.NON_ALIMENTARI_Click);
            // 
            // ALIMENTARI_FRESCHI
            // 
            this.ALIMENTARI_FRESCHI.Location = new System.Drawing.Point(396, 74);
            this.ALIMENTARI_FRESCHI.Name = "ALIMENTARI_FRESCHI";
            this.ALIMENTARI_FRESCHI.Size = new System.Drawing.Size(125, 43);
            this.ALIMENTARI_FRESCHI.TabIndex = 3;
            this.ALIMENTARI_FRESCHI.Text = "ALIMENTARI FRESCHI";
            this.ALIMENTARI_FRESCHI.UseVisualStyleBackColor = true;
            this.ALIMENTARI_FRESCHI.Click += new System.EventHandler(this.ALIMENTARI_FRESCHI_Click);
            // 
            // SCONTRINO
            // 
            this.SCONTRINO.Location = new System.Drawing.Point(547, 74);
            this.SCONTRINO.Name = "SCONTRINO";
            this.SCONTRINO.Size = new System.Drawing.Size(125, 43);
            this.SCONTRINO.TabIndex = 4;
            this.SCONTRINO.Text = "STAMPA SCONTRINO";
            this.SCONTRINO.UseVisualStyleBackColor = true;
            this.SCONTRINO.Click += new System.EventHandler(this.SCONTRINO_Click);
            // 
            // Scontrinos
            // 
            this.Scontrinos.FormattingEnabled = true;
            this.Scontrinos.Location = new System.Drawing.Point(34, 137);
            this.Scontrinos.Name = "Scontrinos";
            this.Scontrinos.Size = new System.Drawing.Size(698, 264);
            this.Scontrinos.TabIndex = 5;
            this.Scontrinos.SelectedIndexChanged += new System.EventHandler(this.Scontrinos_SelectedIndexChanged);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Old English Text MT", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Red;
            this.linkLabel1.Location = new System.Drawing.Point(617, 384);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(171, 57);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "ESCI";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Scontrinos);
            this.Controls.Add(this.SCONTRINO);
            this.Controls.Add(this.ALIMENTARI_FRESCHI);
            this.Controls.Add(this.NON_ALIMENTARI);
            this.Controls.Add(this.ALIMENTARI);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ALIMENTARI;
        private System.Windows.Forms.Button NON_ALIMENTARI;
        private System.Windows.Forms.Button ALIMENTARI_FRESCHI;
        private System.Windows.Forms.Button SCONTRINO;
        private System.Windows.Forms.ListBox Scontrinos;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

