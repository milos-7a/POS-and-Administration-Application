namespace ProjekatPMK
{
    partial class Glavnimeni
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
            this.BtnAdministracija = new System.Windows.Forms.Button();
            this.BtnProdaja = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAdministracija
            // 
            this.BtnAdministracija.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnAdministracija.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnAdministracija.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdministracija.Location = new System.Drawing.Point(12, 22);
            this.BtnAdministracija.Name = "BtnAdministracija";
            this.BtnAdministracija.Size = new System.Drawing.Size(292, 50);
            this.BtnAdministracija.TabIndex = 0;
            this.BtnAdministracija.Text = "Administracija i statistika";
            this.BtnAdministracija.UseVisualStyleBackColor = false;
            this.BtnAdministracija.Click += new System.EventHandler(this.BtnAdministracija_Click);
            // 
            // BtnProdaja
            // 
            this.BtnProdaja.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnProdaja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnProdaja.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProdaja.Location = new System.Drawing.Point(12, 84);
            this.BtnProdaja.Name = "BtnProdaja";
            this.BtnProdaja.Size = new System.Drawing.Size(292, 50);
            this.BtnProdaja.TabIndex = 0;
            this.BtnProdaja.Text = "Prodaja/Naplata";
            this.BtnProdaja.UseVisualStyleBackColor = false;
            this.BtnProdaja.Click += new System.EventHandler(this.BtnProdaja_Click);
            // 
            // Glavnimeni
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 146);
            this.Controls.Add(this.BtnProdaja);
            this.Controls.Add(this.BtnAdministracija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Glavnimeni";
            this.Text = "Aplikacija za trgovinu";
            this.Load += new System.EventHandler(this.Glavnimeni_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAdministracija;
        private System.Windows.Forms.Button BtnProdaja;
    }
}

