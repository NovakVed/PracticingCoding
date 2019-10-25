using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*"Napravite windows forms aplikaciju u kojoj korisnik unosi tekst. Aplikacija prikazuje da li je uneseni tekst palindrom ili ne. 
Aplikacija prikazuje osnovnu statistiku o tekstu(npr. broj slova, najcesce slovo, najrjeđe slovo, najcesci samoglasnik, najcesci suglasnik, ... itd). 
Svi izračuni se događaju dok korisnik unosi tekst.
Svi elementi u kodu trebaju biti propisno imenovani. Aplikacija treba biti u skladu sa OOP"
*/

namespace _110Zadatak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtUnesiRijec_TextChanged(object sender, EventArgs e)
        {
            Recenica recenica = new Recenica(txtUnesiRijec.Text);
            txtBrojSlova.Text = recenica.BrojSlova().ToString();
            txtNajcesceSlovo.Text = recenica.NajcesceSlovo().ToString();
            txtNajrijedeSlovo.Text = recenica.NajrijedeSlovo().ToString();
        }
    }
}
