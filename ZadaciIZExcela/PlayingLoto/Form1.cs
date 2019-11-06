using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayingLoto
{
    public partial class Form1 : Form
    {
        private readonly Loto loto;
        public Form1()
        {
            InitializeComponent();
            loto = new Loto();
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            List<string> listaUnesenihBrojeva = new List<string>
            {
                textBox1.Text,
                textBox2.Text,
                textBox3.Text,
                textBox4.Text,
                textBox5.Text,
                textBox6.Text,
                textBox7.Text
            };

            bool ispravnaVrijednost = loto.UnesenaListaBrojeva(listaUnesenihBrojeva);
            if (ispravnaVrijednost == true)
            {
                btnOdigraj.Enabled = true;
            }
            else
            {
                btnOdigraj.Enabled = false;
                MessageBox.Show("Niste dobro unijeli vrijednosti", "ERROR");
            }
        }

        private void btnOdigraj_Click(object sender, EventArgs e)
        {
            loto.GenerirajDobitneBrojeve();

            txtIzvuceni1.Text = loto.DobitniBrojevi[0].ToString();
            txtIzvuceni2.Text = loto.DobitniBrojevi[1].ToString();
            txtIzvuceni3.Text = loto.DobitniBrojevi[2].ToString();
            txtIzvuceni4.Text = loto.DobitniBrojevi[3].ToString();
            txtIzvuceni5.Text = loto.DobitniBrojevi[4].ToString();
            txtIzvuceni6.Text = loto.DobitniBrojevi[5].ToString();
            txtIzvuceni7.Text = loto.DobitniBrojevi[6].ToString();

            lblPogodeni.Text = loto.IzracunajDobitneBrojeve().ToString();
            loto.IzbrisiListu();
        }
    }
}
