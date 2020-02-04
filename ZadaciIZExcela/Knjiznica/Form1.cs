using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knjiznica
{
    public partial class Form1 : Form
    {
        Knjiga knjiga;

        private List<Knjiga> ListaKnjiga;
        public Form1()
        {
            InitializeComponent();
            ListaKnjiga = new List<Knjiga>();
        }

        private void btnDodajAutora_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor(txtIme.Text, txtPrezime.Text, txtEmail.Text);
            knjiga.DodajAutora(autor);
            lbAutori.DataSource = null;
            OsvijeziPopisAutora();
        }

        private void btnIzbrisiOdabranogAutora_Click(object sender, EventArgs e)
        {
            knjiga.UkloniAutora(lbAutori.SelectedItem as Autor);
            OsvijeziPopisAutora();
        }

        private void OsvijeziPopisAutora()
        {
            lbAutori.DataSource = null;
            lbAutori.DataSource = knjiga.ListaAutora;
        }

        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            knjiga = new Knjiga(txtNazivKnjige.Text, int.Parse(txtGodinaKnjige.Text), int.Parse(txtIzdanjeKnjige.Text));
            ListaKnjiga.Add(knjiga);
        }
    }
}
