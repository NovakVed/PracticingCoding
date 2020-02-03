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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodajAutora_Click(object sender, EventArgs e)
        {
            Autor autor = new Autor(txtIme.Text, txtPrezime.Text, txtEmail.Text);
            Knjiga knjiga = new Knjiga();
            knjiga.DodajAutora(autor);
            lbAutori.DataSource = null;
            lbAutori.DataSource = knjiga.ListaAutora;
        }


    }
}
