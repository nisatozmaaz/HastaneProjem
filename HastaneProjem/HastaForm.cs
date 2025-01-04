using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using genel;


namespace HastaneProjem
{

    public partial class HastaForm : Form
    {


        public List<genel.hastane> hastane = new List<genel.hastane>();
        public List<genel.hasta> hassta = new List<genel.hasta>();
        public HastaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///hasta verileri ekleme

            genel.hasta entity = new genel.hasta();
            entity.isim = textBox1.Text;
            entity.soyisim = textBox2.Text;
            entity.tcno = textBox3.Text;
            entity.telefon = maskedTextBox1.Text;
            entity.dogumtarihi = dateTimePicker1.Value.ToString("dd.MM.yy");
            entity.eposta = textBox4.Text;
            hassta.Add(entity);
            ///hastane bilgileri
            genel.hastane randevu = new genel.hastane();
            randevu.randevutarihi = dateTimePicker2.Value.ToString("dd.MM.yy");
            randevu.randevusaati = comboBox3.SelectedItem.ToString();
            randevu.poliklinik = comboBox1.SelectedItem.ToString();
            randevu.doktoradi = comboBox2.SelectedItem.ToString();
            hastane.Add(randevu);

            // Randevu bilgilerini datastore'a kaydet
            datastore.randevular.Add((
                entity.isim,
                entity.soyisim,
                randevu.randevutarihi,
                randevu.randevusaati,
                randevu.doktoradi
            ));
            
            MessageBox.Show("Randevu başarıyla kaydedildi.");
        }

        private void HastaForm_Load(object sender, EventArgs e)
        {
            List<poliklinik> türler = new List<poliklinik>
            {
                new poliklinik{ poliklinikid=1 , tür = "Göz Polikliniği"},
                new poliklinik{ poliklinikid=2 , tür = "Çocuk Hastalıkları Polikliniği"},
                new poliklinik{ poliklinikid=3 , tür = "Ortopedi Polikliniği"},
                new poliklinik{ poliklinikid=4 , tür = "Kadın Hastalıkları Polikliniği"},
                new poliklinik{ poliklinikid=5 , tür = "Dahiliye Polikliniği"},
                new poliklinik{ poliklinikid=6 , tür = "KBB Polikliniği"},
                new poliklinik{ poliklinikid=7 , tür = "Diyetisyenlik Polikliniği"},
                new poliklinik{ poliklinikid=8 , tür = "Psikiyatri Polikliniği"},
            };
            comboBox1.DataSource = türler;
            comboBox1.DisplayMember = "tür";
            comboBox1.ValueMember = "poliklinikid";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();

            if (comboBox1.SelectedItem.ToString() == "Göz Polikliniği")
            {
                comboBox2.Items.Add("Nisa Tozmaz");
                comboBox2.Items.Add("Namık Kemal");
                comboBox2.Items.Add("Ayşe Yılmaz");
            }
            else if (comboBox1.SelectedItem.ToString() == "Dahiliye Polikliniği")
            {
                comboBox2.Items.Add("Mehmet Demir");
                comboBox2.Items.Add("Hüseyin Öztürk");
                comboBox2.Items.Add("Zeynep Kaya");
            }
            else if (comboBox1.SelectedItem.ToString() == "Çocuk Hastalıkları Polikliniği")
            {
                comboBox2.Items.Add("Ali Aslan");
                comboBox2.Items.Add("Fatma Yıldız");
                comboBox2.Items.Add("Hakan Aydın");
            }
            else if (comboBox1.SelectedItem.ToString() == "Kadın Hastalıkları Polikliniği")
            {
                comboBox2.Items.Add("Seda Aksoy");
                comboBox2.Items.Add("Ömer Çetin");
                comboBox2.Items.Add("Mehmet Akın");
            }
            else if (comboBox1.SelectedItem.ToString() == "Ortopedi Polikliniği")
            {
                comboBox2.Items.Add("Murat Çalışkan");
                comboBox2.Items.Add("İsmail Korkmaz");
                comboBox2.Items.Add("Gülcan Yılmaz");
            }
            else if (comboBox1.SelectedItem.ToString() == "KBB Polikliniği")
            {
                comboBox2.Items.Add("Veli Güler");
                comboBox2.Items.Add("Narin Demirtaş");
                comboBox2.Items.Add("Büşra Polat");
            }
            else if (comboBox1.SelectedItem.ToString() == "Diyetisyenlik Polikliniği")
            {
                comboBox2.Items.Add("Serdar Öztürk");
                comboBox2.Items.Add("Rana Kaya");
                comboBox2.Items.Add("Hülya Uslu");
            }
            else if (comboBox1.SelectedItem.ToString() == "Psikiyatri Polikliniği")
            {
                comboBox2.Items.Add("Merve Yılmaz");
                comboBox2.Items.Add("Fatih Karaca");
                comboBox2.Items.Add("Emine Ozan");
            }

        }


        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_DisplayMemberChanged(object sender, EventArgs e)
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
