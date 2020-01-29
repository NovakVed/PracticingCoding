using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loto7_39
{
    public partial class Form1 : Form
    {
        private Loto loto;
        public Form1()
        {
            InitializeComponent();
            loto = new Loto();
        }

        private void btnUplati_Click(object sender, EventArgs e)
        {
            
            List<string> UplaceniBrojevi = new List<string>();
            UplaceniBrojevi.Add(textBox1.Text);
            UplaceniBrojevi.Add(textBox2.Text);
            UplaceniBrojevi.Add(textBox3.Text);
            UplaceniBrojevi.Add(textBox4.Text);
            UplaceniBrojevi.Add(textBox5.Text);
            UplaceniBrojevi.Add(textBox6.Text);
            UplaceniBrojevi.Add(textBox7.Text);

            bool ispravneVrijednost = loto.UnesiUplaceneBrojeve(UplaceniBrojevi);
            if (ispravneVrijednost == true)
            {
                btnOdigraj.Enabled = true;
            }
            else
            {
                btnOdigraj.Enabled = false;
                MessageBox.Show("Unijeli ste krive vrijednosti", "ERROR");
            }
        }

        private void btnOdigraj_Click(object sender, EventArgs e)
        {

            loto.GenerirajDobiveneBrojeve();

            textBox8.Text = loto.ListaDobivenihBrojeva[0].ToString();
            textBox9.Text = loto.ListaDobivenihBrojeva[1].ToString();
            textBox10.Text = loto.ListaDobivenihBrojeva[2].ToString();
            textBox11.Text = loto.ListaDobivenihBrojeva[3].ToString();
            textBox12.Text = loto.ListaDobivenihBrojeva[4].ToString();
            textBox13.Text = loto.ListaDobivenihBrojeva[5].ToString();
            textBox14.Text = loto.ListaDobivenihBrojeva[6].ToString();

            lblBrojPogodaka.Text = loto.ProvjeraDobivenihBrojeva().ToString();
        }
    }
}
