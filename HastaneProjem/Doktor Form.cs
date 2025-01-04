using genel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProjem
{
    public partial class Doktor_Form : Form
    {
        public string doktoradi { get; set; }
        
        public List<genel.hastane> GelenListe = new List<genel.hastane>();
        public Doktor_Form()
        {
            InitializeComponent();
          
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Doktor_Form_Load(object sender, EventArgs e)
        {
            label1.Text = "Hoşgeldiniz Sayın Dr. " + doktoradi.Split(' ')[0];
            listBox1.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            foreach (var randevu in datastore.randevular)
            {
                if (randevu.DoktorAdi == doktoradi)
                {
                    string randevuBilgisi = $"Hasta: {randevu.HastaAdi} {randevu.HastaSoyadi} - Tarih: {randevu.RandevuTarihi} - Saat: {randevu.RandevuSaati}";
                    listBox1.Items.Add(randevuBilgisi);
                }
            }
            listBox1.Show();
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 anamenüyedön = new Form1();
            anamenüyedön.Show();
            this.Close();
        }
    }
}
