using System;
using System.Windows.Forms;

namespace _112Zadatak
{
    public partial class Form1 : Form
    {
        private Text text = new Text();

        public Form1()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            text.InputedText(rtbInputedText.Text);
            rtbReversedText.Text = text.ReverseOrder();
            lblNumberOfChars.Text = text.NumberOfChar();
        }

        private void txtInputedChar_TextChanged(object sender, EventArgs e)
        {
            if (txtInputedChar.Text.Length > 1)
            {
                MessageBox.Show("Samo jedno slovo mozete upisati!", "Error");
                lblRepetitionOfInputedChar.Text = "";
            }
            else if (txtInputedChar.Text.Length == 0)
            {
                lblNumberOfChars.Text = "";
            }
            else
            {
                lblRepetitionOfInputedChar.Text = text.NumberOfInputedChar(char.Parse(txtInputedChar.Text));
            }
        }
    }
}