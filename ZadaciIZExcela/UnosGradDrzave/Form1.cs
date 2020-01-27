using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnosGradDrzave
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cmbOdabirDrzave.DisplayMember = "Naziv";
            OsvjeziTablicu();
        }

        private void btnUnesiDrzavu_Click(object sender, EventArgs e)
        {
            if (txtNazivDrzave.Text.Equals(""))
            {
                MessageBox.Show("Niste upisali državu!", "Error");
            }
            else
            {
                Drzava drzava = new Drzava(txtNazivDrzave.Text);
                DodajUComboBox(drzava);
                OsvjeziTablicu();
            }
        }

        private void DodajUComboBox(Drzava drzava)
        {
            cmbOdabirDrzave.Items.Add(drzava);
        }

        private void btnUnosGrada_Click(object sender, EventArgs e)
        {
            string nazivGrada = txtNazivGrada.Text;
            int brojStanovnika = 0;

            try
            {
                brojStanovnika = int.Parse(txtBrojStanovnika.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste unijeli broj stanivnika!", "Error");
                return;
            }

            Grad grad = new Grad(nazivGrada, brojStanovnika);

            try
            {
                Drzava drzava = cmbOdabirDrzave.SelectedItem as Drzava;
                drzava.ListaGradova.Add(grad);
            }
            catch (Exception)
            {
                MessageBox.Show("Niste odabrali drzavu!", "Error");
                return;
            }
            OsvjeziTablicu();
        }

        private void OsvjeziTablicu()
        {
            dgvIspisDrzavaGradova.DataSource = null;

            DataTable table = new DataTable();
            table.Columns.Add("Dražava", typeof(string));
            table.Columns.Add("Grad", typeof(string));
            table.Columns.Add("Stanovika", typeof(int));
            foreach (var drzava in Drzava.ListaDrzava)
            {
                foreach (var grad in drzava.ListaGradova)
                {
                    table.Rows.Add(drzava.Naziv, grad.Naziv, grad.BrojStanovnika);
                }
            }

            dgvIspisDrzavaGradova.DataSource = table;
        }
    }
}
