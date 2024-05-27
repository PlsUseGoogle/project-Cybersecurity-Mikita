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
    public partial class Vigenere : Form
    {
        Thread th;
        public Vigenere()
        {
            InitializeComponent();
        }

        public void openForm1(object obj)
        {
            Application.Run(new Form1());
        }

        private void buttonBackVigenere_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openForm1);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void EncryptButton_Click(object sender, EventArgs e)
        {
            string key = KeyBox.Text.ToLower();
            string txt = InputBox.Text.ToLower();
            string res = Encrypt(txt, key);
            OutputBox.Text = res;
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            string key = KeyBox.Text.ToLower();
            string txt = InputBox.Text.ToLower();
            string res = Decrypt(txt, key);
            OutputBox.Text = res;
        }
        private string Encrypt(string txt, string key)
        {
            int lc = 'a';
            string res = "";
            int index = 0;

            foreach (char c in txt)
            {
                int ke = key[index] - lc;
                int ch = Mod((c - lc + ke), 26);

                if (char.IsLetter(c))
                {
                    res += (char)(ch + lc);
                    index++;
                }
                else
                {
                    res += c;
                }

                index %= key.Length;
            }

            return res;
        }

        private string Decrypt(string txt, string key)
        {
            int lc = 'a';
            string res = "";
            int index = 0;

            foreach (char c in txt)
            {
                int ke = key[index] - lc;
                int ch = Mod((c - lc - ke), 26);

                if (char.IsLetter(c))
                {
                    res += (char)(ch + lc);
                    index++;
                }
                else
                {
                    res += c;
                }

                index %= key.Length;
            }

            return res;
        }

        private int Mod(int a, int b)
        {
            return (a % b + b) % b;
        }
    }
}
