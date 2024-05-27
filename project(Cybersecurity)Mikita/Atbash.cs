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
using System.Windows.Forms.VisualStyles;

namespace project_Cybersecurity_Mikita
{
    public partial class Atbash : Form
    {
        string key = "zyxwvutsrqponmlkjihgfedcba";
        Thread th;
        public Atbash()
        {
            InitializeComponent();
        }
        public void openForm1(object obj)
        {
            Application.Run(new Form1());
        }

        private void buttonBackAtbash_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text.ToLower(); // Приводим введенный текст к нижнему регистру
            string encryptedText = Encrypt(input, key);
            OutputTextBox.Text = encryptedText;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string input = InputTextBox.Text.ToLower(); // Приводим введенный текст к нижнему регистру
            string decryptedText = Decrypt(input, key);
            OutputTextBox.Text = decryptedText;
        }

        private string Encrypt(string input, string key)
        {
            char[] encryptedChars = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    encryptedChars[i] = ' ';
                }
                else
                {
                    encryptedChars[i] = key[input[i] - 97];
                }
            }
            return new string(encryptedChars);
        }

        private string Decrypt(string input, string key)
        {
            char[] decryptedChars = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    decryptedChars[i] = ' ';
                }
                else
                {
                    int index = key.IndexOf(input[i]) + 97;
                    decryptedChars[i] = (char)index;
                }
            }
            return new string(decryptedChars);
        }
    }
}
