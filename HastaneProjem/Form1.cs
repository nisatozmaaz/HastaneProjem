namespace HastaneProjem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            HastaForm hasta = new HastaForm();
            hasta.Show();
            this.Hide();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Doktorgiris doktor = new Doktorgiris();
            doktor.ShowDialog();
            this.Hide();

        }
    }
}