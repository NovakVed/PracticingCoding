using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace _111Zadatak
{
    public partial class Form1 : Form
    {
        Stopwatch sw = new Stopwatch();
        int brojac;
        public Form1()
        {   
            InitializeComponent();
        }

        private void rtbUnosPretipkaneRecenice_TextChanged(object sender, EventArgs e)
        {
            sw.Start();
            brojac++;
            Recenica recenica = new Recenica();
            recenica.UnesenaRecenia(rtbUnosRecenice.Text);

            if (recenica.Provjera(rtbUnosPretipkaneRecenice.Text))
            {
                MessageBox.Show("Upisali ste točno!", "KRAJ");
                sw.Stop();

                double vrijeme = sw.Elapsed.TotalSeconds/brojac;

                lblUkupnoVrijeme.Text = sw.Elapsed.TotalSeconds.ToString();
                lblBrojZnakovaUSekundi.Text = vrijeme.ToString();
            }
        }
    }
}
