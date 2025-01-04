using genel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProjem
{
    public partial class Doktorgiris : Form
    {

        public Doktorgiris()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciadi = textBox1.Text;
            string sifre = textBox2.Text;

            var doktor = datastore.doktorListesi.FirstOrDefault(d => d.kullanici == kullaniciadi && d.sifre == sifre);
            
            if (doktor != null)
            {
                Doktor_Form doktorlu = new Doktor_Form();
                doktorlu.doktoradi = $"{doktor.doktorisim} {doktor.doktorsoyisim}";
                doktorlu.Show();
                this.Hide();
            }
            else
            {
                label3.Show();
            }
        }
        private void Doktorgiris_Load(object sender, EventArgs e)
        {
            label3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 anamenüyedön = new Form1();
            anamenüyedön.Show();
            this.Hide();
        }
    }
}
