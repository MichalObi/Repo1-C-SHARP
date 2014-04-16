using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
       double liczba1, liczba2, wynik;

        public Form1()
        {
            InitializeComponent();
        }

        private void dodawanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = dodawanieToolStripMenuItem.Checked = true;
            odejmowanieToolStripMenuItem.Checked = mnożenieToolStripMenuItem.Checked =
            dzielenieToolStripMenuItem.Checked = false;
        }

        private void odejmowanieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton2.Checked = odejmowanieToolStripMenuItem.Checked = true;
            dodawanieToolStripMenuItem.Checked = mnożenieToolStripMenuItem.Checked =
            dzielenieToolStripMenuItem.Checked = false;
        }

        private void mnożenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton3.Checked = mnożenieToolStripMenuItem.Checked = true;
            dodawanieToolStripMenuItem.Checked = odejmowanieToolStripMenuItem.Checked =
            dzielenieToolStripMenuItem.Checked = false;
        }

        private void dzielenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton4.Checked = dzielenieToolStripMenuItem.Checked = true;
            dodawanieToolStripMenuItem.Checked = odejmowanieToolStripMenuItem.Checked =
            mnożenieToolStripMenuItem.Checked = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)//blokowanie wpisywania znakow w textboxie
        {
            if ((char.IsDigit(e.KeyChar) == false) && (e.KeyChar != '\b')) e.Handled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(this.textBox1.Text, out liczba1) == true) this.button1.Enabled = false;
            else this.button1.Enabled = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false) && (e.KeyChar != '\b')) e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(this.textBox2.Text, out liczba2) == true) this.button1.Enabled = true;
            else this.button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }

            if (radioButton1.Checked)
                wynik = liczba1 + liczba2;
            else if (radioButton2.Checked)
                wynik = liczba1 - liczba2;
            else if (radioButton3.Checked)
                wynik = liczba1 * liczba2;
            else if (radioButton4.Checked)
            {
                if (liczba2 == 0)
                {

                    MessageBox.Show("Dzielisz przez 0 !",
                                    "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    wynik = liczba1 / liczba2;
                }

            }
            richTextBox1.Text += wynik.ToString() + "\n";
            richTextBox2.Text += liczba1 + "\n" + liczba2 + "\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
               richTextBox1.Clear();
               richTextBox1.Focus();
               button2.Enabled = false;
            }
        
        }

        private void liczToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                button2.Enabled = true;
                button3.Enabled = true;
            }

            {
            if (radioButton1.Checked)
                wynik = liczba1 + liczba2;
            else if (radioButton2.Checked)
                wynik = liczba1 - liczba2;
            else if (radioButton3.Checked)
                wynik = liczba1 * liczba2;
            else if (radioButton4.Checked)
            {
                if (liczba2 == 0)
                {
                    MessageBox.Show("Dzielisz przez 0 !",
                        "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else wynik = liczba1 / liczba2;
            }
  
            }

            richTextBox1.Text += wynik.ToString() + "\n";
            richTextBox2.Text += liczba1 + "\n" + liczba2 + "\n";
        }

        private void wyjścieAltF4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Focus();
            button2.Enabled=false;
        }

        private void opeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kalkulator by Michał Obielecki",
            "O programie", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
            richTextBox2.Focus();
            button3.Enabled = false;
        }

        private void richTextBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false) && (e.KeyChar != '\b')) e.Handled = true;//blokuje tylko litery
        }

        private void richTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char.IsDigit(e.KeyChar) == false) && (e.KeyChar != '\b')) e.Handled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            textBox1.Text = richTextBox2.SelectedText; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text = richTextBox2.SelectedText; 
        }

    
        }

}


