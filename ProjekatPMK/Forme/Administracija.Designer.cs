namespace ProjekatPMK.Forme
{
    partial class Administracija
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageKategorije = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.listaKtg = new System.Windows.Forms.ListBox();
            this.buttonObrisiKtg = new System.Windows.Forms.Button();
            this.buttonIzmeniKtg = new System.Windows.Forms.Button();
            this.buttonDodajKtg = new System.Windows.Forms.Button();
            this.textKategorije = new System.Windows.Forms.TextBox();
            this.labelNazivKtg = new System.Windows.Forms.Label();
            this.tabPageArtikli = new System.Windows.Forms.TabPage();
            this.listBoxArtikli = new System.Windows.Forms.ListBox();
            this.buttonObrisiArtikal = new System.Windows.Forms.Button();
            this.buttonIzmeniArtikal = new System.Windows.Forms.Button();
            this.buttonDodajArtikal = new System.Windows.Forms.Button();
            this.textBoxJedinicaMere = new System.Windows.Forms.TextBox();
            this.textBoxCenaArtikla = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNazivArtikla = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxKategorija = new System.Windows.Forms.ComboBox();
            this.tabPageStatistika = new System.Windows.Forms.TabPage();
            this.statistikaDatum = new System.Windows.Forms.DateTimePicker();
            this.panelStatistika = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPageKategorije.SuspendLayout();
            this.tabPageArtikli.SuspendLayout();
            this.tabPageStatistika.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageKategorije);
            this.tabControl1.Controls.Add(this.tabPageArtikli);
            this.tabControl1.Controls.Add(this.tabPageStatistika);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(609, 354);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tabPageKategorije
            // 
            this.tabPageKategorije.Controls.Add(this.label5);
            this.tabPageKategorije.Controls.Add(this.listaKtg);
            this.tabPageKategorije.Controls.Add(this.buttonObrisiKtg);
            this.tabPageKategorije.Controls.Add(this.buttonIzmeniKtg);
            this.tabPageKategorije.Controls.Add(this.buttonDodajKtg);
            this.tabPageKategorije.Controls.Add(this.textKategorije);
            this.tabPageKategorije.Controls.Add(this.labelNazivKtg);
            this.tabPageKategorije.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageKategorije.Location = new System.Drawing.Point(4, 25);
            this.tabPageKategorije.Name = "tabPageKategorije";
            this.tabPageKategorije.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageKategorije.Size = new System.Drawing.Size(601, 325);
            this.tabPageKategorije.TabIndex = 0;
            this.tabPageKategorije.Text = "Azuriranje kategorija";
            this.tabPageKategorije.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(553, 301);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 4;
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listaKtg
            // 
            this.listaKtg.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaKtg.FormattingEnabled = true;
            this.listaKtg.ItemHeight = 18;
            this.listaKtg.Location = new System.Drawing.Point(364, 6);
            this.listaKtg.Name = "listaKtg";
            this.listaKtg.Size = new System.Drawing.Size(231, 292);
            this.listaKtg.TabIndex = 3;
            this.listaKtg.Click += new System.EventHandler(this.listaKtg_Click);
            // 
            // buttonObrisiKtg
            // 
            this.buttonObrisiKtg.Enabled = false;
            this.buttonObrisiKtg.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonObrisiKtg.Location = new System.Drawing.Point(9, 233);
            this.buttonObrisiKtg.Name = "buttonObrisiKtg";
            this.buttonObrisiKtg.Size = new System.Drawing.Size(345, 40);
            this.buttonObrisiKtg.TabIndex = 2;
            this.buttonObrisiKtg.Text = "Obrisi kategoriju";
            this.buttonObrisiKtg.UseVisualStyleBackColor = true;
            this.buttonObrisiKtg.Click += new System.EventHandler(this.buttonObrisiKtg_Click);
            // 
            // buttonIzmeniKtg
            // 
            this.buttonIzmeniKtg.Enabled = false;
            this.buttonIzmeniKtg.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonIzmeniKtg.Location = new System.Drawing.Point(9, 187);
            this.buttonIzmeniKtg.Name = "buttonIzmeniKtg";
            this.buttonIzmeniKtg.Size = new System.Drawing.Size(345, 40);
            this.buttonIzmeniKtg.TabIndex = 2;
            this.buttonIzmeniKtg.Text = "Izmeni kategoriju";
            this.buttonIzmeniKtg.UseVisualStyleBackColor = true;
            this.buttonIzmeniKtg.Click += new System.EventHandler(this.buttonIzmeniKtg_Click);
            // 
            // buttonDodajKtg
            // 
            this.buttonDodajKtg.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDodajKtg.Location = new System.Drawing.Point(9, 141);
            this.buttonDodajKtg.Name = "buttonDodajKtg";
            this.buttonDodajKtg.Size = new System.Drawing.Size(345, 40);
            this.buttonDodajKtg.TabIndex = 2;
            this.buttonDodajKtg.Text = "Dodaj kategoriju";
            this.buttonDodajKtg.UseVisualStyleBackColor = true;
            this.buttonDodajKtg.Click += new System.EventHandler(this.buttonDodajKtg_Click);
            // 
            // textKategorije
            // 
            this.textKategorije.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textKategorije.Location = new System.Drawing.Point(9, 98);
            this.textKategorije.Name = "textKategorije";
            this.textKategorije.Size = new System.Drawing.Size(345, 26);
            this.textKategorije.TabIndex = 1;
            // 
            // labelNazivKtg
            // 
            this.labelNazivKtg.AutoSize = true;
            this.labelNazivKtg.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNazivKtg.Location = new System.Drawing.Point(6, 77);
            this.labelNazivKtg.Name = "labelNazivKtg";
            this.labelNazivKtg.Size = new System.Drawing.Size(116, 18);
            this.labelNazivKtg.TabIndex = 0;
            this.labelNazivKtg.Text = "Naziv kategorije:";
            // 
            // tabPageArtikli
            // 
            this.tabPageArtikli.Controls.Add(this.listBoxArtikli);
            this.tabPageArtikli.Controls.Add(this.buttonObrisiArtikal);
            this.tabPageArtikli.Controls.Add(this.buttonIzmeniArtikal);
            this.tabPageArtikli.Controls.Add(this.buttonDodajArtikal);
            this.tabPageArtikli.Controls.Add(this.textBoxJedinicaMere);
            this.tabPageArtikli.Controls.Add(this.textBoxCenaArtikla);
            this.tabPageArtikli.Controls.Add(this.label4);
            this.tabPageArtikli.Controls.Add(this.textBoxNazivArtikla);
            this.tabPageArtikli.Controls.Add(this.label3);
            this.tabPageArtikli.Controls.Add(this.label2);
            this.tabPageArtikli.Controls.Add(this.label1);
            this.tabPageArtikli.Controls.Add(this.comboBoxKategorija);
            this.tabPageArtikli.Location = new System.Drawing.Point(4, 25);
            this.tabPageArtikli.Name = "tabPageArtikli";
            this.tabPageArtikli.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageArtikli.Size = new System.Drawing.Size(601, 325);
            this.tabPageArtikli.TabIndex = 1;
            this.tabPageArtikli.Text = "Azuriranje artikala";
            this.tabPageArtikli.UseVisualStyleBackColor = true;
            // 
            // listBoxArtikli
            // 
            this.listBoxArtikli.FormattingEnabled = true;
            this.listBoxArtikli.ItemHeight = 16;
            this.listBoxArtikli.Location = new System.Drawing.Point(278, 6);
            this.listBoxArtikli.Name = "listBoxArtikli";
            this.listBoxArtikli.Size = new System.Drawing.Size(317, 420);
            this.listBoxArtikli.TabIndex = 4;
            this.listBoxArtikli.SelectedIndexChanged += new System.EventHandler(this.listBoxArtikli_SelectedIndexChanged);
            // 
            // buttonObrisiArtikal
            // 
            this.buttonObrisiArtikal.Location = new System.Drawing.Point(6, 277);
            this.buttonObrisiArtikal.Name = "buttonObrisiArtikal";
            this.buttonObrisiArtikal.Size = new System.Drawing.Size(266, 23);
            this.buttonObrisiArtikal.TabIndex = 3;
            this.buttonObrisiArtikal.Text = "Obrisi artikal";
            this.buttonObrisiArtikal.UseVisualStyleBackColor = true;
            this.buttonObrisiArtikal.Click += new System.EventHandler(this.buttonObrisiArtikal_Click);
            // 
            // buttonIzmeniArtikal
            // 
            this.buttonIzmeniArtikal.Location = new System.Drawing.Point(6, 248);
            this.buttonIzmeniArtikal.Name = "buttonIzmeniArtikal";
            this.buttonIzmeniArtikal.Size = new System.Drawing.Size(266, 23);
            this.buttonIzmeniArtikal.TabIndex = 3;
            this.buttonIzmeniArtikal.Text = "Izmeni artikal";
            this.buttonIzmeniArtikal.UseVisualStyleBackColor = true;
            this.buttonIzmeniArtikal.Click += new System.EventHandler(this.buttonIzmeniArtikal_Click);
            // 
            // buttonDodajArtikal
            // 
            this.buttonDodajArtikal.Location = new System.Drawing.Point(6, 219);
            this.buttonDodajArtikal.Name = "buttonDodajArtikal";
            this.buttonDodajArtikal.Size = new System.Drawing.Size(266, 23);
            this.buttonDodajArtikal.TabIndex = 3;
            this.buttonDodajArtikal.Text = "Dodaj artikal";
            this.buttonDodajArtikal.UseVisualStyleBackColor = true;
            this.buttonDodajArtikal.Click += new System.EventHandler(this.buttonDodajArtikal_Click);
            // 
            // textBoxJedinicaMere
            // 
            this.textBoxJedinicaMere.Location = new System.Drawing.Point(6, 180);
            this.textBoxJedinicaMere.Name = "textBoxJedinicaMere";
            this.textBoxJedinicaMere.Size = new System.Drawing.Size(266, 23);
            this.textBoxJedinicaMere.TabIndex = 2;
            // 
            // textBoxCenaArtikla
            // 
            this.textBoxCenaArtikla.Location = new System.Drawing.Point(6, 129);
            this.textBoxCenaArtikla.Name = "textBoxCenaArtikla";
            this.textBoxCenaArtikla.Size = new System.Drawing.Size(266, 23);
            this.textBoxCenaArtikla.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Jedinica mere artikla:";
            // 
            // textBoxNazivArtikla
            // 
            this.textBoxNazivArtikla.Location = new System.Drawing.Point(6, 82);
            this.textBoxNazivArtikla.Name = "textBoxNazivArtikla";
            this.textBoxNazivArtikla.Size = new System.Drawing.Size(266, 23);
            this.textBoxNazivArtikla.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cena artikla:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv artikla:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategorija:";
            // 
            // comboBoxKategorija
            // 
            this.comboBoxKategorija.FormattingEnabled = true;
            this.comboBoxKategorija.Location = new System.Drawing.Point(6, 33);
            this.comboBoxKategorija.Name = "comboBoxKategorija";
            this.comboBoxKategorija.Size = new System.Drawing.Size(266, 24);
            this.comboBoxKategorija.TabIndex = 0;
            this.comboBoxKategorija.SelectionChangeCommitted += new System.EventHandler(this.comboBoxKategorija_SelectionChangeCommitted);
            // 
            // tabPageStatistika
            // 
            this.tabPageStatistika.Controls.Add(this.panelStatistika);
            this.tabPageStatistika.Controls.Add(this.statistikaDatum);
            this.tabPageStatistika.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageStatistika.Location = new System.Drawing.Point(4, 25);
            this.tabPageStatistika.Name = "tabPageStatistika";
            this.tabPageStatistika.Size = new System.Drawing.Size(601, 325);
            this.tabPageStatistika.TabIndex = 2;
            this.tabPageStatistika.Text = "Pregled Statistike";
            this.tabPageStatistika.UseVisualStyleBackColor = true;
            // 
            // statistikaDatum
            // 
            this.statistikaDatum.Location = new System.Drawing.Point(191, 12);
            this.statistikaDatum.Name = "statistikaDatum";
            this.statistikaDatum.Size = new System.Drawing.Size(200, 22);
            this.statistikaDatum.TabIndex = 0;
            this.statistikaDatum.ValueChanged += new System.EventHandler(this.statistikaDatum_ValueChanged);
            // 
            // panelStatistika
            // 
            this.panelStatistika.AutoScroll = true;
            this.panelStatistika.Location = new System.Drawing.Point(3, 42);
            this.panelStatistika.Name = "panelStatistika";
            this.panelStatistika.Size = new System.Drawing.Size(595, 280);
            this.panelStatistika.TabIndex = 1;
            // 
            // Administracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 354);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Administracija";
            this.Text = "Administracija";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Administracija_FormClosed);
            this.tabControl1.ResumeLayout(false);
            this.tabPageKategorije.ResumeLayout(false);
            this.tabPageKategorije.PerformLayout();
            this.tabPageArtikli.ResumeLayout(false);
            this.tabPageArtikli.PerformLayout();
            this.tabPageStatistika.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageArtikli;
        private System.Windows.Forms.TabPage tabPageKategorije;
        private System.Windows.Forms.TabPage tabPageStatistika;
        private System.Windows.Forms.Button buttonObrisiKtg;
        private System.Windows.Forms.Button buttonIzmeniKtg;
        private System.Windows.Forms.Button buttonDodajKtg;
        private System.Windows.Forms.TextBox textKategorije;
        private System.Windows.Forms.Label labelNazivKtg;
        private System.Windows.Forms.ListBox listaKtg;
        private System.Windows.Forms.TextBox textBoxCenaArtikla;
        private System.Windows.Forms.TextBox textBoxNazivArtikla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxKategorija;
        private System.Windows.Forms.TextBox textBoxJedinicaMere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxArtikli;
        private System.Windows.Forms.Button buttonObrisiArtikal;
        private System.Windows.Forms.Button buttonIzmeniArtikal;
        private System.Windows.Forms.Button buttonDodajArtikal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker statistikaDatum;
        private System.Windows.Forms.Panel panelStatistika;
    }
}