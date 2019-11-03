using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace _114Zadatak
{
    public partial class Form1 : Form
    {
        private List<Kolegij> kolegijs = new List<Kolegij>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            Kolegij kolegij = new Kolegij(txtKolegij.Text, txtOcijena.Text);
            kolegijs.Add(kolegij);
            RefreshList();
        }

        private void RefreshList()
        {
            dgvKolegiji.DataSource = null;
            kolegijs = kolegijs.OrderBy(x => x.OcijenaKolegija).ToList(); //Linq sortiranje liste klasa
            dgvKolegiji.DataSource = kolegijs;
            for (int i = 1; i < kolegijs.Count - 1; i++)
            {
                dgvKolegiji.Rows[i].Visible = false;
            }
        }
    }
}