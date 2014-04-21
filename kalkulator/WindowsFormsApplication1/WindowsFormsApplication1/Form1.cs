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
    public partial class Form1 : Form // Form1 dziedziczy po Form
    {
       double liczba1, liczba2, wynik; // zmienne przechowujące podane przez użytkownika liczby + wynik

        public Form1()
        {
            InitializeComponent(); // inicjalizacja elementów aplikacji zaprojektowanych w designerze
        }

        // blokowanie nieużywanych funkcji, po wyborze działania przez użytkownika (4 osobne wybory - 4 podstawowe działania )
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
        // koniec blokowania 

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e) //blokowanie wpisywania nieuprawnionych znaków w textboxie
        {
            if ((char.IsDigit(e.KeyChar) == false) && (e.KeyChar != '\b')) e.Handled = true; // jeżeli wprowadzony znak NIE jest cyfrą i nie jest SPACJĄ -> dopuść wprowadzanie 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(this.textBox1.Text, out liczba1) == true) this.button1.Enabled = false; // liczba wpisana w textBox1 ląduje w zmiennej liczba1, button1 ("LICZ") pozostaje wciśnięty
            else this.button1.Enabled = false;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) //blokowanie wpisywania nieuprawnionych znaków w textboxie
        {
            if ((char.IsDigit(e.KeyChar) == false) && (e.KeyChar != '\b')) e.Handled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(this.textBox2.Text, out liczba2) == true) this.button1.Enabled = true; // liczba wpisana w textBox2 ląduje w zmiennej liczba2, button1 ("LICZ") zostaje odblokowany wciśnięty
            else this.button2.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                button2.Enabled = true; // czyszczenie Wyniku
                button3.Enabled = true; // czyszczenie Historii 
            }

            // sprawdzanie jakie działanie ma zostać wykonane

            if (radioButton1.Checked)
                wynik = liczba1 + liczba2;
            else if (radioButton2.Checked)
                wynik = liczba1 - liczba2;
            else if (radioButton3.Checked)
                wynik = liczba1 * liczba2;
            else if (radioButton4.Checked)
            {
                if (liczba2 == 0) // wyjątek - dzielenie przez 0 
                {

                    MessageBox.Show("Dzielisz przez 0 !",
                                    "Informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    wynik = liczba1 / liczba2;
                }

            }
            richTextBox1.Text += wynik.ToString() + "\n"; // "\n" -> kolejny wynik w nowej lini 
            richTextBox2.Text += liczba1 + "\n" + liczba2 + "\n";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
               richTextBox1.Clear(); // czyszczenie wyników
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


