using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BodoviNaKolegiju
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajPredmet_Click(object sender, EventArgs e)
        {
            Predmet predmet = new Predmet(txtPredmet.Text);
            Predmet.ListaPredmeta.Add(predmet);
            OsvjeziPredmete();
            OsvjeziPrikaz();
        }

        public void OsvjeziPredmete()
        {
            lbPredmeti.DataSource = null;
            lbPredmeti.DataSource = Predmet.ListaPredmeta;
        }

        public void OsvjeziAktivnosti()
        {
            Predmet predmet = lbPredmeti.SelectedItem as Predmet;
            lbAktivnosti.DataSource = null;
            lbAktivnosti.DataSource = predmet.ListaAktivnosti;
        }

        private void btnDodajAktivnosti_Click(object sender, EventArgs e)
        {
            Predmet predmet = lbPredmeti.SelectedItem as Predmet;
            Aktivnosti aktivnosti = new Aktivnosti(txtAktivnost.Text, int.Parse(txtBodovi.Text));
            predmet.DodajAktivnost(aktivnosti);
            predmet.AzurirajTablicu();
            OsvjeziAktivnosti();
        }
        
        private void btnSpremiBodove_Click(object sender, EventArgs e)
        {
            Predmet predmet = lbPredmeti.SelectedItem as Predmet;
            Aktivnosti aktivnosti = lbAktivnosti.SelectedItem as Aktivnosti;
            BodoviPoAktivnosti bodoviPoAktivnosti = new BodoviPoAktivnosti(int.Parse(txtOstvareniBodovi.Text));
            aktivnosti.OstvareniBodovi = bodoviPoAktivnosti;
            predmet.AzurirajTablicu();
            OsvjeziPrikaz();
        }

        private void lbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Predmet predmet = lbPredmeti.SelectedItem as Predmet;
            if (predmet != null)
            {
                OsvjeziAktivnosti();
            }
            OsvjeziPrikaz();
        }

        private void lbAktivnosti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aktivnosti aktivnosti = lbAktivnosti.SelectedItem as Aktivnosti;
            if (aktivnosti != null)
            {
                if (aktivnosti.OstvareniBodovi != null)
                {
                    txtAktivnost.Text = aktivnosti.NazivAktivnosti;
                    txtBodovi.Text = aktivnosti.Bodovi.ToString();
                    txtOstvareniBodovi.Text = aktivnosti.OstvareniBodovi.ToString();
                }
            }
        }

        public void OsvjeziPrikaz()
        {
            dgvUkupniBodovi.DataSource = null;
            dgvUkupniBodovi.DataSource = Predmet.ListaPredmeta;
        }
    }
}
