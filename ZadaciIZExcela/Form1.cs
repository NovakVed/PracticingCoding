using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZadaciIZExcela
{
    public partial class Form1 : Form
    {
        private int brojac = 0;

        public Form1()
        {
            InitializeComponent();
            lbBoje.DisplayMember = "Boja";
        }

        private void btnUnesiBoju_Click(object sender, EventArgs e)
        {
            string boja = txtUnesenaBoja.Text;
            Boje boje = new Boje(boja);
            lbBoje.Items.Add(boje);
        }

        private void btnPrikaziBoju_Click(object sender, EventArgs e)
        {
            int count = Boje.ListaBoja.Count;
            this.BackColor = Color.FromName(Boje.ListaBoja[brojac]);
            if (brojac == (count - 1))
            {
                brojac = 0;
            }
            else
            {
                brojac++;
            }
        }
    }
}