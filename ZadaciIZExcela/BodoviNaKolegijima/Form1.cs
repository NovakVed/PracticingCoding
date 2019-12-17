using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodoviNaKolegijima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpremiKolegij_Click(object sender, EventArgs e)
        {
            Predmeti predmet = new Predmeti(txtSpremiKolegij.Text);
            OsvjeziPredmete();
        }

        private void OsvjeziPredmete()
        {
            lbKolegiji.DataSource = null;
            lbKolegiji.DataSource = Predmeti.ListaPredmeta;
            OsvjeziPrikaz();
        }

        private void OsvjeziAktivnosti(Predmeti predmet)
        {
            lbAktivnosti.DataSource = null;
            lbAktivnosti.DataSource = predmet.ListaAktivnosti;
        }

        private void OsvjeziPrikaz()
        {
            dgvPregled.DataSource = null;
            dgvPregled.DataSource = Predmeti.ListaPredmeta;
        }

        private void btnSpremiAktivnost_Click(object sender, EventArgs e)
        {
            int maxBodovi = 0;
            try
            {
                maxBodovi = int.Parse(txtMaxBodoviAktivnosti.Text);

                Aktivnosti aktivnost = new Aktivnosti(txtAktivnosti.Text, maxBodovi);
                Predmeti trenutnoOdabraniPredmet = lbKolegiji.SelectedItem as Predmeti;
                trenutnoOdabraniPredmet.DodajAktivnost(aktivnost);

                OsvjeziAktivnosti(trenutnoOdabraniPredmet);
            }
            catch (FormatException)
            {
                MessageBox.Show("Mora se unijeti pravilan broj!", "Error");
            }
        }

        private void lbKolegiji_SelectedIndexChanged(object sender, EventArgs e)
        {
            Predmeti trenutnoOdabraniPredmet = lbKolegiji.SelectedItem as Predmeti;
            if (trenutnoOdabraniPredmet != null)
            {
                OsvjeziAktivnosti(trenutnoOdabraniPredmet);
            }
        }

        private void lbAktivnosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aktivnosti trenutnoOdabranaAktivnost = lbAktivnosti.SelectedItem as Aktivnosti;

        }
    }
}
