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
            List<int> listaUnesenihBrojeva = new List<int>
            {
                int.Parse(textBox1.Text),
                int.Parse(textBox2.Text),
                int.Parse(textBox3.Text),
                int.Parse(textBox4.Text),
                int.Parse(textBox5.Text),
                int.Parse(textBox6.Text),
                int.Parse(textBox7.Text)
            };
        }

        private void btnOdigraj_Click(object sender, EventArgs e)
        {
            loto.GenerirajDobitneBrojeve();
            txtIzvuceni1.Text = loto.DobitniBrojevi[0].ToString();
            txtIzvuceni2.Text = loto.DobitniBrojevi[0].ToString();
            txtIzvuceni3.Text = loto.DobitniBrojevi[0].ToString();
            txtIzvuceni4.Text = loto.DobitniBrojevi[0].ToString();
            txtIzvuceni5.Text = loto.DobitniBrojevi[0].ToString();
            txtIzvuceni6.Text = loto.DobitniBrojevi[0].ToString();
            txtIzvuceni7.Text = loto.DobitniBrojevi[0].ToString();

        }
    }
}
