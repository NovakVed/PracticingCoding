using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poglavlje5_zadatak1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPretrazi_Click(object sender, EventArgs e)
        {

        }

        private void btnDodajKnjigu_Click(object sender, EventArgs e)
        {
            Knjiga knjiga = new Knjiga(txtNazivKnjige.Text);
        }

        private void btnDodajAutora_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor(txtImeAutora.Text, txtPrezimeAutora.Text);
        }
    }
}
