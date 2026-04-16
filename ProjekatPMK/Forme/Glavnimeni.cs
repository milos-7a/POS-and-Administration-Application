using ProjekatPMK.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjekatPMK
{
    public partial class Glavnimeni : Form
    {
        public Glavnimeni()
        {
            InitializeComponent();
        }

        private void Glavnimeni_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdministracija_Click(object sender, EventArgs e)
        {
            Administracija admin = new Administracija();
            admin.Show();
            this.Hide();
        }

        private void BtnProdaja_Click(object sender, EventArgs e)
        {
            Prodaja_Naplata pn = new Prodaja_Naplata();
            pn.Show();
            this.Hide();
        }
    }
}
