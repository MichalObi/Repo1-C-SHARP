using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace Komunikator
{
    public partial class Form1 : Form
    {
        private TcpListener serwer; // zmienna globalna
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress adresIP; // adres serwera

            try
            {
                adresIP = IPAddress.Parse(textBox1.Text);
            }
            catch
            {
                textBox1.Text = String.Empty; // wyczyszczenie błędnie podanego IP
                return; // powrót z pętli
            }

            int port = Convert.ToInt16(numericUpDown1.Value);

            try
            {
                serwer = new TcpListener(adresIP, port);
                serwer.Start();

                do
                {
                    button1.Enabled = false; // próbujemy wysłac wiadomość
                    textBox5.Text = "czekaj ... ";
                    textBox5.Update();
                    string wiadomosc = textBox4.Text + ": " + textBox3.Text;

                    Socket nowyKlient = serwer.AcceptSocket();
                    if (nowyKlient.Connected)
                    {
                        NetworkStream ns = new NetworkStream(nowyKlient);
                        byte[] buf = Encoding.ASCII.GetBytes(wiadomosc); // przekodowanie na postać bajtową
                        ns.Write(buf, 0, buf.Length); // wysłanie strumieniem 
                        ns.Flush();
                        ns.Close();//zamknięcie strumienia
                    }

                    listBox1.Items.Add(wiadomosc);//wiadomość pojawia się w listBoxie
                    listBox1.Update();
                    textBox3.Text = String.Empty; // textBox3.Clear();
                    textBox5.Text = "wiadomość odczytana " + DateTime.Now.ToString();
                    button1.Enabled = true; // wiadomość wysłana
                    nowyKlient.Close();
                    serwer.Stop();//pauzujemy serwer
                }
                while (button1.Enabled == false); // podczas gdy przycisk 1 jest wciśnięty

            }
            catch
            {
                listBox1.Items.Add("błąd połączenia!");
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string host = textBox2.Text; //adres 2 kompa
            int port = Convert.ToInt16(numericUpDown1.Value);

            try // proba połączenia się z serwerem
            {
                TcpClient klient = new TcpClient(host, port);
                NetworkStream ns = klient.GetStream();//odbior wiadomosci
                StreamReader reader = new StreamReader(ns);// czytanie strumienia
                char[] znaki = new char[100];//wiadomosc 100 elementowa
                reader.Read(znaki, 0, 100);//czyta znaki od poczatku do konca
                string komunikat = new string(znaki);
                listBox1.Items.Add(komunikat);
                ns.Close();
                klient.Close();
            }
            catch
            {
                listBox1.Items.Add("brak wiadomości ...");
            }
        }
    }
}
