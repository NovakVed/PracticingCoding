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
        private Knjiga knjiga;

        private List<Knjiga> ListaKnjiga;
        public Form1()
        {
            InitializeComponent();
            ListaKnjiga = new List<Knjiga>();
        }

        private void btnDodajAutora_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor(txtIme.Text, txtPrezime.Text, txtEmail.Text);
            (lbKnjiga.SelectedItem as Knjiga).DodajAutora(autor);
            OsvijeziPopisKnjiga();
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
            lbAutori.DataSource = (lbKnjiga.SelectedItem as Knjiga).ListaAutora;
        }
        
        private void OsvijeziPopisKnjiga()
        {
            lbKnjiga.DataSource = null;
            lbKnjiga.DataSource = ListaKnjiga;
        }

        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            knjiga = new Knjiga(txtNazivKnjige.Text, int.Parse(txtGodinaKnjige.Text), int.Parse(txtIzdanjeKnjige.Text));
            ListaKnjiga.Add(knjiga);
            OsvijeziPopisKnjiga();
        }

        private void lbKnjiga_MouseClick(object sender, MouseEventArgs e)
        {
            OsvijeziPopisAutora();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in ListaKnjiga)
            {
                if (item.Usporedi(txtPretraziAutoreIKnjige.Text))
                {
                    rtbPretragaAutoraIKnjige.Text += item.Ispisi();
                }
            }
        }
    }
}
