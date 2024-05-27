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
    public partial class Form1 : Form
    {
        Thread th;
        public Form1()
        {
            InitializeComponent();
        }

        public void openAtbash(object obj)
        {
            Application.Run(new Atbash());
        }
        public void openCezar(object obj)
        {
            Application.Run(new Cezar());
        }
        public void openVigenere(object obj)
        {
            Application.Run(new Vigenere());
        }
        public void openForm1(object obj)
        {
            Application.Run(new Form1());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openAtbash);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openCezar);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            th = new Thread(openVigenere);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
    }
}
