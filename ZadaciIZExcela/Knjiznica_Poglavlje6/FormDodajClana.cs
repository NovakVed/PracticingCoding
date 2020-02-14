using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica_Poglavlje6
{
    public partial class FormDodajClana : Form
    {
        private Knjiznica knjiznica = new Knjiznica();
        public FormDodajClana()
        {
            InitializeComponent();
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            ProvjeriIspravnost();
            Clan clan = knjiznica.DodajClana(txtIme.Text, txtPrezime.Text);

            PrikaziRezultat(clan);
            OcistiFormu();
        }

        public void ProvjeriIspravnost()
        {
            if (txtIme.Text == "" || txtPrezime.Text == "")
            {
                throw new ArgumentException("Korisnicki podaci moraju biti uneseni!");
            }
        }

        private void PrikaziRezultat(Clan clan)
        {
            if (clan == null)
            {
                MessageBox.Show("Clan vec postoji!", "ERROR");
            }
            else
            {
                MessageBox.Show($"Uspješno dodan član {clan.Ime}, {clan.Prezime} sa korisničkim podacima: {clan.KorisnickoIme}, {clan.KorisnickaLozinka}");
            }
        }

        public void OcistiFormu()
        {
            txtIme.Text = "";
            txtPrezime.Text = "";
        }
    }
}
