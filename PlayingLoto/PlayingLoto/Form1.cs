using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PlayingLoto
{
    public partial class Form1 : Form
    {
        private Loto loto;
        public Form1()
        {
            InitializeComponent();
            loto = new Loto();
        }

        /// <summary>
        /// Uneseni brojevi se spremaju u listu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnUplati_Click(object sender, EventArgs e)
        {
            List<string> vrijednosti = new List<string>();
            vrijednosti.Add(txtPrviBroj.Text);
            vrijednosti.Add(txtDrugiBroj.Text);
            vrijednosti.Add(txtTreciBroj.Text);
            vrijednosti.Add(txtCetvrtiBroj.Text);
            vrijednosti.Add(txtPetiBroj.Text);
            vrijednosti.Add(txtSestiBroj.Text);
            vrijednosti.Add(txtSedmiBroj.Text);
            bool ispravnaKombinacija = loto.UnesiUplaceneBrojeve(vrijednosti);
            if (ispravnaKombinacija == true)
            {
                btnOdigraj.Enabled = true;
            }
            else
            {
                btnOdigraj.Enabled = false;
                MessageBox.Show("Unijeli ste krive brojeve!");
            }
        }

        private void BtnOdigraj_Click(object sender, EventArgs e)
        {
            loto.GenerirajDobitneBrojeve();

            txtIzvuceni1.Text = loto.DobitniBrojevi[0].ToString();
            txtIzvuceni2.Text = loto.DobitniBrojevi[1].ToString();
            txtIzvuceni3.Text = loto.DobitniBrojevi[2].ToString();
            txtIzvuceni4.Text = loto.DobitniBrojevi[3].ToString();
            txtIzvuceni5.Text = loto.DobitniBrojevi[4].ToString();
            txtIzvuceni6.Text = loto.DobitniBrojevi[5].ToString();
            txtIzvuceni7.Text = loto.DobitniBrojevi[6].ToString();
            int brojPogadata = loto.UsporediBrojeve();
            lblBrojPogodenih.Text = brojPogadata.ToString();
        }
    }
}
