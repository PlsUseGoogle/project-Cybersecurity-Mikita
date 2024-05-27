using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace project_Cybersecurity_Mikita
{
    public partial class Cezar : Form
    {
        Thread th;
        public Cezar()
        {
            InitializeComponent();
        }
        public void openForm1(object obj)
        {
            Application.Run(new Form1());
        }

        private void buttonBackCezar_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            if (int.TryParse(KeyBox.Text, out int key))
            {
                string encrypted = Encipher(input, key);
                OutputTextBox.Text = encrypted;
            }
            else
            {
                MessageBox.Show("Prosze podaj prawidlowy klucz.");
            }
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text;
            if (int.TryParse(KeyBox.Text, out int key))
            {
                string decrypted = Decipher(input, key);
                OutputTextBox.Text = decrypted;
            }
            else
            {
                MessageBox.Show("Prosze podaj prawidlowy klucz.");
            }
        }
        private char Cipher(char ch, int key)
        {
            if (!char.IsLetter(ch))
            {
                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);
        }

        private string Encipher(string input, int key)
        {
            string output = string.Empty;

            foreach (char ch in input)
            {
                output += Cipher(ch, key);
            }

            return output;
        }

        private string Decipher(string input, int key)
        {
            return Encipher(input, 26 - key);
        }
    }
}
