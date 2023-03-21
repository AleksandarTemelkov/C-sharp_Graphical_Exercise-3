using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezba_3_Zadatak_1
{
    public partial class Čekiranje : Form
    {
        public Čekiranje()
        {
            InitializeComponent();
        }

        private void button_Prikazi_Click(object sender, EventArgs e)
        {
            richTextBox_Result.Text = "";


            if (checkBox_Ime.Checked && textBox_Ime.Text != "") 
            {
                richTextBox_Result.Text += "Tvoje ime je " + textBox_Ime.Text;
            }
            else if (!checkBox_Ime.Checked || textBox_Ime.Text == "") 
            {
                richTextBox_Result.Text += "Niste uneli ime.";
            }


            if (checkBox_Prezime.Checked && textBox_Prezime.Text != "")
            {
                richTextBox_Result.Text += "\nTvoje prezime je " + textBox_Prezime.Text;
            }
            else if (!checkBox_Prezime.Checked || textBox_Prezime.Text == "")
            {
                richTextBox_Result.Text += "\nNiste uneli prezime.";
            }


            if (checkBox_Adresa.Checked && textBox_Adresa.Text != "")
            {
                richTextBox_Result.Text += "\nTvoja adresa je " + textBox_Adresa.Text;
            }
            else if (!checkBox_Adresa.Checked || textBox_Adresa.Text == "")
            {
                richTextBox_Result.Text += "\nNiste uneli adresu.";
            }


            if (checkBox_MestoStanovanja.Checked && textBox_MestoStanovanja.Text != "")
            {
                richTextBox_Result.Text += "\nTvoje mesto stanovanja je " + textBox_MestoStanovanja.Text;
            }
            else if (!checkBox_MestoStanovanja.Checked || textBox_MestoStanovanja.Text == "")
            {
                richTextBox_Result.Text += "\nNiste uneli mesto stanovanja.";
            }
        }

        private void checkBox_Ime_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Ime.ReadOnly = !textBox_Ime.ReadOnly;
        }

        private void checkBox_Prezime_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Prezime.ReadOnly = !textBox_Prezime.ReadOnly;
        }

        private void checkBox_Adresa_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Adresa.ReadOnly = !textBox_Adresa.ReadOnly;
        }

        private void checkBox_MestoStanovanja_CheckedChanged(object sender, EventArgs e)
        {
            textBox_MestoStanovanja.ReadOnly = !textBox_MestoStanovanja.ReadOnly;
        }
    }
}
