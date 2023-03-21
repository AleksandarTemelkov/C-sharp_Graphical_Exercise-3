using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vezba_3_Zadatak_5
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            listBox_Numbers.Items.Clear();
            int n = Convert.ToInt32(comboBox_Digits.SelectedItem);

            if (checkBox_Even.Checked && checkBox_Odd.Checked)
            {
                for (int i = Convert.ToInt32(Math.Pow(10, n-1)); i < Math.Pow(10, n); i++)
                {
                    listBox_Numbers.Items.Add(i);
                }
            }
            else if (checkBox_Even.Checked && !checkBox_Odd.Checked)
            {
                for (int i = Convert.ToInt32(Math.Pow(10, n-1)); i < Math.Pow(10, n); i++)
                {
                    if (i % 2 == 0) listBox_Numbers.Items.Add(i);
                }
            }
            else if (!checkBox_Even.Checked && checkBox_Odd.Checked)
            {
                for (int i = Convert.ToInt32(Math.Pow(10, n-1)); i < Math.Pow(10, n); i++)
                {
                    if (i % 2 == 1) listBox_Numbers.Items.Add(i);
                }
            }
            else
            {
                MessageBox.Show("Čekirajte parnost brojeva.", "Upozorenje", MessageBoxButtons.OK , MessageBoxIcon.Warning);
            }
        }
    }
}
